namespace Devgis.Manager.ReportSearchs.CarDetail
{
    partial class ParkingInfo
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
            this.rpBottom = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).BeginInit();
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
            gridViewTextBoxColumn1.HeaderText = "停车场";
            gridViewTextBoxColumn1.Name = "colParkingName";
            gridViewTextBoxColumn1.Width = 374;
            gridViewTextBoxColumn2.HeaderText = "进口";
            gridViewTextBoxColumn2.MinWidth = 200;
            gridViewTextBoxColumn2.Name = "colEnterName";
            gridViewTextBoxColumn2.Width = 200;
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
            this.rgvDataList.Size = new System.Drawing.Size(792, 570);
            this.rgvDataList.TabIndex = 3;
            this.rgvDataList.Text = "radGridView1";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // rpBottom
            // 
            this.rpBottom.Controls.Add(this.rgvDataList);
            this.rpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBottom.Location = new System.Drawing.Point(0, 0);
            this.rpBottom.Name = "rpBottom";
            this.rpBottom.Size = new System.Drawing.Size(792, 570);
            this.rpBottom.TabIndex = 5;
            // 
            // ParkingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rpBottom);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ParkingInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "停车信息";
            this.Shown += new System.EventHandler(this.OperatorList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpBottom)).EndInit();
            this.rpBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvDataList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.RadPanel rpBottom;
    }
}