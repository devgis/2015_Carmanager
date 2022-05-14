namespace Devgis.Client
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
            this.rlistSentryBox = new Telerik.WinControls.UI.RadDropDownList();
            this.rlistParking = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistSentryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(101, 181);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(74, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "用户名：";
            // 
            // rtbUserName
            // 
            this.rtbUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbUserName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbUserName.Location = new System.Drawing.Point(193, 180);
            this.rtbUserName.MaxLength = 20;
            this.rtbUserName.Name = "rtbUserName";
            this.rtbUserName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbUserName.Size = new System.Drawing.Size(286, 27);
            this.rtbUserName.TabIndex = 2;
            // 
            // rbSave
            // 
            this.rbSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSave.Location = new System.Drawing.Point(163, 289);
            this.rbSave.Name = "rbSave";
            this.rbSave.Size = new System.Drawing.Size(110, 33);
            this.rbSave.TabIndex = 4;
            this.rbSave.Text = "登陆(&L)";
            this.rbSave.Click += new System.EventHandler(this.rbSave_Click);
            // 
            // rbCancel
            // 
            this.rbCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbCancel.Location = new System.Drawing.Point(293, 289);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(110, 33);
            this.rbCancel.TabIndex = 5;
            this.rbCancel.Text = "取消(&C)";
            this.rbCancel.Click += new System.EventHandler(this.rbCancel_Click);
            // 
            // rtbUserPassword
            // 
            this.rtbUserPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbUserPassword.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbUserPassword.Location = new System.Drawing.Point(193, 221);
            this.rtbUserPassword.MaxLength = 20;
            this.rtbUserPassword.Name = "rtbUserPassword";
            this.rtbUserPassword.PasswordChar = '*';
            this.rtbUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbUserPassword.Size = new System.Drawing.Size(286, 27);
            this.rtbUserPassword.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(101, 223);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(57, 25);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "密码：";
            // 
            // rlistSentryBox
            // 
            this.rlistSentryBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rlistSentryBox.AutoSize = false;
            this.rlistSentryBox.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rlistSentryBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlistSentryBox.Location = new System.Drawing.Point(193, 137);
            this.rlistSentryBox.Name = "rlistSentryBox";
            this.rlistSentryBox.Size = new System.Drawing.Size(286, 31);
            this.rlistSentryBox.TabIndex = 1;
            // 
            // rlistParking
            // 
            this.rlistParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rlistParking.AutoSize = false;
            this.rlistParking.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rlistParking.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlistParking.Location = new System.Drawing.Point(193, 95);
            this.rlistParking.Name = "rlistParking";
            this.rlistParking.Size = new System.Drawing.Size(286, 31);
            this.rlistParking.TabIndex = 0;
            this.rlistParking.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rlistParking_SelectedIndexChanged);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel3.Location = new System.Drawing.Point(101, 96);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(74, 25);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "停车场：";
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel4.Location = new System.Drawing.Point(101, 137);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(57, 25);
            this.radLabel4.TabIndex = 21;
            this.radLabel4.Text = "岗亭：";
            // 
            // LoginForm
            // 
            this.AcceptButton = this.rbSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Devgis.Client.Properties.Resources.backgroud;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.rlistSentryBox);
            this.Controls.Add(this.rlistParking);
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
            this.Text = "岗亭端-用户登录";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbUserPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistSentryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
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
        private Telerik.WinControls.UI.RadDropDownList rlistSentryBox;
        private Telerik.WinControls.UI.RadDropDownList rlistParking;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;

    }
}