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

namespace Devgis.Manager.Parking
{
    public partial class ChargeRuleList : BaseWindow
    {
        public ChargeRuleList()
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
            DataTable dt = MySQLHelper.ExecuteQuery(
                "select  c.id,p.`name` as parkname,starthour,startmonyhour,endmonyhour,maxmoney from t_chargerule c left join t_parking p on c.parkingid=p.id").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvDataList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colParking"].Value = dr["parkname"];
                row.Cells["colStartHour"].Value = dr["starthour"];
                row.Cells["colStartMoneyHour"].Value = dr["startmonyhour"];
                row.Cells["colEndMoneyHour"].Value = dr["endmonyhour"];
                row.Cells["colMaxMoney"].Value = dr["maxmoney"];
                
            }

            foreach (GridViewRowInfo row in rgvDataList.Rows)
            {
                if (row.Cells["colID"].Value != null && "default".Equals(row.Cells["colID"].Value.ToString()))
                {
                    row.Cells["colParking"].Value = "默认";
                }
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
                EditChargeRule frmEdit = new EditChargeRule(ID);
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
            AddChargeRule frmAddChargeRule = new AddChargeRule();
            if (frmAddChargeRule.ShowDialog() == DialogResult.OK)
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
