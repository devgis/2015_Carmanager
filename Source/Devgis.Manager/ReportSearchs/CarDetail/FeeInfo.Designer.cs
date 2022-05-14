namespace Devgis.Manager.ReportSearchs.CarDetail
{
    partial class FeeInfo
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
            gridViewTextBoxColumn5.HeaderText = "停车场";
            gridViewTextBoxColumn5.Name = "colParkingName";
            gridViewTextBoxColumn5.Width = 192;
            gridViewTextBoxColumn6.HeaderText = "进场时间";
            gridViewTextBoxColumn6.MinWidth = 200;
            gridViewTextBoxColumn6.Name = "colEnterTime";
            gridViewTextBoxColumn6.Width = 233;
            gridViewTextBoxColumn7.HeaderText = "出场时间";
            gridViewTextBoxColumn7.MinWidth = 200;
            gridViewTextBoxColumn7.Name = "colOutTime";
            gridViewTextBoxColumn7.Width = 200;
            gridViewTextBoxColumn8.HeaderText = "收费金额";
            gridViewTextBoxColumn8.MinWidth = 150;
            gridViewTextBoxColumn8.Name = "colAmount";
            gridViewTextBoxColumn8.Width = 150;
            this.rgvDataList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
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
            // FeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rpBottom);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FeeInfo";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "缴费信息";
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