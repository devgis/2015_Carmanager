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

namespace Devgis.Manager.Car
{
    public partial class AddCarType : BaseWindow
    {
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddCarType()
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
            if (string.IsNullOrEmpty(rtbTypeName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入类型名！");
                rtbTypeName.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_cartype where typename='{0}'", rtbTypeName.Text)).Tables[0];
                if (dt != null && dt.Rows.Count > 0)
                {
                    MessageHelper.ShowErrorMessage("类型已存在，请检查！");
                    rtbTypeName.Focus();
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
            //新增
            MySqlParameter[] arrParameter = new MySqlParameter[2];
            sql = "insert into t_cartype (id,typename)values(@id,@typename)";
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@typename", rtbTypeName.Text);
            if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
            {
                return true;
            }
            else
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
    }
}
