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

namespace Devgis.Controls
{
    public partial class ReportView : BaseWindow
    {
        ReportItem reportItem = null;
        /// <summary>
        /// 报表对象
        /// </summary>
        public ReportItem Item
        {
            get
            {
                return reportItem;
            }
            set
            {
                if (value != null && reportItem != value)
                {
                    reportItem = value;
                    this.Text = reportItem.ReportName;
                    rdpStartTime.Visible = reportItem.EnableTime;
                    rdpEndTime.Visible = reportItem.EnableTime;
                    radLabel2.Visible = reportItem.EnableTime;
                    radLabel3.Visible = reportItem.EnableTime; 
                }
            }
        }

        //string OPID = "*";
        DateTime dtStart;
        DateTime dtEnd;
        public ReportView()
        {
            InitializeComponent();
            dtEnd = DateTime.Now;
            dtStart = dtEnd.AddMonths(-1);
            
            rdpStartTime.Value = dtStart;
            rdpEndTime.Value = dtEnd;
        }

        #region 私有方法
        private bool Check()
        {
            if (reportItem == null || string.IsNullOrEmpty(reportItem.QueryString))
            {
                MessageHelper.ShowErrorMessage("初始化异常！");
                return false;
            }
            if (rdpEndTime.Value <= rdpStartTime.Value)
            {
                MessageHelper.ShowErrorMessage("开始时间应该小于结束时间！");
                return false;
            }
            return true;
        }
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            //rgvReportDataList.Rows.Clear();
            //rgvReportDataList.Columns.Clear();
            string sql = string.Empty;
            if (Item.EnableTime)
            {
                sql = string.Format(Item.QueryString, rdpStartTime.Value, rdpEndTime.Value);
            }
            else
            {
                sql = Item.QueryString;
            }
            try
            {
                DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
                this.rgvReportDataList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageHelper.ShowErrorMessage("查询报表发生错误:" + ex.Message);
            }
        }
        #endregion

        #region endregion

        /// <summary>
        /// 显示报表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            InitData();
        }

        /// <summary>
        /// 导出报表到Excel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdExport_Click(object sender, EventArgs e)
        {
            PublicClass.ExportExcel("report.xls", this.rgvReportDataList);
        }
        #endregion 界面事件方法
    }
}
