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

namespace Devgis.Manager.Coupons
{
    public partial class CouponsList : BaseWindow
    {
        public CouponsList()
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
            rgvDataList.Rows.Clear();
            DataTable dt = MySQLHelper.ExecuteQuery("select * from t_coupons").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colTotalAmount"].Value = dr["totalamount"];
                row.Cells["colAmount"].Value = dr["amount"];
                row.Cells["colCreateTime"].Value = dr["createtime"];
                row.Cells["colState"].Value = dr["state"];
                if (Convert.ToInt16(dr["state"]) == 1)
                {
                    row.Cells["colStateName"].Value = "已使用";
                }
                else
                {
                    row.Cells["colStateName"].Value = "未使用";
                }
            }
        }
        #endregion

        #region 界面事件方法
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InitData(); //刷新
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddCoupons frmAdd = new AddCoupons();
            if (frmAdd.ShowDialog() == DialogResult.OK)
            {
                //刷新
                InitData();
            }
        }

        private void rgvDataList_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Column.Name == "colSelect")
            {
                if (rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null&&(bool)rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value= false;
                }
                else
                {
                    rgvDataList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                //MessageBox.Show(e.Value.ToString());
            }
        }
        #endregion
    }
}
