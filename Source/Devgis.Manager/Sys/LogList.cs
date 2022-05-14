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
    public partial class LogList : BaseWindow
    {
        string OPID = "*";
        DateTime dtStart;
        DateTime dtEnd;
        public LogList()
        {
            InitializeComponent();
            dtStart = DateTime.Now.AddDays(-1);
            dtEnd = dtStart.AddDays(1);
            rdpStartTime.Value = dtStart;
            rdpEndTime.Value = dtEnd;
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
            string sql = "select l.id,l.logtime,l.content,o.realname from t_log l INNER JOIN t_operator o on l.operatorid=o.id";
            string where = string.Format(" where l.logtime between '{0}' and '{1}'", dtStart.ToString(), dtEnd.ToString());
            if (!"*".Equals(OPID))
            {
                where += string.Format(" and l.operatorid='{0}'", OPID);
            }
            
            DataTable dt = MySQLHelper.ExecuteQuery(sql+where).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvOperatorList.Rows.AddNew();
                row.Cells["colID"].Value = dr["id"];
                row.Cells["colLogTime"].Value = dr["logtime"];
                row.Cells["colRealName"].Value = dr["realname"];
                row.Cells["colContent"].Value = dr["content"];
            }
        }
        #endregion

        #region 界面事件方法
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InitData(); //刷新
        }

        private void cmdDel_Click(object sender, EventArgs e)
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
                string sql = string.Format("delete from t_log where id in ({0})", args);
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
        #endregion

        private void LogList_Load(object sender, EventArgs e)
        {
            DataTable dttemp = MySQLHelper.ExecuteQuery("select id,realname from t_operator where isdeleted is null or isdeleted<>1").Tables[0];
            DataRow dr= dttemp.NewRow();
            dr["id"] = "*";
            dr["realname"] = "所有";
            dttemp.Rows.InsertAt(dr,0);
            rlistOperator.ValueMember = "id";
            rlistOperator.DisplayMember = "realname";
            rlistOperator.DataSource = dttemp;
        }

        private void rbFilter_Click(object sender, EventArgs e)
        {
            OPID = rlistOperator.SelectedValue.ToString();
            dtStart = rdpStartTime.Value;
            dtEnd = rdpEndTime.Value;
            InitData();
        }
    }
}
