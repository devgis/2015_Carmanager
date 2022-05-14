namespace Devgis.Manager
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rtbUserName = new Telerik.WinControls.UI.RadTextBox();
            this.rbSave = new Telerik.WinControls.UI.RadButton();
            this.rbCancel = new Telerik.WinControls.UI.RadButton();
            this.rtbUserPassword = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(97, 106);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "用户名：";
            // 
            // rtbUserName
            // 
            this.rtbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbUserName.Location = new System.Drawing.Point(184, 106);
            this.rtbUserName.MaxLength = 20;
            this.rtbUserName.Name = "rtbUserName";
            this.rtbUserName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbUserName.Size = new System.Drawing.Size(286, 27);
            this.rtbUserName.TabIndex = 0;
            // 
            // rbSave
            // 
            this.rbSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSave.Location = new System.Drawing.Point(164, 267);
            this.rbSave.Name = "rbSave";
            this.rbSave.Size = new System.Drawing.Size(110, 33);
            this.rbSave.TabIndex = 2;
            this.rbSave.Text = "登陆(&L)";
            this.rbSave.Click += new System.EventHandler(this.rbSave_Click);
            // 
            // rbCancel
            // 
            this.rbCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbCancel.Location = new System.Drawing.Point(294, 267);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(110, 33);
            this.rbCancel.TabIndex = 3;
            this.rbCancel.Text = "取消(&C)";
            this.rbCancel.Click += new System.EventHandler(this.rbCancel_Click);
            // 
            // rtbUserPassword
            // 
            this.rtbUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbUserPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbUserPassword.Location = new System.Drawing.Point(184, 172);
            this.rtbUserPassword.MaxLength = 20;
            this.rtbUserPassword.Name = "rtbUserPassword";
            this.rtbUserPassword.PasswordChar = '*';
            this.rtbUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbUserPassword.Size = new System.Drawing.Size(286, 27);
            this.rtbUserPassword.TabIndex = 1;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(97, 172);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 25);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "密码：";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.rbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Devgis.Manager.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.rtbUserPassword);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.rbCancel);
            this.Controls.Add(this.rbSave);
            this.Controls.Add(this.rtbUserName);
            this.Controls.Add(this.radLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "平台总管理端-用户登录";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox rtbUserName;
        private Telerik.WinControls.UI.RadButton rbSave;
        private Telerik.WinControls.UI.RadButton rbCancel;
        private Telerik.WinControls.UI.RadTextBox rtbUserPassword;
        private Telerik.WinControls.UI.RadLabel radLabel2;

    }
}