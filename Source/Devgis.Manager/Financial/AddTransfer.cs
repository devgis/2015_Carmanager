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
    public partial class AddTransfer : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddTransfer()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public AddTransfer(string ID)
        {
            InitializeComponent();

            this.Text = "编辑会员";
            rbSave.Text = "保存(&S)";

            EditID = ID;

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_member where id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                rtbLoginName.Text = dt.Rows[0]["loginname"].ToString();
                rtbLoginName.ReadOnly = true; //不允许修改
                rtbRealName.Text = dt.Rows[0]["realname"].ToString();
                rtbPassword.Text = dt.Rows[0]["password"].ToString();
                rtbPassword2.Text = dt.Rows[0]["password"].ToString();
                rtbIDCard.Text = dt.Rows[0]["idcard"].ToString();//idcard
                rtbRealName.Focus();
            }

        }

        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (string.IsNullOrEmpty(rtbLoginName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入登陆名！");
                rtbLoginName.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                if (string.IsNullOrEmpty(EditID))
                {
                    DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_member where loginname='{0}'", rtbLoginName.Text)).Tables[0];
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        MessageHelper.ShowErrorMessage("登陆名已存在，请检查！");
                        rtbLoginName.Focus();
                        return false;
                    }
                }
            }

            if (string.IsNullOrEmpty(rtbRealName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入真名！");
                rtbRealName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbIDCard.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入身份证号！");
                rtbIDCard.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbPassword.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入密码！");
                rtbPassword.Focus();
                return false;
            }
            else
            {
                if (rtbPassword.Text != rtbPassword2.Text)
                {
                    MessageHelper.ShowErrorMessage("两次输入的密码不一致请检查！");
                    rtbPassword.Focus();
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
            string sql = string.Empty;
            if (string.IsNullOrEmpty(EditID))
            {
                //新增
                MySqlParameter[] arrParameter = new MySqlParameter[5];
                sql = "insert into t_member (id,loginname,realname,password,idcard,isdeleted,balance)values(@id,@loginname,@realname,@password,@idcard,0,0)";
                arrParameter[0]=new MySqlParameter("@id",Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@loginname",rtbLoginName.Text);
                arrParameter[2] = new MySqlParameter("@realname",rtbRealName.Text);
                arrParameter[3] = new MySqlParameter("@password", rtbPassword.Text);
                arrParameter[4] = new MySqlParameter("@idcard", rtbIDCard.Text);
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
                MySqlParameter[] arrParameter = new MySqlParameter[5];
                sql = "update t_member set loginname=@loginname,realname=@realname,password=@password,idcard=@idcard,isdeleted=0 where id=@id";
                arrParameter[0] = new MySqlParameter("@id", EditID);
                arrParameter[1] = new MySqlParameter("@loginname", rtbLoginName.Text);
                arrParameter[2] = new MySqlParameter("@realname", rtbRealName.Text);
                arrParameter[3] = new MySqlParameter("@password", rtbPassword.Text);
                arrParameter[4] = new MySqlParameter("@idcard", rtbIDCard.Text);
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
    }
}
