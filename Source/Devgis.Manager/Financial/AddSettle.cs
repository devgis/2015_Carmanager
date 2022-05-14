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

namespace Devgis.Manager.Financial
{
    public partial class AddSettle : BaseWindow
    {
        string EditID = string.Empty;
        double balance = 0;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddSettle()
        {
            InitializeComponent();
            InitDataList();
        }
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public AddSettle(string ID)
        {
            InitializeComponent();
            InitDataList();
            this.Text = "编辑结算";
            rbSave.Text = "保存(&S)";

            EditID = ID;

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_settle where id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                dlistParking.SelectedValue = dt.Rows[0]["parkingid"].ToString();
                rtbAccountOwner.Text = dt.Rows[0]["accountwwner"].ToString();
                rtbAccount.Text = dt.Rows[0]["account"].ToString();
                rtbAmount.Text = dt.Rows[0]["amount"].ToString();
                rtbRemarks.Text = dt.Rows[0]["remarks"].ToString();
            }

        }
        private void InitDataList()
        {
            string sql = "select id,name from t_parking";
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            dlistParking.DisplayMember = "name";
            dlistParking.ValueMember = "id";
            dlistParking.DataSource = dt;
        }

        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (dlistParking.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择需要结算的停车场！");
                dlistParking.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbAmount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入转账金额！");
                rtbAmount.Focus();
                return false;
            }
            else
            {
                try
                {
                    if (balance < Convert.ToDouble(rtbAmount.Text))
                    {
                        MessageHelper.ShowErrorMessage("余额不足！");
                        rtbAmount.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowErrorMessage("请输入正确的转账金额（整数，小数）！");
                    rtbAmount.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbBankName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入银行名称！");
                rtbBankName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbAccountOwner.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入账户户主！");
                rtbAccountOwner.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbAccount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入银行账户！");
                rtbAccount.Focus();
                return false;
            }
            return true;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        private bool Save()
        {
            string sql = string.Empty;
            if (string.IsNullOrEmpty(EditID))
            {
                //新增
                MySqlParameter[] arrParameter = new MySqlParameter[8];
                sql = "insert into t_settle (id,parkingid,accountowner,bankaccount,amount,remarks,addtime,lastedittime,operatorid,lasteditoperatorid,bankname,state)values(@id,@parkingid,@accountowner,@bankaccount,@amount,@remarks,now(),now(),@operatorid,@operatorid,@bankname,0)";
                arrParameter[0]=new MySqlParameter("@id",Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@parkingid",dlistParking.SelectedValue.ToString());
                arrParameter[2] = new MySqlParameter("@accountowner",rtbAccountOwner.Text);
                arrParameter[3] = new MySqlParameter("@bankaccount", rtbAccount.Text);
                arrParameter[4] = new MySqlParameter("@amount", Convert.ToDouble(rtbAmount.Text));
                arrParameter[5] = new MySqlParameter("@remarks",rtbRemarks.Text);
                arrParameter[6] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
                arrParameter[7] = new MySqlParameter("@bankname", rtbBankName.Text);

                if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                //修改
                MySqlParameter[] arrParameter = new MySqlParameter[8];
                sql = "update t_settle set parkingid=@parkingid,accountowner=@accountowner,bankaccount=@bankaccount,amount=@amount,remarks=@remarks,lastedittime=now(),lasteditoperatorid=@operatorid,bankname=@bankname where id=@id";
                arrParameter[0] = new MySqlParameter("@id", EditID);
                arrParameter[1] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
                arrParameter[2] = new MySqlParameter("@accountowner", rtbAccountOwner.Text);
                arrParameter[3] = new MySqlParameter("@bankaccount", rtbAccount.Text);
                arrParameter[4] = new MySqlParameter("@amount", Convert.ToDouble(rtbAmount.Text));
                arrParameter[5] = new MySqlParameter("@remarks", rtbRemarks.Text);
                arrParameter[6] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
                arrParameter[7] = new MySqlParameter("@bankname", rtbBankName.Text);

                if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        private void dlistParking_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            		

            if (dlistParking.SelectedValue != null && !"System.Data.DataRowView".Equals(dlistParking.SelectedValue.ToString()))
            {
                string parkingid = dlistParking.SelectedValue.ToString();
                string sql = string.Format("select balance from t_parking where id='{0}'", parkingid);
                try
                {
                    balance = Convert.ToDouble(MySQLHelper.ExecuteQuery(sql).Tables[0].Rows[0][0]);
                }
                catch
                { }
                rlbBalance.Text = balance + "元";
            }
            
        }
    }
}
