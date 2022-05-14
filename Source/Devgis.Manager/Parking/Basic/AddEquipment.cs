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
    public partial class AddEquipment : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddEquipment()
        {
            InitializeComponent();
            InitList();
        }
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public AddEquipment(string ID)
        {
            InitializeComponent();
            InitList();
            this.Text = "编辑设备";
            rbSave.Text = "保存(&S)";

            EditID = ID;

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_equipment where id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                dlistParking.SelectedValue = dt.Rows[0]["parkingid"].ToString();
                dlistSentryBox.SelectedValue = dt.Rows[0]["sentryboxid"].ToString();
                rtbEquipmentName.Text = dt.Rows[0]["name"].ToString();
                rtbConnectInfo.Text = dt.Rows[0]["connectinfo"].ToString();
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
                MessageHelper.ShowErrorMessage("请选择停车场！");
                dlistParking.Focus();
                return false;
            }

            if (dlistSentryBox.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择岗亭！");
                dlistSentryBox.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbEquipmentName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入设备名称！");
                rtbEquipmentName.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbConnectInfo.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入设备连接信息！");
                rtbConnectInfo.Focus();
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
                MySqlParameter[] arrParameter = new MySqlParameter[5];
                sql = "insert into t_equipment (id,parkingid,sentryboxid,name,connectinfo)values(@id,@parkingid,@sentryboxid,@name,@connectinfo)";
                arrParameter[0]=new MySqlParameter("@id",Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
                arrParameter[2] = new MySqlParameter("@sentryboxid", dlistSentryBox.SelectedValue.ToString());
                arrParameter[3] = new MySqlParameter("@name",rtbEquipmentName.Text);
                arrParameter[4] = new MySqlParameter("@connectinfo", rtbConnectInfo.Text);
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
                sql = "update t_equipment set parkingid=@parkingid,sentryboxid=@sentryboxid,name=@name,connectinfo=@connectinfo where id=@id";
                arrParameter[0] = new MySqlParameter("@id", EditID);
                arrParameter[1] = new MySqlParameter("@parkingid", dlistParking.SelectedValue.ToString());
                arrParameter[2] = new MySqlParameter("@sentryboxid", dlistSentryBox.SelectedValue.ToString());
                arrParameter[3] = new MySqlParameter("@name", rtbEquipmentName.Text);
                arrParameter[4] = new MySqlParameter("@connectinfo", rtbConnectInfo.Text);
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
            UpdateSentryBoxList();
        }

        private void UpdateSentryBoxList()
        {
            if (dlistParking.SelectedValue != null)
            {
                DataTable dtSentryBox = MySQLHelper.ExecuteQuery("select id,name from t_sentrybox").Tables[0];
                dlistSentryBox.ValueMember = "id";
                dlistSentryBox.DisplayMember = "name";
                dlistSentryBox.DataSource = dtSentryBox;
            }
        }
    }
}
