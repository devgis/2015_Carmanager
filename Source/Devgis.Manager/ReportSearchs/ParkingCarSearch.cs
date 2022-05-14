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

namespace Devgis.Manager.ReportSearchs
{
    public partial class ParkingCarSearch : BaseWindow
    {
        public ParkingCarSearch()
        {
            InitializeComponent();
        }

        private void OperatorList_Shown(object sender, EventArgs e)
        {
            InitData();
        }

        #region 私有方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            rgvOperatorList.Rows.Clear();
            string sql = "select * from v_parkingcarall where entertime between '{0}' and '{1}'";

            sql = string.Format(sql, rdpStartTime.Value.ToString(), rdpEndTime.Value.ToString());
            if (!"*".Equals(rlistParking.SelectedValue.ToString()))
            {
                sql += string.Format(" and parkingid='{0}'", rlistParking.SelectedValue.ToString());

                if (!"*".Equals(rlistSentryBox.SelectedValue.ToString()))
                {
                    sql += string.Format(" and sentryboxid='{0}'", rlistSentryBox.SelectedValue.ToString());
                }
            }
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvOperatorList.Rows.AddNew();
                row.Cells["colParkingName"].Value = dr["parkingname"];
                row.Cells["colSentryName"].Value = dr["sentryboxname"];
                row.Cells["colCarNO"].Value = dr["carno"];
                row.Cells["colEnterTime"].Value = dr["entertime"];
            }
        }
        #endregion
        private void rbFilter_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void ParkingCarSearch_Load(object sender, EventArgs e)
        {
            DataTable dttemp = MySQLHelper.ExecuteQuery("select id,name from t_parking").Tables[0];
            DataRow dr = dttemp.NewRow();
            dr["id"] = "*";
            dr["name"] = "所有";
            dttemp.Rows.InsertAt(dr, 0);
            rlistParking.ValueMember = "id";
            rlistParking.DisplayMember = "name";
            rlistParking.DataSource = dttemp;
        }

        private void rlistParking_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (rlistParking.SelectedValue == null || rlistParking.SelectedValue.ToString() == "*")
            {
                rlistSentryBox.DataSource = null;
            }
            else
            {
                DataTable dttemp = MySQLHelper.ExecuteQuery(string.Format("select id,name from t_sentrybox where parkingid='{0}'",rlistParking.SelectedValue.ToString())).Tables[0];
                DataRow dr = dttemp.NewRow();
                dr["id"] = "*";
                dr["name"] = "所有";
                dttemp.Rows.InsertAt(dr, 0);
                rlistSentryBox.ValueMember = "id";
                rlistSentryBox.DisplayMember = "name";
                rlistSentryBox.DataSource = dttemp;
            }
        }

    }
}
