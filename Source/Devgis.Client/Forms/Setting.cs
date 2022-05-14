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
using System.IO;

namespace Devgis.Client.Forms
{
    public partial class Setting : BaseWindow
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void rbSave_Click(object sender, EventArgs e)
        {
            if (Check())
            {
                if (Save())
                {
                    MessageHelper.ShowInfoMessage("保存成功！");
                }
                else
                {
                    MessageHelper.ShowErrorMessage("保存失败！");
                }
            }
        }

        private void rbCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        string musicType = ".mp3";
        private bool Check()
        {
            if (string.IsNullOrEmpty(rbSounds1.Text))
            {
                MessageHelper.ShowErrorMessage("欢迎音乐路径不能为空！");
                rbSounds1.Focus();
                return false;
            }
            else
            {
                if (!File.Exists(rbSounds1.Text))
                {
                    MessageHelper.ShowErrorMessage("欢迎音乐不存在！");
                    rbSounds1.Focus();
                    return false;
                }
                else if(!rbSounds1.Text.EndsWith(musicType))
                {
                    MessageHelper.ShowErrorMessage("欢迎音乐只支持mp3格式！");
                    rbSounds1.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rbSounds2.Text))
            {
                MessageHelper.ShowErrorMessage("已交费音乐路径不能为空！");
                rbSounds2.Focus();
                return false;
            }
            else
            {
                if (!File.Exists(rbSounds2.Text))
                {
                    MessageHelper.ShowErrorMessage("已交费音乐不存在！");
                    rbSounds2.Focus();
                    return false;
                }
                else if (!rbSounds2.Text.EndsWith(musicType))
                {
                    MessageHelper.ShowErrorMessage("已交费音乐只支持mp3格式！");
                    rbSounds2.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rbSounds3.Text))
            {
                MessageHelper.ShowErrorMessage("黑名单音乐路径不能为空！");
                rbSounds3.Focus();
                return false;
            }
            else
            {
                if (!File.Exists(rbSounds3.Text))
                {
                    MessageHelper.ShowErrorMessage("黑名单音乐不存在！");
                    rbSounds3.Focus();
                    return false;
                }
                else if (!rbSounds3.Text.EndsWith(musicType))
                {
                    MessageHelper.ShowErrorMessage("黑名单音乐只支持mp3格式！");
                    rbSounds3.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(rbSounds4.Text))
            {
                MessageHelper.ShowErrorMessage("未识别音乐路径不能为空！");
                rbSounds4.Focus();
                return false;
            }
            else
            {
                if (!File.Exists(rbSounds4.Text))
                {
                    MessageHelper.ShowErrorMessage("未识别音乐不存在！");
                    rbSounds4.Focus();
                    return false;
                }
                else if (!rbSounds4.Text.EndsWith(musicType))
                {
                    MessageHelper.ShowErrorMessage("未识别音乐只支持mp3格式！");
                    rbSounds4.Focus();
                    return false;
                }
            }
            return true;
        }

        private bool Save()
        {
            ConfigClass configClass = new ConfigClass();
            configClass.Music1Path = rbSounds1.Text;
            configClass.Music2Path = rbSounds2.Text;
            configClass.Music3Path = rbSounds3.Text;
            configClass.Music4Path = rbSounds4.Text;
            try
            {
                SerializeHelper.Serialize<ConfigClass>(configClass, PublicDim.ConfigFileName);
                PublicDim.configInfo = configClass;
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            rbSounds1.Text = PublicDim.configInfo.Music1Path;
            rbSounds2.Text = PublicDim.configInfo.Music2Path;
            rbSounds3.Text = PublicDim.configInfo.Music3Path;
            rbSounds4.Text = PublicDim.configInfo.Music4Path;
        }
    }
}
