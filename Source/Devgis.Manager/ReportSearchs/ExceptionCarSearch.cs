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
    public partial class ExceptionCarSearch : BaseWindow
    {
        public ExceptionCarSearch()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化数据
        /// </summary>
        private void InitData()
        {
            rgvDataList.Rows.Clear();
            if (!rcb48Hour.Checked && !rcbMuilte.Checked)
            {
                MessageHelper.ShowErrorMessage("请至少选择一种");
            }
            else
            {
                string sql = string.Empty;
                if (rcb48Hour.Checked && rcbMuilte.Checked)
                {
                    sql="select carno,'只进未出' as ExceptionType,entertime from t_parkingcar where UNIX_TIMESTAMP(now())-UNIX_TIMESTAMP(entertime)>=172800 union select carno,'多停车场' as ExceptionType,entertime from t_parkingcar where carno in (select carno from (select carno,count(parkingid) as parkcount from t_parkingcar group by carno) t where t.parkcount>1)";
                }
                else if (rcb48Hour.Checked)
                {
                    sql = "select carno,'只进未出' as ExceptionType,entertime from t_parkingcar where UNIX_TIMESTAMP(now())-UNIX_TIMESTAMP(entertime)>=172800";
                }
                else if (rcbMuilte.Checked)
                {
                    sql = "select carno,'多停车场' as ExceptionType,entertime from t_parkingcar where carno in (select carno from (select carno,count(parkingid) as parkcount from t_parkingcar group by carno) t where t.parkcount>1)";
                }
                DataTable dt = MySQLHelper.ExecuteQuery(sql).Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    GridViewRowInfo row = rgvDataList.Rows.AddNew();
                    row.Cells["colCarNO"].Value = dr["carno"];
                    row.Cells["colExceptionType"].Value = dr["exceptiontype"];
                    row.Cells["colEnterTime"].Value = dr["entertime"];
                }

            }
            //rgvOperatorList.Rows.Clear();
            //string sql = "select t.id,o.realname,dutytype,dutytime from t_dutylog t left join t_operator o on t.operatorid=o.id";
            //string where = string.Format(" where t.dutytime between '{0}' and '{1}'", dtStart.ToString(), dtEnd.ToString());
            //if (!"*".Equals(OPID))
            //{
            //    where += string.Format(" and t.operatorid='{0}'", OPID);
            //}
            
            //DataTable dt = MySQLHelper.ExecuteQuery(sql+where).Tables[0];
            //foreach (DataRow dr in dt.Rows)
            //{
            //    GridViewRowInfo row = rgvOperatorList.Rows.AddNew();
            //    row.Cells["colID"].Value = dr["id"];
            //    row.Cells["colDutyTime"].Value = dr["dutytime"];
            //    row.Cells["colRealName"].Value = dr["realname"];
            //    row.Cells["colType"].Value = dr["dutytype"];
            //}
        }

        private void rbFilter_Click(object sender, EventArgs e)
        {
            InitData();
        }
    }
}
