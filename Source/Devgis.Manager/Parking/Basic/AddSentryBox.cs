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
    public partial class AddSentryBox : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddSentryBox()
        {
            InitializeComponent();
            InitList();
        }
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public AddSentryBox(string ID)
        {
            InitializeComponent();
            InitList();
            this.Text = "编辑岗亭";
            rbSave.Text = "保存(&S)";

            EditID = ID;

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_sentrybox where id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                dlistParking.SelectedValue = dt.Rows[0]["parkingid"].ToString();
                rtbSentryBox.Text = dt.Rows[0]["name"].ToString();
                rtbEnterInfo.Text = dt.Rows[0]["enterinfo"].ToString();
                rtbOutInfo.Text = dt.Rows[0]["outinfo"].ToString();
                rtbVideo1.Text = dt.Rows[0]["video1"].ToString();
                rtbVideo2.Text = dt.Rows[0]["video2"].ToString();
                rtbVideo3.Text = dt.Rows[0]["video3"].ToString();
                rtbVideo4.Text = dt.Rows[0]["video4"].ToString();
            }

        }

        #region 私有方法

        private void InitList()
        {
            DataTable dtParking = MySQLHelper.ExecuteQuery("select id,name from t_parking").Tables[0];
            dlistParking.ValueMember = "id";
            dlistParking.DisplayMember = "name";
            dlistParking.DataSource = dtParking;
        }

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (dlistParking.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择停车场名称！");
                dlistParking.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbSentryBox.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入岗亭名称！");
                rtbSentryBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbEnterInfo.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入入口信息！");
                rtbEnterInfo.Focus();
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
                MySqlParameter[] arrParameter = new MySqlParameter[9];
                sql = "insert into t_sentrybox (id,parkingid,name,enterinfo,outinfo,video1,video2,video3,video4)values(@id,@parkingid,@name,@enterinfo,@outinfo,@video1,@video2,@video3,@video4)";
                arrParameter[0]=new MySqlParameter("@id",Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
                arrParameter[2] = new MySqlParameter("@name", rtbSentryBox.Text);
                arrParameter[3] = new MySqlParameter("@enterinfo",rtbEnterInfo.Text);
                arrParameter[4] = new MySqlParameter("@outinfo",rtbOutInfo.Text);
                arrParameter[5] = new MySqlParameter("@video1", rtbVideo1.Text);
                arrParameter[6] = new MySqlParameter("@video2", rtbVideo2.Text);
                arrParameter[7] = new MySqlParameter("@video3", rtbVideo3.Text);
                arrParameter[8] = new MySqlParameter("@video4", rtbVideo4.Text);
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
                MySqlParameter[] arrParameter = new MySqlParameter[9];
                sql = "update t_sentrybox set parkingid=@parkingid,name=@name,enterinfo=@enterinfo,outinfo=@outinfo,video1=@video1,video2=@video2,video3=@video3,video4=@video4 where id=@id";
                arrParameter[0] = new MySqlParameter("@id", EditID);
                arrParameter[1] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
                arrParameter[2] = new MySqlParameter("@name", rtbSentryBox.Text);
                arrParameter[3] = new MySqlParameter("@enterinfo", rtbEnterInfo.Text);
                arrParameter[4] = new MySqlParameter("@outinfo", rtbOutInfo.Text);
                arrParameter[5] = new MySqlParameter("@video1", rtbVideo1.Text);
                arrParameter[6] = new MySqlParameter("@video2", rtbVideo2.Text);
                arrParameter[7] = new MySqlParameter("@video3", rtbVideo3.Text);
                arrParameter[8] = new MySqlParameter("@video4", rtbVideo4.Text);
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
