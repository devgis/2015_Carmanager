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
using Devgis.Manager.ReportSearchs.CarDetail;

namespace Devgis.Manager.ReportSearchs
{
    public partial class CarDetailSearch : BaseWindow
    {
        public CarDetailSearch()
        {
            InitializeComponent();
        }

        #region 私有方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            //string sql = string.Format("select carno,'详细信息' as detail,'停车信息' as parkinfo,'缴费信息' as feeinfo from v_car where carno like '%{0}%' and mobile like '%{1}%'", rbCarNO.Text, rbMobile.Text);
            //DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            //rgvDataList.DataSource = dt;

            MySqlParameter[] arrParameter = new MySqlParameter[2];
            string sql = "select carno,'详细信息' as detail,'停车信息' as parkinfo,'缴费信息' as feeinfo from v_car where carno like @carno and mobile like @mobile";
            arrParameter[0] = new MySqlParameter("@carno", "%" + rbCarNO.Text + "%");
            arrParameter[1] = new MySqlParameter("@mobile", "%" + rbMobile.Text+"%");
            DataTable dt = MySQLHelper.ExecuteQuery(sql,arrParameter).Tables[0];
            rgvDataList.DataSource = dt;
        }
        #endregion


        private void rbFilter_Click(object sender, EventArgs e)
        {
            InitData(); 
        }

        private void rgvDataList_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string CarNO = rgvDataList.Rows[e.RowIndex].Cells["colCarNO"].Value.ToString();
                if (string.IsNullOrEmpty(CarNO))
                {
                    MessageHelper.ShowErrorMessage("车牌号为空！");
                }
                else
                {
                    switch (e.Column.Name)
                    {
                        case "colDetail":
                            ShowCarDetail frmShowCarDetail = new ShowCarDetail(CarNO);
                            frmShowCarDetail.ShowDialog();
                            break;
                        case "colParking":
                            ParkingInfo frmParkingInfo = new ParkingInfo(CarNO);
                            frmParkingInfo.ShowDialog();
                            break;
                        case "colFee":
                            FeeInfo frmFeeInfo = new FeeInfo(CarNO);
                            frmFeeInfo.ShowDialog();
                            break;
                    }
                }
            }
        }
    }
}
