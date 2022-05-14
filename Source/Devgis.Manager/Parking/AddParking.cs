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
    public partial class AddParking : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddParking()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public AddParking(string ID)
        {
            InitializeComponent();

            this.Text = "编辑停车场";
            rbSave.Text = "保存(&S)";

            EditID = ID;

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_parking where id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                rtbName.Text = dt.Rows[0]["name"].ToString();
                rtbName.ReadOnly = true; //不允许修改
                rtbAddress.Text = dt.Rows[0]["address"].ToString();
                rtbY.Text = dt.Rows[0]["x"].ToString();
                rtbX.Text = dt.Rows[0]["y"].ToString();//idcard
                rtbZone.Text = dt.Rows[0]["zone"].ToString();
                rtbSpaceCount.Text = dt.Rows[0]["spacecount"].ToString();
                rtbZone.Focus();
            }

        }

        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (string.IsNullOrEmpty(rtbName.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入停车场名称！");
                rtbName.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                if (string.IsNullOrEmpty(EditID))
                {
                    DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_parking where name='{0}'", rtbName.Text)).Tables[0];
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        MessageHelper.ShowErrorMessage("停车场名称已存在，请检查！");
                        rtbName.Focus();
                        return false;
                    }
                }
            }

            if (string.IsNullOrEmpty(rtbZone.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入地区！");
                rtbZone.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbAddress.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入地址！");
                rtbAddress.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbSpaceCount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入车位数！");
                rtbSpaceCount.Focus();
                return false;
            }
            else
            {
                try
                {
                    if(Convert.ToInt32(rtbSpaceCount.Text)<=0)
                    {
                        MessageHelper.ShowErrorMessage("车位数必须为大于0的整数！");
                        rtbSpaceCount.Focus();
                        return false;
                    }
                }
                catch
                {
                    rtbSpaceCount.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("车位数必须为整数类型！");
                    rtbSpaceCount.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbX.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入经度！");
                rtbX.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbX.Text);
                }
                catch
                {
                    rtbX.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("请纬度必须是数字类型！");
                    rtbX.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbY.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入纬度！");
                rtbY.Focus();
                return false;
            }
            else
            {
                try
                {
                    Convert.ToDouble(rtbY.Text);
                }
                catch
                {
                    rtbY.Text = string.Empty;
                    MessageHelper.ShowErrorMessage("请纬度必须是数字类型！");
                    rtbY.Focus();
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
                MySqlParameter[] arrParameter = new MySqlParameter[8];
                sql = "insert into t_parking (id,name,address,x,y,balance,operatorid,createtime,zone,spacecount)values(@id,@name,@address,@x,@y,0,@operatorid,now(),@zone,@spacecount)";
                arrParameter[0]=new MySqlParameter("@id",Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@name",rtbName.Text);
                arrParameter[2] = new MySqlParameter("@address", rtbAddress.Text);
                arrParameter[3] = new MySqlParameter("@x", Convert.ToDouble(rtbX.Text));
                arrParameter[4] = new MySqlParameter("@y", Convert.ToDouble(rtbY.Text));
                arrParameter[5] = new MySqlParameter("@operatorid", PublicDim.OperatorID);
                arrParameter[6] = new MySqlParameter("@zone", rtbZone.Text);
                arrParameter[7] = new MySqlParameter("@spacecount", Convert.ToInt32(rtbSpaceCount.Text));
                
                
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
                MySqlParameter[] arrParameter = new MySqlParameter[7];
                sql = "update t_parking set id=@id,name=@name,address=@address,x=@x,y=@y,zone=@zone,spacecount=@spacecount where id=@id";
                arrParameter[0] = new MySqlParameter("@id", EditID);
                arrParameter[1] = new MySqlParameter("@name", rtbName.Text);
                arrParameter[2] = new MySqlParameter("@address", rtbAddress.Text);
                arrParameter[3] = new MySqlParameter("@x", Convert.ToDouble(rtbX.Text));
                arrParameter[4] = new MySqlParameter("@y", Convert.ToDouble(rtbY.Text));
                arrParameter[5] = new MySqlParameter("@zone", rtbZone.Text);
                arrParameter[6] = new MySqlParameter("@spacecount", Convert.ToInt32(rtbSpaceCount.Text));
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
