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
    public partial class EditChargeRule : BaseWindow
    {
        string EditID = string.Empty;

        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public EditChargeRule(string ID)
        {
            InitializeComponent();

            //this.Text = "编辑会员";
            //rbSave.Text = "保存(&S)";

            EditID = ID;

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select  c.id,p.`name` as parkname,starthour,startmonyhour,endmonyhour,maxmoney from t_chargerule c left join t_parking p on c.parkingid=p.id where c.id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                if ("default".Equals(dt.Rows[0]["id"].ToString()))
                {
                    rtbParkingName.Text = "默认";
                }
                else
                {
                    rtbParkingName.Text = dt.Rows[0]["parkname"].ToString();
                }

                rtbStartHour.Text = dt.Rows[0]["starthour"].ToString();
                rtbStartMoneyHour.Text = dt.Rows[0]["startmonyhour"].ToString();
                rtbEndMoneyHour.Text = dt.Rows[0]["endmonyhour"].ToString();
                rtbMaxMoney.Text = dt.Rows[0]["maxmoney"].ToString();
            }

        }

        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
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
            //编辑
            MySqlParameter[] arrParameter = new MySqlParameter[5];
            sql = "update t_chargerule set starthour=@starthour,startmonyhour=@startmonyhour,endmonyhour=@endmonyhour,maxmoney=@maxmoney where id=@id";
            arrParameter[0] = new MySqlParameter("@id", EditID);
            arrParameter[1] = new MySqlParameter("@starthour", Convert.ToDouble(rtbStartHour.Text));
            arrParameter[2] = new MySqlParameter("@startmonyhour", Convert.ToDouble(rtbStartMoneyHour.Text));
            arrParameter[3] = new MySqlParameter("@endmonyhour", Convert.ToDouble(rtbEndMoneyHour.Text));
            arrParameter[4] = new MySqlParameter("@maxmoney", Convert.ToDouble(rtbMaxMoney.Text));
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

        private void rbCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
