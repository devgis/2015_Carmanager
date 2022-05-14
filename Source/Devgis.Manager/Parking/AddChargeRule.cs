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

namespace Devgis.Manager.Parking
{
    public partial class AddChargeRule : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddChargeRule()
        {
            InitializeComponent();

            string sql = "select id,name from t_parking where id not in (select parkingid from t_chargerule)";
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            dlistParking.DataSource = dt;
            dlistParking.DisplayMember = "name";
            dlistParking.ValueMember = "id";

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
                MessageHelper.ShowErrorMessage("请选择停车场！");
                dlistParking.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                if (string.IsNullOrEmpty(EditID))
                {
                    DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_chargerule where parkingid='{0}'", dlistParking.SelectedValue.ToString())).Tables[0];
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        MessageHelper.ShowErrorMessage("停车场收费规则已存在，请在列表中选择后进行编辑！");
                        dlistParking.Focus();
                        return false;
                    }
                }
            }

            if (string.IsNullOrEmpty(rtbStartHour.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入开始小时数，如果不需要请输入0！");
                rtbStartHour.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbStartHour.Text);
                }
                catch
                {
                    rtbStartHour.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("开始小时数必须为数字，如果不需要请输入0！");
                    rtbStartHour.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbStartMoneyHour.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入初始单价，如果不需要请输入0！");
                rtbStartMoneyHour.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbStartMoneyHour.Text);
                }
                catch
                {
                    rtbStartMoneyHour.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("初始单价必须为数字，如果不需要请输入0！");
                    rtbStartMoneyHour.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbEndMoneyHour.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入超出部分单价，如果不需要请输入0！");
                rtbEndMoneyHour.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbEndMoneyHour.Text);
                }
                catch
                {
                    rtbEndMoneyHour.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("超出部分单价必须为数字，如果不需要请输入0！");
                    rtbEndMoneyHour.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbMaxMoney.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入金额上限，如果不需要请输入0！");
                rtbMaxMoney.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbEndMoneyHour.Text);
                }
                catch
                {
                    rtbMaxMoney.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("金额上限必须为数字，如果不需要请输入0！");
                    rtbMaxMoney.Focus();
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
            MySqlParameter[] arrParameter = new MySqlParameter[6];
            sql = "insert into t_chargerule (id,parkingid,starthour,startmonyhour,endmonyhour,maxmoney)values(@id,@parkingid,@starthour,@startmonyhour,@endmonyhour,@maxmoney)";
            arrParameter[0] = new MySqlParameter("@id", Guid.NewGuid().ToString());
            arrParameter[1] = new MySqlParameter("@starthour", Convert.ToDouble(rtbStartHour.Text));
            arrParameter[2] = new MySqlParameter("@startmonyhour", Convert.ToDouble(rtbStartMoneyHour.Text));
            arrParameter[3] = new MySqlParameter("@endmonyhour", Convert.ToDouble(rtbEndMoneyHour.Text));
            arrParameter[4] = new MySqlParameter("@maxmoney", Convert.ToDouble(rtbMaxMoney.Text));
            arrParameter[5] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
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
