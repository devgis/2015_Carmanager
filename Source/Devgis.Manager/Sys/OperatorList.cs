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

namespace Devgis.Manager.Sys
{
    public partial class OperatorList : BaseWindow
    {
        public OperatorList()
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
            DataTable dt = MySQLHelper.ExecuteQuery("select * from t_operator where isdeleted <>1 ||isdeleted is NULL").Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvOperatorList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colLoginName"].Value = dr["loginname"];
                row.Cells["colRealName"].Value = dr["realname"];
                row.Cells["colPassword"].Value = dr["password"];

                int role = Convert.ToInt16(dr["role"]);
                if (PublicDim.DicRole.ContainsKey(role))
                {
                    row.Cells["colRole"].Value = PublicDim.DicRole[role];
                }
            }
        }
        #endregion

        #region 界面事件方法
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InitData(); //刷新
        }

        private void cmdDelOperator_Click(object sender, EventArgs e)
        {
            string args = string.Empty;
            foreach (GridViewRowInfo row in rgvOperatorList.Rows)
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
                        args += ",'"+row.Cells["colID"].Value.ToString()+"'";
                    }
                }
            }

            if (string.IsNullOrEmpty(args))
            {
                MessageHelper.ShowErrorMessage("请选择记录进行删除！");
            }
            else
            {
                string sql = string.Format("delete from t_operator where id in ({0})", args);
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

        private void cmdEditOperator_Click(object sender, EventArgs e)
        {
            int Count = 0;
            string ID = string.Empty;
            foreach (GridViewRowInfo row in rgvOperatorList.Rows)
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
                AddOperator frmEdit = new AddOperator(ID);
                if (frmEdit.ShowDialog() == DialogResult.OK)
                {
                    InitData();//刷新
                }
            }
            else if (Count > 1)
            {
                MessageHelper.ShowErrorMessage("请最多选择一条记录进行编辑！");
            }
            MessageBox.Show(Count.ToString());
        }

        private void cmdAddOperator_Click(object sender, EventArgs e)
        {
            AddOperator frmAddOperator = new AddOperator();
            if (frmAddOperator.ShowDialog() == DialogResult.OK)
            {
                //刷新
                InitData();
            }
        }
        #endregion

        private void rgvOperatorList_CellClick(object sender, GridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0 && e.Column.Name == "colSelect")
            {
                if (rgvOperatorList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value!=null&&(bool)rgvOperatorList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value)
                {
                    rgvOperatorList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value= false;
                }
                else
                {
                    rgvOperatorList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = true;
                }
                //MessageBox.Show(e.Value.ToString());
            }
        }
    }
}
