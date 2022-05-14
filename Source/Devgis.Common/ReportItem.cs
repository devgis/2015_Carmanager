using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devgis.Common
{
    /// <summary>
    /// 报表实体
    /// </summary>
    public class ReportItem
    {
        /// <summary>
        /// 报表查询字符串 '{0}'代表开始时间 '{1}'代表结束时间
        /// </summary>
        public string QueryString
        {
            get;
            set;
        }
        /// <summary>
        /// 报表名称
        /// </summary>
        public string ReportName
        {
            get;
            set;
        }

        private bool enableTime = true;
        /// <summary>
        /// 是否使用时间
        /// </summary>
        public bool EnableTime
        {
            get
            {
                return enableTime;
            }

            set
            {
                enableTime = value;
            }
        }
    }
}
