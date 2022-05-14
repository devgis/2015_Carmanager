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

namespace Devgis.Manager.Parking.Basic
{
    public partial class EquipmentList : BaseWindow
    {
        public EquipmentList()
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
            DataTable dt = MySQLHelper.ExecuteQuery("select e.*,s.`name` as sentryboxname,p.`name` as parkingname from t_equipment e left join t_sentrybox s on e.sentryboxid= s.id left join t_parking p on s.parkingid=p.id").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colParkingName"].Value = dr["parkingname"];
                row.Cells["colSentryboxName"].Value = dr["sentryboxname"];
                row.Cells["colEquipmentName"].Value = dr["name"];
                row.Cells["colConnectInfo"].Value = dr["connectinfo"];
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
                AddEquipment frmEdit = new AddEquipment(ID);
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
            AddEquipment frmAdd = new AddEquipment();
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

        private void cmdDel_Click(object sender, EventArgs e)
        {
            string args = string.Empty;

            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colSelect"].Value != null && (bool)row.Cells["colSelect"].Value)
                {
                    // ID = row.Cells["colID"].Value.ToString();
                    if (string.IsNullOrEmpty(args))
                    {
                        args = "'" + row.Cells["colID"].Value.ToString() + "'";
                    }
                    else
                    {
                        args += ",'" + row.Cells["colID"].Value.ToString() + "'";
                    }
                }
            }

            if (string.IsNullOrEmpty(args))
            {
                MessageHelper.ShowErrorMessage("请选择记录进行删除！");
            }
            else
            {
                string sql = string.Format("delete from t_equipment where id in ({0})", args);
                if (MySQLHelper.ExecuteNonQuery(sql) > 0)
                {
                    InitData();
                    MessageHelper.ShowInfoMessage("删除成功！");
                }
                else
                {
                    MessageHelper.ShowErrorMessage("删除失败！");
                }
            }
        }
    }
}
