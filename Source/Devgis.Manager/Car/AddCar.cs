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
    public partial class AddCar : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddCar()
        {
            InitializeComponent();
            InitDataList();
        }
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="ID">需要编辑的ID</param>
        public AddCar(string ID)
        {
            InitializeComponent();

            this.Text = "编辑车辆";
            rbSave.Text = "保存(&S)";

            EditID = ID;

            InitDataList();

            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_car where id='{0}'", ID)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                rtbCarNO.Text = dt.Rows[0]["carno"].ToString();
                rtbColor.Text = dt.Rows[0]["color"].ToString();
                rtbRemarks.Text = dt.Rows[0]["remarks"].ToString();
                rtbTrademark.Text = dt.Rows[0]["trademark"].ToString();//idcard
                dlistParkingType.Text = dt.Rows[0]["parkingtype"].ToString();

                dlistMember.SelectedValue = dt.Rows[0]["memberid"].ToString();
                dlistCarType.SelectedValue = dt.Rows[0]["typeid"].ToString();
            }

        }

        private void InitDataList()
        {
            string sql = "select id,realname from t_member";
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            dlistMember.DataSource = dt;
            dlistMember.DisplayMember = "realname";
            dlistMember.ValueMember = "id";
            
            sql = "select * from t_cartype";
            dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            dlistCarType.DataSource = dt;
            dlistCarType.DisplayMember = "typename";
            dlistCarType.ValueMember = "id";
        }

        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (dlistMember.SelectedValue == null) //允许为空
            {
                //MessageHelper.ShowErrorMessage("请选择所属会员！");
                //dlistMember.Focus();
                //return false;
            }

            if (dlistCarType.SelectedValue == null)
            {
                MessageHelper.ShowErrorMessage("请选择车辆类型！");
                dlistCarType.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(dlistParkingType.Text))
            {
                MessageHelper.ShowErrorMessage("请选择车辆属性！");
                dlistParkingType.Focus();
                return false;
            }


            if (string.IsNullOrEmpty(rtbCarNO.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入车牌号！");
                rtbCarNO.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                if (string.IsNullOrEmpty(EditID))
                {
                    DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from t_car where carno='{0}'", rtbCarNO.Text)).Tables[0];
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        MessageHelper.ShowErrorMessage("车牌号已存在，请检查！");
                        rtbCarNO.Focus();
                        return false;
                    }
                }
            }

            if (string.IsNullOrEmpty(rtbTrademark.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入车辆型号！");
                rtbTrademark.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(rtbColor.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("请输入车辆颜色！");
                rtbColor.Focus();
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
                MySqlParameter[] arrParameter = new MySqlParameter[8];
                sql = "insert into t_car (id,carno,parkingtype,trademark,color,remarks,memberid,typeid)values(@id,@carno,@parkingtype,@trademark,@color,@remarks,@memberid,@typeid)";
                arrParameter[0]=new MySqlParameter("@id",Guid.NewGuid().ToString());
                arrParameter[1] = new MySqlParameter("@carno", rtbCarNO.Text);
                arrParameter[2] = new MySqlParameter("@parkingtype", dlistParkingType.Text);
                arrParameter[3] = new MySqlParameter("@trademark", rtbTrademark.Text);
                arrParameter[4] = new MySqlParameter("@color", rtbColor.Text);
                arrParameter[5] = new MySqlParameter("@remarks", rtbRemarks.Text);
                if (dlistMember.SelectedValue == null)
                {
                    arrParameter[6] = new MySqlParameter("@memberid", string.Empty);
                }
                else
                {
                    arrParameter[6] = new MySqlParameter("@memberid", dlistMember.SelectedValue.ToString());
                }
                arrParameter[7] = new MySqlParameter("@typeid", dlistCarType.SelectedValue.ToString());
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
                MySqlParameter[] arrParameter = new MySqlParameter[8];
                sql = "update t_car set carno=@carno,parkingtype=@parkingtype,trademark=@trademark,color=@color,remarks=@remarks,memberid=@memberid,typeid=@typeid where id=@id";
                arrParameter[0] = new MySqlParameter("@id", EditID);
                arrParameter[1] = new MySqlParameter("@carno", rtbCarNO.Text);
                arrParameter[2] = new MySqlParameter("@parkingtype", dlistParkingType.Text);
                arrParameter[3] = new MySqlParameter("@trademark", rtbTrademark.Text);
                arrParameter[4] = new MySqlParameter("@color", rtbColor.Text);
                arrParameter[5] = new MySqlParameter("@remarks", rtbRemarks.Text);
                if (dlistMember.SelectedValue == null)
                {
                    arrParameter[6] = new MySqlParameter("@memberid", string.Empty);
                }
                else
                {
                    arrParameter[6] = new MySqlParameter("@memberid", dlistMember.SelectedValue.ToString());
                }
                arrParameter[7] = new MySqlParameter("@typeid", dlistCarType.SelectedValue.ToString());
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
