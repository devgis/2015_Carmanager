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
    public partial class FeeInfo : BaseWindow
    {
        private string _CarNO;
        public FeeInfo(string CarNO)
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
            string sql = string.Format("select parkingname,entertime,outtime,amount from v_parkingcarlog where carno='{0}'"
                , CarNO);
            
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["parkingname"];
                row.Cells["colOutTime"].Value = dr["outtime"];
                row.Cells["colEnterTime"].Value = dr["entertime"];
                row.Cells["colAmount"].Value = dr["amount"];
            }
        }
        #endregion
    }
}
