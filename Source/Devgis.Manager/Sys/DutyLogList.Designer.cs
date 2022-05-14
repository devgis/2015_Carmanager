namespace Devgis.Manager.Sys
{
    partial class DutyLogList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgvOperatorList = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdRefresh = new Telerik.WinControls.UI.CommandBarButton();
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.rlistOperator = new Telerik.WinControls.UI.RadDropDownList();
            this.rbFilter = new Telerik.WinControls.UI.RadButton();
            this.rdpEndTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rdpStartTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            this.radCommandBar1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlistOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvOperatorList
            // 
            this.rgvOperatorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvOperatorList.Location = new System.Drawing.Point(0, 30);
            // 
            // rgvOperatorList
            // 
            this.rgvOperatorList.MasterTemplate.AllowAddNewRow = false;
            this.rgvOperatorList.MasterTemplate.AllowCellContextMenu = false;
            this.rgvOperatorList.MasterTemplate.AllowDeleteRow = false;
            this.rgvOperatorList.MasterTemplate.AllowDragToGroup = false;
            this.rgvOperatorList.MasterTemplate.AllowEditRow = false;
            this.rgvOperatorList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.HeaderText = "id";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "colID";
            gridViewTextBoxColumn6.HeaderText = "操作员";
            gridViewTextBoxColumn6.MaxWidth = 500;
            gridViewTextBoxColumn6.Name = "colRealName";
            gridViewTextBoxColumn6.Width = 258;
            gridViewTextBoxColumn7.HeaderText = "操作时间";
            gridViewTextBoxColumn7.MaxWidth = 500;
            gridViewTextBoxColumn7.Name = "colDutyTime";
            gridViewTextBoxColumn7.Width = 416;
            gridViewTextBoxColumn8.HeaderText = "类型";
            gridViewTextBoxColumn8.MaxWidth = 200;
            gridViewTextBoxColumn8.Name = "colType";
            gridViewTextBoxColumn8.Width = 100;
            this.rgvOperatorList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.rgvOperatorList.MasterTemplate.EnableGrouping = false;
            this.rgvOperatorList.Name = "rgvOperatorList";
            this.rgvOperatorList.ReadOnly = true;
            this.rgvOperatorList.Size = new System.Drawing.Size(792, 540);
            this.rgvOperatorList.TabIndex = 3;
            this.rgvOperatorList.Text = "radGridView1";
            this.rgvOperatorList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvOperatorList_CellClick);
            // 
            // commandBarRowElement1
            // 
            this.commandBarRowElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarRowElement1.MinSize = new System.Drawing.Size(25, 25);
            this.commandBarRowElement1.Strips.AddRange(new Telerik.WinControls.UI.CommandBarStripElement[] {
            this.commandBarStripElement1});
            this.commandBarRowElement1.Text = "";
            this.commandBarRowElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // commandBarStripElement1
            // 
            this.commandBarStripElement1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarStripElement1.DisplayName = "commandBarStripElement1";
            this.commandBarStripElement1.EnableDragging = false;
            this.commandBarStripElement1.Items.AddRange(new Telerik.WinControls.UI.RadCommandBarBaseItem[] {
            this.cmdRefresh});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.AccessibleDescription = "刷新";
            this.cmdRefresh.AccessibleName = "刷新";
            this.cmdRefresh.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdRefresh.DisplayName = "commandBarButton1";
            this.cmdRefresh.DrawText = true;
            this.cmdRefresh.Image = global::Devgis.Manager.Properties.Resources.refresh;
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Text = "刷新";
            this.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRefresh.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Controls.Add(this.rlistOperator);
            this.radCommandBar1.Controls.Add(this.rbFilter);
            this.radCommandBar1.Controls.Add(this.rdpEndTime);
            this.radCommandBar1.Controls.Add(this.radLabel3);
            this.radCommandBar1.Controls.Add(this.rdpStartTime);
            this.radCommandBar1.Controls.Add(this.radLabel2);
            this.radCommandBar1.Controls.Add(this.radLabel1);
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(792, 30);
            this.radCommandBar1.TabIndex = 2;
            this.radCommandBar1.Text = "添加";
            // 
            // rlistOperator
            // 
            this.rlistOperator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rlistOperator.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlistOperator.Location = new System.Drawing.Point(185, 2);
            this.rlistOperator.Name = "rlistOperator";
            this.rlistOperator.Size = new System.Drawing.Size(112, 24);
            this.rlistOperator.TabIndex = 3;
            // 
            // rbFilter
            // 
            this.rbFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rbFilter.Location = new System.Drawing.Point(721, 1);
            this.rbFilter.Name = "rbFilter";
            this.rbFilter.Size = new System.Drawing.Size(71, 26);
            this.rbFilter.TabIndex = 9;
            this.rbFilter.Text = "筛选(&F)";
            this.rbFilter.Click += new System.EventHandler(this.rbFilter_Click);
            // 
            // rdpEndTime
            // 
            this.rdpEndTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpEndTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpEndTime.Location = new System.Drawing.Point(577, 2);
            this.rdpEndTime.Name = "rdpEndTime";
            this.rdpEndTime.Size = new System.Drawing.Size(134, 24);
            this.rdpEndTime.TabIndex = 7;
            this.rdpEndTime.TabStop = false;
            this.rdpEndTime.Text = "2015-10-05 15:00:38";
            this.rdpEndTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 38, 265);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel3.Location = new System.Drawing.Point(502, 2);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 22);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "结束时间：";
            // 
            // rdpStartTime
            // 
            this.rdpStartTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpStartTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpStartTime.Location = new System.Drawing.Point(368, 2);
            this.rdpStartTime.Name = "rdpStartTime";
            this.rdpStartTime.Size = new System.Drawing.Size(135, 24);
            this.rdpStartTime.TabIndex = 5;
            this.rdpStartTime.TabStop = false;
            this.rdpStartTime.Text = "2015-10-05 15:00:01";
            this.rdpStartTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 1, 515);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(294, 3);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(79, 22);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "开始时间：";
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(126, 3);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(65, 22);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "操作员：";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // DutyLogList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rgvOperatorList);
            this.Controls.Add(this.radCommandBar1);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DutyLogList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "交接班日志列表";
            this.Load += new System.EventHandler(this.LogList_Load);
            this.Shown += new System.EventHandler(this.OperatorList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            this.radCommandBar1.ResumeLayout(false);
            this.radCommandBar1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlistOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvOperatorList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cmdRefresh;
        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.RadDateTimePicker rdpEndTime;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker rdpStartTime;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDropDownList rlistOperator;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.RadButton rbFilter;
    }
}