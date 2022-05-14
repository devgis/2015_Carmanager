using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Devgis.Client
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

            //Application.Run(new MainForm());
            
            LoginForm frmLoginForm = new LoginForm();
            if (frmLoginForm.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainForm());
            }
        }
    }
}
