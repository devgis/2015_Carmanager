using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using System.IO;
using System.Drawing;
using ThoughtWorks.QRCode.Codec;

namespace Devgis.Common
{
    /// <summary>
    /// 公共方法
    /// </summary>
    public class PublicClass
    {
        private static Random random = new Random();
        /// <summary>
        /// 生成数字码
        /// </summary>
        /// <param name="Length"></param>
        /// <returns></returns>
        public static string GenerateCoupons(int Length=20)
        {
            string stemp = string.Empty;
            for (int i = 0; i < Length; i++)
            {
                stemp += random.Next(0, 9);
            }
            return stemp;
        }

        /// <summary>
        /// 写日志
        /// </summary>
        /// <param name="OperatorId">操作员ID</param>
        /// <param name="Content">操作内容</param>
        public static bool WriteLog(string OperatorId, string Content)
        {
            MySqlParameter[] arrParameter = new MySqlParameter[2];
            string sql = "insert into t_log (logtime,operatorid,content)values(now(),@operatorid,@content)";
            arrParameter[0]=new MySqlParameter("@operatorid",OperatorId);
            arrParameter[1] = new MySqlParameter("@content",Content);
            try
            {
                if (MySQLHelper.ExecuteNonQuery(sql, arrParameter) > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 导出RadGridView到Excel
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="myDGV"></param>
        public static void ExportExcel(string fileName, RadGridView myDGV)
        {
            string saveFileName = "";
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.DefaultExt = "xls";
            saveDialog.Filter = "Excel文件|*.xls";
            saveDialog.FileName = fileName;
            saveDialog.ShowDialog();
            saveFileName = saveDialog.FileName;
            if (saveFileName.IndexOf(":") < 0) return; //被点了取消
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            if (xlApp == null)
            {
                MessageBox.Show("无法创建Excel对象，可能您的机子未安装Excel");
                return;
            }
            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;
            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1
            List<string> listVisableColName = new List<string>();
            //处理隐藏列问题
            for (int i = 0; i < myDGV.ColumnCount; i++)
            {
                if (myDGV.Columns[i].IsVisible && !"colSelect".Equals(myDGV.Columns[i].Name))
                {
                    listVisableColName.Add(myDGV.Columns[i].Name);
                }
            }

            for (int i = 0; i < listVisableColName.Count; i++)
            {
                worksheet.Cells[1, i + 1] = myDGV.Columns[listVisableColName[i]].HeaderText;
            }


            for (int r = 0; r < myDGV.Rows.Count; r++)
            {
                for (int i = 0; i < listVisableColName.Count; i++)
                {
                    worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[listVisableColName[i]].Value;
                }
                //for (int i = 0; i < myDGV.ColumnCount; i++)
                //{
                //    worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
                //}
                System.Windows.Forms.Application.DoEvents();
            }

            ////写入标题
            //for (int i = 0; i < myDGV.ColumnCount; i++)
            //{
            //    worksheet.Cells[1, i + 1] = myDGV.Columns[i].HeaderText;
            //}
            ////写入数值
            //for (int r = 0; r < myDGV.Rows.Count; r++)
            //{
            //    for (int i = 0; i < myDGV.ColumnCount; i++)
            //    {
            //        worksheet.Cells[r + 2, i + 1] = myDGV.Rows[r].Cells[i].Value;
            //    }
            //    System.Windows.Forms.Application.DoEvents();
            //}
            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            if (saveFileName != "")
            {
                try
                {
                    workbook.Saved = true;
                    workbook.SaveCopyAs(saveFileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);
                }
            }
            xlApp.Quit();
            GC.Collect();//强行销毁
            MessageHelper.ShowInfoMessage("文件： " + fileName + ".xls 保存成功");
            //MessageBox.Show("文件： " + fileName + ".xls 保存成功", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 清空指定的文件夹，但不删除文件夹
        /// </summary>
        /// <param name="dir"></param>
        public static void DeleteFolder(string dir)
        {
            foreach (string d in Directory.GetFileSystemEntries(dir))
            {
                if (File.Exists(d))
                {
                    FileInfo fi = new FileInfo(d);
                    if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                        fi.Attributes = FileAttributes.Normal;
                    File.Delete(d);//直接删除其中的文件  
                }
                else
                {
                    DirectoryInfo d1 = new DirectoryInfo(d);
                    if (d1.GetFiles().Length != 0)
                    {
                        DeleteFolder(d1.FullName);////递归删除子文件夹
                    }
                    Directory.Delete(d);
                }
            }
        }
        static QRCodeEncoder qrCodeEncoder = null;
        /// <summary>  
        /// 生成二维码图片  
        /// </summary>  
        /// <param name="codeNumber">要生成二维码的字符串</param>       
        /// <param name="size">大小尺寸</param>  
        /// <returns>二维码图片</returns>  
        public static Bitmap CreateImgCode(string codeNumber, int size=16)
        {
            //创建二维码生成类  
            if (qrCodeEncoder == null)
            {
                qrCodeEncoder = new QRCodeEncoder();
            }
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = size;
            qrCodeEncoder.QRCodeVersion = 8;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;

            //QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            ////设置编码模式  
            //qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            ////设置编码测量度  
            //qrCodeEncoder.QRCodeScale = size;
            ////设置编码版本  
            //qrCodeEncoder.QRCodeVersion = 0;
            ////设置编码错误纠正  
            //qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //生成二维码图片  
            System.Drawing.Bitmap image = qrCodeEncoder.Encode(codeNumber);
            return image;
        } 
    }
}
