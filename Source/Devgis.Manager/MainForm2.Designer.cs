namespace Devgis.Manager
{
    partial class MainForm2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.breezeTheme1 = new Telerik.WinControls.Themes.BreezeTheme();
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem3 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem4 = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem5 = new Telerik.WinControls.UI.RadMenuItem();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.commandBarButton6 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton7 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton8 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton9 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton10 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton11 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton3 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton4 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton5 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2,
            this.radMenuItem3,
            this.radMenuItem4,
            this.radMenuItem5});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(792, 20);
            this.radMenu1.TabIndex = 0;
            this.radMenu1.Text = "radMenu1";
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.AccessibleDescription = "系统(&S)";
            this.radMenuItem1.AccessibleName = "系统(&S)";
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "系统(&S)";
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.AccessibleDescription = "基础信息(&B)";
            this.radMenuItem2.AccessibleName = "基础信息(&B)";
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "基础信息(&B)";
            // 
            // radMenuItem3
            // 
            this.radMenuItem3.AccessibleDescription = "报表(&R)";
            this.radMenuItem3.AccessibleName = "报表(&R)";
            this.radMenuItem3.Name = "radMenuItem3";
            this.radMenuItem3.Text = "报表(&R)";
            // 
            // radMenuItem4
            // 
            this.radMenuItem4.AccessibleDescription = "权限管理(&A)";
            this.radMenuItem4.AccessibleName = "权限管理(&A)";
            this.radMenuItem4.Name = "radMenuItem4";
            this.radMenuItem4.Text = "权限管理(&A)";
            // 
            // radMenuItem5
            // 
            this.radMenuItem5.AccessibleDescription = "帮助(&H)";
            this.radMenuItem5.AccessibleName = "帮助(&H)";
            this.radMenuItem5.Name = "radMenuItem5";
            this.radMenuItem5.Text = "帮助(&H)";
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 20);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(792, 30);
            this.radCommandBar1.TabIndex = 1;
            this.radCommandBar1.Text = "注销";
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.commandBarButton6,
            this.commandBarButton7,
            this.commandBarButton8,
            this.commandBarButton9,
            this.commandBarButton10,
            this.commandBarButton1,
            this.commandBarButton11});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            // 
            // commandBarButton6
            // 
            this.commandBarButton6.AccessibleDescription = "注销";
            this.commandBarButton6.AccessibleName = "注销";
            this.commandBarButton6.DisplayName = "commandBarButton6";
            this.commandBarButton6.DrawText = true;
            this.commandBarButton6.Image = global::Devgis.Manager.Properties.Resources.loginout;
            this.commandBarButton6.Name = "commandBarButton6";
            this.commandBarButton6.Text = "注销";
            this.commandBarButton6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // commandBarButton7
            // 
            this.commandBarButton7.AccessibleDescription = "通道管理";
            this.commandBarButton7.AccessibleName = "通道管理";
            this.commandBarButton7.DisplayName = "commandBarButton7";
            this.commandBarButton7.DrawText = true;
            this.commandBarButton7.Image = global::Devgis.Manager.Properties.Resources.chanel;
            this.commandBarButton7.Name = "commandBarButton7";
            this.commandBarButton7.Text = "通道管理";
            this.commandBarButton7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // commandBarButton8
            // 
            this.commandBarButton8.AccessibleDescription = "车辆管理";
            this.commandBarButton8.AccessibleName = "车辆管理";
            this.commandBarButton8.DisplayName = "commandBarButton8";
            this.commandBarButton8.DrawText = true;
            this.commandBarButton8.Image = global::Devgis.Manager.Properties.Resources.car;
            this.commandBarButton8.Name = "commandBarButton8";
            this.commandBarButton8.Text = "车辆管理";
            this.commandBarButton8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // commandBarButton9
            // 
            this.commandBarButton9.AccessibleDescription = "车辆出入报表";
            this.commandBarButton9.AccessibleName = "车辆出入报表";
            this.commandBarButton9.DisplayName = "commandBarButton9";
            this.commandBarButton9.DrawText = true;
            this.commandBarButton9.Image = global::Devgis.Manager.Properties.Resources.churu;
            this.commandBarButton9.Name = "commandBarButton9";
            this.commandBarButton9.Text = "车辆出入报表";
            this.commandBarButton9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // commandBarButton10
            // 
            this.commandBarButton10.AccessibleDescription = "原始记录报表";
            this.commandBarButton10.AccessibleName = "原始记录报表";
            this.commandBarButton10.DisplayName = "commandBarButton10";
            this.commandBarButton10.DrawText = true;
            this.commandBarButton10.Image = global::Devgis.Manager.Properties.Resources.yuanshi;
            this.commandBarButton10.Name = "commandBarButton10";
            this.commandBarButton10.Text = "原始记录报表";
            this.commandBarButton10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // commandBarButton1
            // 
            this.commandBarButton1.AccessibleDescription = "注销";
            this.commandBarButton1.AccessibleName = "注销";
            this.commandBarButton1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.commandBarButton1.BorderDrawMode = Telerik.WinControls.BorderDrawModes.BottomOver;
            this.commandBarButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.DrawFill = false;
            this.commandBarButton1.DrawText = true;
            this.commandBarButton1.Image = global::Devgis.Manager.Properties.Resources.huizong;
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "收费汇总报表";
            this.commandBarButton1.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton1.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.commandBarButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.TextWrap = true;
            // 
            // commandBarButton11
            // 
            this.commandBarButton11.AccessibleDescription = "退出";
            this.commandBarButton11.AccessibleName = "退出";
            this.commandBarButton11.DisplayName = "commandBarButton11";
            this.commandBarButton11.DrawText = true;
            this.commandBarButton11.Image = global::Devgis.Manager.Properties.Resources.exit;
            this.commandBarButton11.Name = "commandBarButton11";
            this.commandBarButton11.Text = "退出";
            this.commandBarButton11.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.AccessibleDescription = "注销";
            this.commandBarButton2.AccessibleName = "注销";
            this.commandBarButton2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.commandBarButton2.BorderDrawMode = Telerik.WinControls.BorderDrawModes.BottomOver;
            this.commandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.DisplayName = "commandBarButton1";
            this.commandBarButton2.DrawFill = false;
            this.commandBarButton2.DrawText = true;
            this.commandBarButton2.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton2.Image")));
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "注销";
            this.commandBarButton2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton2.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.TextWrap = true;
            // 
            // commandBarButton3
            // 
            this.commandBarButton3.AccessibleDescription = "注销";
            this.commandBarButton3.AccessibleName = "注销";
            this.commandBarButton3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.commandBarButton3.BorderDrawMode = Telerik.WinControls.BorderDrawModes.BottomOver;
            this.commandBarButton3.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton3.DisplayName = "commandBarButton1";
            this.commandBarButton3.DrawFill = false;
            this.commandBarButton3.DrawText = true;
            this.commandBarButton3.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton3.Image")));
            this.commandBarButton3.Name = "commandBarButton3";
            this.commandBarButton3.Text = "注销";
            this.commandBarButton3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton3.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.commandBarButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton3.TextWrap = true;
            // 
            // commandBarButton4
            // 
            this.commandBarButton4.AccessibleDescription = "注销";
            this.commandBarButton4.AccessibleName = "注销";
            this.commandBarButton4.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.commandBarButton4.BorderDrawMode = Telerik.WinControls.BorderDrawModes.BottomOver;
            this.commandBarButton4.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton4.DisplayName = "commandBarButton1";
            this.commandBarButton4.DrawFill = false;
            this.commandBarButton4.DrawText = true;
            this.commandBarButton4.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton4.Image")));
            this.commandBarButton4.Name = "commandBarButton4";
            this.commandBarButton4.Text = "注销";
            this.commandBarButton4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton4.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.commandBarButton4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton4.TextWrap = true;
            // 
            // commandBarButton5
            // 
            this.commandBarButton5.AccessibleDescription = "注销";
            this.commandBarButton5.AccessibleName = "注销";
            this.commandBarButton5.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping;
            this.commandBarButton5.BorderDrawMode = Telerik.WinControls.BorderDrawModes.BottomOver;
            this.commandBarButton5.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton5.DisplayName = "commandBarButton1";
            this.commandBarButton5.DrawFill = false;
            this.commandBarButton5.DrawText = true;
            this.commandBarButton5.Image = ((System.Drawing.Image)(resources.GetObject("commandBarButton5.Image")));
            this.commandBarButton5.Name = "commandBarButton5";
            this.commandBarButton5.Text = "注销";
            this.commandBarButton5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.commandBarButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton5.TextOrientation = System.Windows.Forms.Orientation.Horizontal;
            this.commandBarButton5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton5.TextWrap = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.radCommandBar1);
            this.Controls.Add(this.radMenu1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "立体高清车牌识别停车场管理系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.Themes.BreezeTheme breezeTheme1;
        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem3;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem4;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem5;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton3;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton4;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton5;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton6;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton7;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton8;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton9;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton10;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton11;
    }
}

