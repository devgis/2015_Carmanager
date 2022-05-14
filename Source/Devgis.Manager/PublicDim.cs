using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Devgis.Manager
{
    public class PublicDim
    {
        /// <summary>
        /// 当前登陆用户权限
        /// </summary>
        public static int RoleID = 0; // 1 超级管理员、2 平台普通管理员，3 停车场管理员、4 停车场收费员

        /// <summary>
        /// 当前登陆用户
        /// </summary>
        public static string OperatorID = "1";

        /// <summary>
        /// 真是名称
        /// </summary>
        public static string RealName = string.Empty;

        /// <summary>
        /// 文件路径
        /// </summary>
        public static string ConfigFileName = System.IO.Path.Combine(Application.StartupPath, "Setting.Config");



        /// <summary>
        /// 角色字典
        /// </summary>
        public static Dictionary<int, string> DicRole
        {
            get;
            set;
        }

        

    }
}
