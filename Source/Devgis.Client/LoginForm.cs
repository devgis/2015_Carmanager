﻿using System;
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

namespace Devgis.Client
{
    public partial class LoginForm : BaseWindow
    {
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }
        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (rlistParking.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择停车场！");
                rlistParking.Focus();
                return false;
            }

            if (rlistSentryBox.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择岗亭！");
                rlistSentryBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbUserName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入登陆名！");
                rtbUserName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbUserPassword.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入密码！");
                rtbUserName.Focus();
                return false;
            }
            //查询数据库
            MySqlParameter[] arrParameter = new MySqlParameter[2];
            string sql = "select * from t_operator where loginname=@loginname and password=@possword";
            arrParameter[0] = new MySqlParameter("@loginname", rtbUserName.Text);
            arrParameter[1] = new MySqlParameter("@possword", rtbUserPassword.Text);

            DataTable dt = MySQLHelper.ExecuteQuery(sql, arrParameter).Tables[0];
            if (dt == null || dt.Rows.Count <= 0)
            {
                MessageHelper.ShowErrorMessage("用户不存在或者密码错误！");
                rtbUserName.Focus();
                return false;
            }
            else
            {
                PublicDim.OperatorID = dt.Rows[0]["id"].ToString();
                PublicDim.RealName = dt.Rows[0]["realname"].ToString();
                try
                {
                    PublicDim.RoleID = Convert.ToInt32(dt.Rows[0]["role"]);
                }
                catch
                { }

                if(PublicDim.RoleID!=3&&PublicDim.RoleID!=4)
                {
                    MessageHelper.ShowErrorMessage("用户没有操作权限！");
                    rtbUserName.Focus();
                    return false;
                }

                PublicDim.ParkingID = rlistParking.SelectedValue.ToString();
                PublicDim.ParkingName = rlistParking.Text.ToString();
                PublicDim.SentryBoxID = rlistSentryBox.SelectedValue.ToString();
                PublicDim.SentryBoxName = rlistSentryBox.Text.ToString();


            }
            return true;
        }
        #endregion

        private void rbSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                this.DialogResult = DialogResult.OK;
            }
        }

        private void rbCancel_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            DataTable dttemp = MySQLHelper.ExecuteQuery("select id,name from t_parking").Tables[0];
            rlistParking.ValueMember = "id";
            rlistParking.DisplayMember = "name";
            rlistParking.DataSource = dttemp;
        }

        private void rlistParking_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (rlistParking.SelectedValue != null)
            {
                DataTable dttemp = MySQLHelper.ExecuteQuery(string.Format("select id,name from t_sentrybox where parkingid='{0}'", rlistParking.SelectedValue.ToString())).Tables[0];
                rlistSentryBox.ValueMember = "id";
                rlistSentryBox.DisplayMember = "name";
                rlistSentryBox.DataSource = dttemp;
            }
        }
    }
}
