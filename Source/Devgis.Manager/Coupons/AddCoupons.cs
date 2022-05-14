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
using MySql.Data.MySqlClient;
using System.IO;

namespace Devgis.Manager.Coupons
{
    public partial class AddCoupons : BaseWindow
    {
        string EditID = string.Empty;
        /// <summary>
        /// 新增构造函数
        /// </summary>
        public AddCoupons()
        {
            InitializeComponent();
        }
        #region 私有方法

        /// <summary>
        /// 校验
        /// </summary>
        /// <returns></returns>
        private bool Check()
        {
            if (string.IsNullOrEmpty(rtbTotalAmount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("消费金额为空，如不限制消费金额请输入0！");
                rtbTotalAmount.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                try
                {
                    if (Convert.ToInt32(rtbTotalAmount.Text) < 0)
                    {
                        MessageHelper.ShowErrorMessage("消费金额必须大于等于0！");
                        rtbTotalAmount.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowErrorMessage("消费金额必须为大于或者等于0的整数，如不限制消费金额请输入0！");
                    rtbTotalAmount.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbAmount.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("优惠金额为空，如不限制消费金额请输入0！");
                rtbAmount.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                try
                {
                    if (Convert.ToInt32(rtbAmount.Text) <= 0)
                    {
                        MessageHelper.ShowErrorMessage("优惠金额必须大于0！");
                        rtbAmount.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowErrorMessage("优惠金额必须为大于0的整数！");
                    rtbAmount.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rtbNumber.Text.Trim()))
            {
                MessageHelper.ShowErrorMessage("数量不能为空，如不限制消费金额请输入0！");
                rtbNumber.Focus();
                return false;
            }
            else
            {
                //验证登陆名不存在
                try
                {
                    if (Convert.ToInt32(rtbNumber.Text) <= 0)
                    {
                        MessageHelper.ShowErrorMessage("数量必须大于0的整数！");
                        rtbNumber.Focus();
                        return false;
                    }
                }
                catch
                {
                    MessageHelper.ShowErrorMessage("数量不正确，优惠金额必须大于0的整数！");
                    rtbNumber.Focus();
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <returns></returns>
        private bool Save(string SavePicPath)
        {
            List<string> listSQLs = new List<string>();
            List<MySqlParameter[]> listMySqlParameters = new List<MySqlParameter[]>();
            List<string> listCoupons = new List<string>();
            for (int i = 0; i < Convert.ToInt32(rtbNumber.Text); i++)
            {
                MySqlParameter[] arrParameter = new MySqlParameter[3];
                string CouponID = PublicClass.GenerateCoupons(20);
                string sql = "insert into t_coupons (id,totalamount,amount,createtime,state)values(@id,@totalamount,@amount,now(),0)";
                arrParameter[0] = new MySqlParameter("@id", CouponID); //PublicClass Guid.NewGuid().ToString()
                arrParameter[1] = new MySqlParameter("@totalamount",Convert.ToInt32(rtbTotalAmount.Text));
                arrParameter[2] = new MySqlParameter("@amount", Convert.ToInt32(rtbAmount.Text));
                listSQLs.Add(sql);
                listCoupons.Add(CouponID);
                listMySqlParameters.Add(arrParameter);
            }
            try
            {
                if (System.IO.Directory.Exists(SavePicPath))
                {
                    PublicClass.DeleteFolder(SavePicPath);
                    //生成图片 
                    foreach (string coupon in listCoupons)
                    {
                        //生成图片  
                        Bitmap image = PublicClass.CreateImgCode(coupon);
                        //保存图片  
                        SaveImg(SavePicPath, image);
                    }

                    MySQLHelper.ExecuteTrans(listSQLs, listMySqlParameters);
                    return true;
                }
                else
                {
                    MessageHelper.ShowErrorMessage("文件夹不存在！");
                    return false;
                }
                
            }
            catch
            {
                return false;
            }
        }

        /// <summary>  
        /// 保存图片  
        /// </summary>  
        /// <param name="strPath">保存路径</param>  
        /// <param name="img">图片</param>  
        public void SaveImg(string strPath, Bitmap img)
        {
            //保存图片到目录  
            if (Directory.Exists(strPath))
            {
                //文件名称  
                string guid = Guid.NewGuid().ToString().Replace("-", "") + ".png";
                img.Save(strPath + "/" + guid, System.Drawing.Imaging.ImageFormat.Png);
            }
            else
            {
                //当前目录不存在，则创建  
                Directory.CreateDirectory(strPath);
            }
        }  
        #endregion

        private void rbSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                try
                {
                    FolderBrowserDialog fbd = new FolderBrowserDialog();
                    if (fbd.ShowDialog() == DialogResult.OK)
                    {
                        if (Save(fbd.SelectedPath))
                        {
                            MessageHelper.ShowInfoMessage("生成成功！");
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageHelper.ShowErrorMessage("生成失败！");
                        }
                        
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageHelper.ShowErrorMessage("Err:"+ex.Message);
                }
            }
        }
    }
}
