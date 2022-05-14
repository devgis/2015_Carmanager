using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Devgis.Controls;
using Devgis.Common;
using Telerik.WinControls.UI;
using MySql.Data.MySqlClient;

namespace Devgis.Manager.Parking.Basic
{
    public partial class AddMonthCard : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddMonthCard()
        {
            InitializeComponent();
            rdpStartDate.Value = DateTime.Now.Date;
            InitList();
        }

        private void InitList()
        {
            DataTable dtMember = MySQLHelper.ExecuteQuery("select id,realname from t_member").Tables[0];
            dlistMember.ValueMember = "id";
            dlistMember.DisplayMember = "realname";
            dlistMember.DataSource = dtMember;

            DataTable dtParking = MySQLHelper.ExecuteQuery("select id,name from t_parking").Tables[0];
            dlistParking.ValueMember = "id";
            dlistParking.DisplayMember = "name";
            dlistParking.DataSource = dtParking;
        }
        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (dlistMember.SelectedValue==null)
            {
                MessageHelper.ShowErrorMessage("请选择会员！");
                dlistMember.Focus();
                return false;
            }

            if (dlistParking.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择停车场！");
                dlistParking.Focus();
                return false;
            }

            if (rdpStartDate.Value >= rdpEndDate.Value)
            {
                MessageHelper.ShowErrorMessage("结束日期必须大于开始日期！");
                rdpEndDate.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbAmount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入月费！");
                rtbAmount.Focus();
                return false;
            }
            else
            {
                try
                {
                    double dAmount = Convert.ToDouble(rtbAmount.Text);
                    if (dAmount <= 0)
                    {
                        MessageHelper.ShowErrorMessage("月费必须大于0！");
                        rtbAmount.Focus();
                        return false;
                    }
                    else
                    { 
                        //检查账户余额
                        if (rcbUseBalance.Checked)
                        {
                            if (dAmount > balance)
                            {
                                MessageHelper.ShowErrorMessage("账户余额不足！");
                                rtbAmount.Focus();
                                return false;
                            }
 
                        }
                    }
                }
                catch
                {
                    MessageHelper.ShowErrorMessage("月费必须为大于0的数字！");
                    rtbAmount.Focus();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        private bool Save()
        {
            List<string> listSQLs = new List<string>();
            List<MySqlParameter[]> listMySqlParameters = new List<MySqlParameter[]>();

            double amount = Convert.ToDouble(rtbAmount.Text);

            //新增
            MySqlParameter[] arrParameter = new MySqlParameter[8];
            string sql = "insert into t_monthcard(id,memberid,parkingid,startdate,enddate,amount,operatorid,operatortime,usebalance)values(@id,@memberid,@parkingid,@startdate,@enddate,@amount,@operatorid,now(),@usebalance)";
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@memberid", dlistMember.SelectedValue.ToString());
            arrParameter[2] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
            arrParameter[3] = new MySqlParameter("@startdate", rdpStartDate.Value.Date);
            arrParameter[4] = new MySqlParameter("@enddate", rdpEndDate.Value.Date);
            arrParameter[5] = new MySqlParameter("@amount", amount);
            arrParameter[6] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
            if (rcbUseBalance.Checked)
            {
                arrParameter[7] = new MySqlParameter("@usebalance",1);
            }
            else
            {
                arrParameter[7] = new MySqlParameter("@usebalance", 0);
            }
            

            //处理财务
            MySqlParameter[] arrParameter2 = new MySqlParameter[2];
            string sql2 = "update t_parking set balance=balance+@amount where id=@parkingid";
            arrParameter2[0] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
            arrParameter2[1] = new MySqlParameter("@amount", amount);

            listSQLs.Add(sql);
            listMySqlParameters.Add(arrParameter);

            listSQLs.Add(sql2);
            listMySqlParameters.Add(arrParameter2);

            //扣减会员账户
            if (rcbUseBalance.Checked)
            {
                MySqlParameter[] arrParameter3 = new MySqlParameter[2];
                string sql3 = "update t_member set balance=balance-@amount where id=@memberid";
                arrParameter3[0] = new MySqlParameter("@memberid", dlistMember.SelectedValue.ToString());
                arrParameter3[1] = new MySqlParameter("@amount", amount);

                listSQLs.Add(sql3);
                listMySqlParameters.Add(arrParameter3);
            }

            try
            {
                MySQLHelper.ExecuteTrans(listSQLs, listMySqlParameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        private void rbSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    if (Save())
                    {
                        MessageHelper.ShowInfoMessage("保存成功！");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageHelper.ShowErrorMessage("保存失败！");
                    }
                }
                catch(Exception ex)
                {
                    MessageHelper.ShowErrorMessage("Err:"+ex.Message);
                }
            }
        }

        private void rdpStartDate_ValueChanged(object sender, EventArgs e)
        {
            rdpEndDate.Value = rdpStartDate.Value.AddMonths(1);
        }
        double balance = 0;
        private void dlistMember_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (dlistMember.SelectedValue != null)
            {
                string memeberid = dlistMember.SelectedValue.ToString();
                string sql = string.Format("select balance from t_member where id='{0}'", memeberid);
                balance = 0;
                try
                {
                    balance = Convert.ToDouble(MySQLHelper.ExecuteQuery(sql).Tables[0].Rows[0][0]);

                }
                catch
                { }
                rlBalance.Text = "账户余额：" + balance + " 元";
            }
        }
    }
}
