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
    public partial class CarList : BaseWindow
    {
        public CarList()
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
            DataTable dt = MySQLHelper.ExecuteQuery("select c.id,m.realname as membername,m.mobile,c.carno,c.parkingtype,t.typename,c.trademark,c.color,c.remarks from t_car c left join t_cartype t on c.typeid=t.id left join t_member m on c.memberid=m.id").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colMemberName"].Value = dr["membername"];
                row.Cells["colMemberPhone"].Value = dr["mobile"];
                row.Cells["colCarNO"].Value = dr["carno"];
                row.Cells["colCarType"].Value = dr["typename"];

                row.Cells["colParkingType"].Value = dr["parkingtype"];
                row.Cells["colTrademark"].Value = dr["trademark"];
                row.Cells["colRemarks"].Value = dr["remarks"];
                row.Cells["colColor"].Value = dr["color"];
            }
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
                AddCar frmEdit = new AddCar(ID);
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    InitData();//刷新
                }
            }
            else if (Count > 1)
            {
                MessageHelper.ShowErrorMessage("请最多选择一条记录进行编辑！");
            }
            //MessageBox.Show(Count.ToString());
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            AddCar frmAdd = new AddCar();
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
