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

namespace Devgis.Client.Forms
{
    public partial class CarList : BaseWindow
    {
        DateTime dtStart;
        DateTime dtEnd;
        public CarList()
        {
            InitializeComponent();
            dtStart = DateTime.Now.AddDays(-1);
            dtEnd = dtStart.AddDays(1);
            rdpStartTime.Value = dtStart;
            rdpEndTime.Value = dtEnd;
        }

        #region 私有方法
        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            rgvDataList.Rows.Clear();
            string sql = "select * from v_parkingcar where entertime between '{0}' and '{1}'";
            sql = string.Format(sql, rdpStartTime.Value.ToString(), rdpEndTime.Value.ToString());
            if (!String.IsNullOrEmpty(rbMobile.Text.Trim()))
            {
                sql += string.Format(" and mobile likes '%{0}%'", rbMobile.Text);
            }
            if (!string.IsNullOrEmpty(rbCarNO.Text))
            {
                sql += string.Format(" and carno likes '%{0}%'", rbCarNO.Text);
            }
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            rgvDataList.DataSource = dt;
        }
        #endregion

        private void LogList_Load(object sender, EventArgs e)
        {
        }

        private void rbQuery_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
