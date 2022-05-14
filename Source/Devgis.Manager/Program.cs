using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Devgis.Manager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DateTime dtStart = new DateTime(2015, 10, 25);
            DateTime dtNown = DateTime.Now;
            TimeSpan tsTime = dtNown - dtStart;
            if (tsTime.Days > 90)
            {
                Devgis.Common.MessageHelper.ShowErrorMessage("产品已国期请联系开发开发人员！");
                return;
            }

            //初始化角色字典
            PublicDim.DicRole = new Dictionary<int, string>();
            PublicDim.DicRole.Add(1, "超级管理员");
            PublicDim.DicRole.Add(2, "平台普通管理员");
            PublicDim.DicRole.Add(3, "停车场管理员");
            PublicDim.DicRole.Add(4, "停车场收费员");

            LoginForm frmLoginForm = new LoginForm();
            if (frmLoginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
            
        }
    }
}
