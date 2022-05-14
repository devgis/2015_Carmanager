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

namespace Devgis.Manager.ReportSearchs.CarDetail
{
    public partial class ParkingInfo : BaseWindow
    {
        private string _CarNO;
        public ParkingInfo(string CarNO)
        {
            InitializeComponent();
            _CarNO = CarNO;
        }

        private void OperatorList_Shown(object sender, EventArgs e)
        {
            InitData(_CarNO);
        }

        #region 私有方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData(string CarNO)
        {
            rgvDataList.Rows.Clear();
            string sql = string.Format("select p.`name` as parkingname,s.`name` as sentryboxname,c.entertime from t_parkingcar c left join t_parking p on c.parkingid=p.id left join t_sentrybox s on c.sentryboxid=s.id where c.carno='{0}'"
                , CarNO);
            
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["parkingname"];
                row.Cells["colEnterName"].Value = dr["sentryboxname"];
                row.Cells["colEnterTime"].Value = dr["entertime"];
            }
        }
        #endregion
    }
}
