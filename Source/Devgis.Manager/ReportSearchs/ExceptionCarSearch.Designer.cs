namespace Devgis.Manager.ReportSearchs
{
    partial class ExceptionCarSearch
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgvDataList = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.rpTop = new Telerik.WinControls.UI.RadPanel();
            this.rcb48Hour = new Telerik.WinControls.UI.RadCheckBox();
            this.rcbMuilte = new Telerik.WinControls.UI.RadCheckBox();
            this.rbFilter = new Telerik.WinControls.UI.RadButton();
            this.rpBottom = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).BeginInit();
            this.rpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcb48Hour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbMuilte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpBottom)).BeginInit();
            this.rpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvDataList
            // 
            this.rgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvDataList.Location = new System.Drawing.Point(0, 0);
            // 
            // rgvDataList
            // 
            this.rgvDataList.MasterTemplate.AllowAddNewRow = false;
            this.rgvDataList.MasterTemplate.AllowCellContextMenu = false;
            this.rgvDataList.MasterTemplate.AllowDeleteRow = false;
            this.rgvDataList.MasterTemplate.AllowDragToGroup = false;
            this.rgvDataList.MasterTemplate.AllowEditRow = false;
            this.rgvDataList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "车牌号";
            gridViewTextBoxColumn1.Name = "colCarNO";
            gridViewTextBoxColumn1.Width = 274;
            gridViewTextBoxColumn2.HeaderText = "异常类型";
            gridViewTextBoxColumn2.MinWidth = 300;
            gridViewTextBoxColumn2.Name = "colExceptionType";
            gridViewTextBoxColumn2.Width = 300;
            gridViewTextBoxColumn3.HeaderText = "进场时间";
            gridViewTextBoxColumn3.MinWidth = 200;
            gridViewTextBoxColumn3.Name = "colEnterTime";
            gridViewTextBoxColumn3.Width = 200;
            this.rgvDataList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.rgvDataList.MasterTemplate.EnableGrouping = false;
            this.rgvDataList.Name = "rgvDataList";
            this.rgvDataList.ReadOnly = true;
            this.rgvDataList.Size = new System.Drawing.Size(792, 529);
            this.rgvDataList.TabIndex = 3;
            this.rgvDataList.Text = "radGridView1";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // rpTop
            // 
            this.rpTop.Controls.Add(this.rcb48Hour);
            this.rpTop.Controls.Add(this.rcbMuilte);
            this.rpTop.Controls.Add(this.rbFilter);
            this.rpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpTop.Location = new System.Drawing.Point(0, 0);
            this.rpTop.Name = "rpTop";
            this.rpTop.Size = new System.Drawing.Size(792, 41);
            this.rpTop.TabIndex = 4;
            // 
            // rcb48Hour
            // 
            this.rcb48Hour.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rcb48Hour.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rcb48Hour.Location = new System.Drawing.Point(9, 10);
            this.rcb48Hour.Name = "rcb48Hour";
            this.rcb48Hour.Size = new System.Drawing.Size(104, 18);
            this.rcb48Hour.TabIndex = 18;
            this.rcb48Hour.Text = "在场48小时以上";
            this.rcb48Hour.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // rcbMuilte
            // 
            this.rcbMuilte.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rcbMuilte.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rcbMuilte.Location = new System.Drawing.Point(124, 10);
            this.rcbMuilte.Name = "rcbMuilte";
            this.rcbMuilte.Size = new System.Drawing.Size(103, 18);
            this.rcbMuilte.TabIndex = 18;
            this.rcbMuilte.Text = "同时在多停车场";
            this.rcbMuilte.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // rbFilter
            // 
            this.rbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rbFilter.Location = new System.Drawing.Point(259, 6);
            this.rbFilter.Name = "rbFilter";
            this.rbFilter.Size = new System.Drawing.Size(71, 26);
            this.rbFilter.TabIndex = 16;
            this.rbFilter.Text = "查找&S)";
            this.rbFilter.Click += new System.EventHandler(this.rbFilter_Click);
            // 
            // rpBottom
            // 
            this.rpBottom.Controls.Add(this.rgvDataList);
            this.rpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBottom.Location = new System.Drawing.Point(0, 41);
            this.rpBottom.Name = "rpBottom";
            this.rpBottom.Size = new System.Drawing.Size(792, 529);
            this.rpBottom.TabIndex = 5;
            // 
            // ExceptionCarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rpBottom);
            this.Controls.Add(this.rpTop);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ExceptionCarSearch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "异常车辆";
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).EndInit();
            this.rpTop.ResumeLayout(false);
            this.rpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rcb48Hour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rcbMuilte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpBottom)).EndInit();
            this.rpBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvDataList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.RadPanel rpTop;
        private Telerik.WinControls.UI.RadButton rbFilter;
        private Telerik.WinControls.UI.RadPanel rpBottom;
        private Telerik.WinControls.UI.RadCheckBox rcb48Hour;
        private Telerik.WinControls.UI.RadCheckBox rcbMuilte;
    }
}