namespace Devgis.Controls
{
    partial class ReportView
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
            this.rgvReportDataList = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdRefresh = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdExport = new Telerik.WinControls.UI.CommandBarButton();
            this.radReport = new Telerik.WinControls.UI.RadCommandBar();
            this.rdpEndTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.rdpStartTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            ((System.ComponentModel.ISupportInitialize)(rgvReportDataList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radReport)).BeginInit();
            this.radReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            rgvReportDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            rgvReportDataList.Location = new System.Drawing.Point(0, 55);
            // 
            // rgvReportDataList
            // 
            rgvReportDataList.MasterTemplate.AllowAddNewRow = false;
            rgvReportDataList.MasterTemplate.AllowCellContextMenu = false;
            rgvReportDataList.MasterTemplate.AllowDeleteRow = false;
            rgvReportDataList.MasterTemplate.AllowDragToGroup = false;
            rgvReportDataList.MasterTemplate.AllowEditRow = false;
            rgvReportDataList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            rgvReportDataList.MasterTemplate.EnableGrouping = false;
            rgvReportDataList.Name = "rgvReportDataList";
            rgvReportDataList.ReadOnly = true;
            rgvReportDataList.Size = new System.Drawing.Size(792, 515);
            rgvReportDataList.TabIndex = 3;
            rgvReportDataList.Text = "radGridView1";
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
            this.cmdRefresh,
            this.cmdExport});
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
            this.cmdRefresh.Enabled = true;
            this.cmdRefresh.Image = global::Devgis.Controls.Properties.Resources.report;
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Text = "显示报表";
            this.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRefresh.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdExport
            // 
            this.cmdExport.AccessibleDescription = "导出";
            this.cmdExport.AccessibleName = "导出";
            this.cmdExport.DisplayName = "cmdExport";
            this.cmdExport.DrawText = true;
            this.cmdExport.Enabled = true;
            this.cmdExport.Image = global::Devgis.Controls.Properties.Resources.export;
            this.cmdExport.Name = "cmdExport";
            this.cmdExport.Text = "导出报表";
            this.cmdExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdExport.Click += new System.EventHandler(this.cmdExport_Click);
            // 
            // radReport
            // 
            this.radReport.Controls.Add(this.rdpEndTime);
            this.radReport.Controls.Add(this.radLabel3);
            this.radReport.Controls.Add(this.rdpStartTime);
            this.radReport.Controls.Add(this.radLabel2);
            this.radReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.radReport.Location = new System.Drawing.Point(0, 0);
            this.radReport.Name = "radReport";
            this.radReport.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radReport.Size = new System.Drawing.Size(792, 55);
            this.radReport.TabIndex = 2;
            this.radReport.Text = "添加";
            // 
            // rdpEndTime
            // 
            this.rdpEndTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpEndTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpEndTime.Location = new System.Drawing.Point(621, 14);
            this.rdpEndTime.Name = "rdpEndTime";
            this.rdpEndTime.Size = new System.Drawing.Size(170, 24);
            this.rdpEndTime.TabIndex = 7;
            this.rdpEndTime.TabStop = false;
            this.rdpEndTime.Text = "2015-10-05 15:00:38";
            this.rdpEndTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 38, 265);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel3.Location = new System.Drawing.Point(546, 14);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 22);
            this.radLabel3.TabIndex = 6;
            this.radLabel3.Text = "结束时间：";
            // 
            // rdpStartTime
            // 
            this.rdpStartTime.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rdpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpStartTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpStartTime.Location = new System.Drawing.Point(373, 14);
            this.rdpStartTime.Name = "rdpStartTime";
            this.rdpStartTime.Size = new System.Drawing.Size(170, 24);
            this.rdpStartTime.TabIndex = 5;
            this.rdpStartTime.TabStop = false;
            this.rdpStartTime.Text = "2015-10-05 15:00:01";
            this.rdpStartTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 1, 515);
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(299, 15);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(79, 22);
            this.radLabel2.TabIndex = 4;
            this.radLabel2.Text = "开始时间：";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(rgvReportDataList);
            this.Controls.Add(this.radReport);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ReportView";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "报表";
            ((System.ComponentModel.ISupportInitialize)(rgvReportDataList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radReport)).EndInit();
            this.radReport.ResumeLayout(false);
            this.radReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvReportDataList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cmdRefresh;
        private Telerik.WinControls.UI.RadCommandBar radReport;
        private Telerik.WinControls.UI.RadDateTimePicker rdpEndTime;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker rdpStartTime;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.CommandBarButton cmdExport;
    }
}