using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Devgis.Client
{
    public class ConfigClass
    {
        /// <summary>
        /// 欢迎
        /// </summary>
        public string Music1Path
        {
            get;
            set;
        }
        /// <summary>
        /// 已交费
        /// </summary>
        public string Music2Path
        {
            get;
            set;
        }
        /// <summary>
        /// 黑名单
        /// </summary>
        public string Music3Path
        {
            get;
            set;
        }
        /// <summary>
        /// 未识别
        /// </summary>
        public string Music4Path
        {
            get;
            set;
        }
    }
}
