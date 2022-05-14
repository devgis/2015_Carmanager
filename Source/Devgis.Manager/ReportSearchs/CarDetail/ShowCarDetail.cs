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

namespace Devgis.Manager.ReportSearchs.CarDetail
{
    public partial class ShowCarDetail : BaseWindow
    {
        /// <summary>
        /// 编辑构造函数
        /// </summary>
        /// <param name="CarNO">需要编辑的ID</param>
        public ShowCarDetail(string CarNO)
        {
            InitializeComponent();
            DataTable dt = MySQLHelper.ExecuteQuery(string.Format("select * from v_car where carno='{0}'", CarNO)).Tables[0];
            if (dt == null || dt.Rows.Count <=0)
            {
                MessageHelper.ShowErrorMessage("记录不存在存在，请检查！");
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
                rtbTradeMark.Text = dt.Rows[0]["trademark"].ToString();
                rtbCarNO.Text = dt.Rows[0]["carno"].ToString();
                rtbMemberName.Text = dt.Rows[0]["membername"].ToString();
                rtbProprty.Text = dt.Rows[0]["parkingtype"].ToString();//idcard
                rtbColor.Text = dt.Rows[0]["color"].ToString();
                rtbType.Text = dt.Rows[0]["typename"].ToString();
                rtbRemarks.Text = dt.Rows[0]["remarks"].ToString();
                rtbMobile.Text = dt.Rows[0]["mobile"].ToString();
            }

        }

        private void rbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
