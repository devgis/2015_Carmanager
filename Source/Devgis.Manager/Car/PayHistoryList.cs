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

namespace Devgis.Manager.Car
{
    public partial class PayHistoryList : BaseWindow
    {
        public PayHistoryList()
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
            DataTable dt = MySQLHelper.ExecuteQuery("select * from v_parkingcarlog").Tables[0];
            rgvDataList.DataSource = dt;
            /*
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colParkiNgname"].Value = dr["parkingname"];
                row.Cells["colCarNO"].Value = dr["carno"];
                row.Cells["colMemberName"].Value = dr["membername"];
                row.Cells["colEnterTime"].Value = dr["entertime"];
                row.Cells["colOutTime"].Value = dr["outtime"];
                row.Cells["colCouponsCode"].Value = dr["couponscode"];
                row.Cells["colAmount"].Value = dr["amount"];
                row.Cells["colOperatorName"].Value = dr["operatorname"];
                row.Cells["colOperatorTime"].Value = dr["operatortime"];
            }
             * */
        }
        #endregion

        #region 界面事件方法
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InitData(); //刷新
        }

        private void cmdEdit_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string ID = string.Empty;
            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colSelect"].Value!=null&&(bool)row.Cells["colSelect"].Value)
                {
                    ID = row.Cells["colID"].Value.ToString();
                    Count++;
                }
            }
            if (Count <= 0)
            {
                MessageHelper.ShowErrorMessage("请选择记录进行编辑！");
            }
            else if (Count == 1)
            {
                //AddCarType frmEdit = new AddCarType(ID);
                //if (frmEdit.ShowDialog() == DialogResult.OK)
                //{
                //    InitData();//刷新
                //}
            }
            else if (Count > 1)
            {
                MessageHelper.ShowErrorMessage("请最多选择一条记录进行编辑！");
            }
            //MessageBox.Show(Count.ToString());
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddCarType frmAdd = new AddCarType();
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
