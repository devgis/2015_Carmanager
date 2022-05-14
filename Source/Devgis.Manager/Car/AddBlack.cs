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
    public partial class AddBlack : BaseWindow
    {
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddBlack()
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
            if (string.IsNullOrEmpty(rtbCarNos.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入登陆名！");
                rtbCarNos.Focus();
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
            string[] arrCarNOs = rtbCarNos.Text.Split(',');
            List<string> listSQLS = new List<string>();
            List<MySqlParameter[]> listParameters = new List<MySqlParameter[]>();
            foreach (string carNo in arrCarNOs)
            {
                string sql = string.Empty;
                //新增
                MySqlParameter[] arrParameter = new MySqlParameter[2];
                sql = "insert into t_carblacklist (id,carno)values(@id,@carno)";
                arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@carno", carNo);
                listSQLS.Add(sql);
                listParameters.Add(arrParameter);
            }
            MySQLHelper.ExecuteTrans(listSQLS, listParameters);
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
    }
}
