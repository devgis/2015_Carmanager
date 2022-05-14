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

namespace Devgis.Manager.ReportSearchs
{
    public partial class ManulOpenSearch : BaseWindow
    {
        DateTime dtStart;
        DateTime dtEnd;
        public ManulOpenSearch()
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
            rgvOperatorList.Rows.Clear();
            string sql = "select p.`name` as parkingname,carno,case opentype when 1 then '出' else '进' end as opentypename,operatortime"
+" from t_openlog o left join t_parking p on o.parkingid=p.id"
+" left join t_operator t on o.operatorid=t.id"
+" where o.operatortime between '{0}' and '{1}'";
            sql = string.Format(sql, rdpStartTime.Value.ToString(), rdpEndTime.Value.ToString());
            if (!"*".Equals(rlistOperator.SelectedValue.ToString()))
            {
                sql += string.Format(" and o.operatorid='{0}'", rlistOperator.SelectedValue.ToString());
            }
            if (!string.IsNullOrEmpty(rbCarNO.Text))
            {
                sql += string.Format(" and o.carno='{0}'", rbCarNO.Text);
            }
            DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                GridViewRowInfo row = rgvOperatorList.Rows.AddNew();
                row.Cells["colParkingName"].Value = dr["parkingname"];
                row.Cells["colCarNO"].Value = dr["carno"];
                row.Cells["colEnOrOut"].Value = dr["opentypename"];
                row.Cells["colEnterTime"].Value = dr["operatortime"];
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

        private void rbQuery_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
