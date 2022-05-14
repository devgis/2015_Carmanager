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

namespace Devgis.Manager.APP
{
    public partial class AddRecharge : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddRecharge()
        {
            InitializeComponent();

            string sql = "select id,realname from t_member";
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            dlistMember.DataSource = dt;
            dlistMember.DisplayMember = "realname";
            dlistMember.ValueMember = "id";
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

            if (string.IsNullOrEmpty(rtbAmount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入充值金额！");
                rtbAmount.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbAmount.Text);
                }
                catch
                {
                    rtbAmount.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("请输入正确的充值金额！");
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
            string sql1 = "insert into t_rechargehistory(id,memberid,operatorid,amount,rechargetime,remarks)values(@id,@memberid,@operatorid,@amount,now(),@remarks)";
            MySqlParameter[] arrParameter = new MySqlParameter[5];
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@memberid",dlistMember.SelectedValue.ToString());
            arrParameter[2] = new MySqlParameter("@operatorid",PublicDim.OperatorID);
            arrParameter[3] = new MySqlParameter("@amount",Convert.ToDouble(rtbAmount.Text));
            arrParameter[4] = new MySqlParameter("@remarks",rtbRemarks.Text);

            string sql2 = string.Format("update t_member set balance=balance+@addbalance where id=@id"
                ,  dlistMember.SelectedValue.ToString(), Convert.ToDouble(rtbAmount.Text));
            MySqlParameter[] arrParameter2 = new MySqlParameter[2];
            arrParameter2[0] = new MySqlParameter("@id", dlistMember.SelectedValue.ToString());
            arrParameter2[1] = new MySqlParameter("@addbalance", Convert.ToDouble(rtbAmount.Text));

            List<string> listSQLs = new List<string>();
            listSQLs.Add(sql1);
            listSQLs.Add(sql2);

            List<MySqlParameter[]> listMySqlParameters = new List<MySqlParameter[]>();
            listMySqlParameters.Add(arrParameter);
            listMySqlParameters.Add(arrParameter2);
            MySQLHelper.ExecuteTrans(listSQLs, listMySqlParameters);
            return true;
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

        private void AddRecharge_Load(object sender, EventArgs e)
        {

        }
    }
}
