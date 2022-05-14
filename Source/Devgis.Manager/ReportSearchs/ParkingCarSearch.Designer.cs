namespace Devgis.Manager.ReportSearchs
{
    partial class ParkingCarSearch
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgvOperatorList = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.rpTop = new Telerik.WinControls.UI.RadPanel();
            this.rdpStartTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.rdpEndTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rlistSentryBox = new Telerik.WinControls.UI.RadDropDownList();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rlistParking = new Telerik.WinControls.UI.RadDropDownList();
            this.rbFilter = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rpBottom = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).BeginInit();
            this.rpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistSentryBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpBottom)).BeginInit();
            this.rpBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // rgvOperatorList
            // 
            this.rgvOperatorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvOperatorList.Location = new System.Drawing.Point(0, 0);
            // 
            // rgvOperatorList
            // 
            this.rgvOperatorList.MasterTemplate.AllowAddNewRow = false;
            this.rgvOperatorList.MasterTemplate.AllowCellContextMenu = false;
            this.rgvOperatorList.MasterTemplate.AllowDeleteRow = false;
            this.rgvOperatorList.MasterTemplate.AllowDragToGroup = false;
            this.rgvOperatorList.MasterTemplate.AllowEditRow = false;
            this.rgvOperatorList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.HeaderText = "车牌号";
            gridViewTextBoxColumn1.MinWidth = 200;
            gridViewTextBoxColumn1.Name = "colCarNO";
            gridViewTextBoxColumn1.Width = 200;
            gridViewTextBoxColumn2.HeaderText = "停车场";
            gridViewTextBoxColumn2.Name = "colParkingName";
            gridViewTextBoxColumn2.Width = 175;
            gridViewTextBoxColumn3.HeaderText = "入口";
            gridViewTextBoxColumn3.MinWidth = 200;
            gridViewTextBoxColumn3.Name = "colSentryName";
            gridViewTextBoxColumn3.Width = 200;
            gridViewTextBoxColumn4.HeaderText = "进场时间";
            gridViewTextBoxColumn4.MinWidth = 200;
            gridViewTextBoxColumn4.Name = "colEnterTime";
            gridViewTextBoxColumn4.Width = 200;
            this.rgvOperatorList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.rgvOperatorList.MasterTemplate.EnableGrouping = false;
            this.rgvOperatorList.Name = "rgvOperatorList";
            this.rgvOperatorList.ReadOnly = true;
            this.rgvOperatorList.Size = new System.Drawing.Size(792, 529);
            this.rgvOperatorList.TabIndex = 3;
            this.rgvOperatorList.Text = "radGridView1";
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // rpTop
            // 
            this.rpTop.Controls.Add(this.rdpStartTime);
            this.rpTop.Controls.Add(this.rdpEndTime);
            this.rpTop.Controls.Add(this.radLabel3);
            this.rpTop.Controls.Add(this.radLabel2);
            this.rpTop.Controls.Add(this.rlistSentryBox);
            this.rpTop.Controls.Add(this.radLabel4);
            this.rpTop.Controls.Add(this.rlistParking);
            this.rpTop.Controls.Add(this.rbFilter);
            this.rpTop.Controls.Add(this.radLabel1);
            this.rpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpTop.Location = new System.Drawing.Point(0, 0);
            this.rpTop.Name = "rpTop";
            this.rpTop.Size = new System.Drawing.Size(792, 41);
            this.rpTop.TabIndex = 4;
            // 
            // rdpStartTime
            // 
            this.rdpStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpStartTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpStartTime.Location = new System.Drawing.Point(369, 8);
            this.rdpStartTime.Name = "rdpStartTime";
            this.rdpStartTime.Size = new System.Drawing.Size(135, 24);
            this.rdpStartTime.TabIndex = 20;
            this.rdpStartTime.TabStop = false;
            this.rdpStartTime.Text = "2015-10-05 15:00:01";
            this.rdpStartTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 1, 515);
            // 
            // rdpEndTime
            // 
            this.rdpEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpEndTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpEndTime.Location = new System.Drawing.Point(578, 8);
            this.rdpEndTime.Name = "rdpEndTime";
            this.rdpEndTime.Size = new System.Drawing.Size(134, 24);
            this.rdpEndTime.TabIndex = 22;
            this.rdpEndTime.TabStop = false;
            this.rdpEndTime.Text = "2015-10-05 15:00:38";
            this.rdpEndTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 38, 265);
            // 
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel3.Location = new System.Drawing.Point(503, 8);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 22);
            this.radLabel3.TabIndex = 21;
            this.radLabel3.Text = "结束时间：";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(295, 8);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(79, 22);
            this.radLabel2.TabIndex = 19;
            this.radLabel2.Text = "开始时间：";
            // 
            // rlistSentryBox
            // 
            this.rlistSentryBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rlistSentryBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlistSentryBox.Location = new System.Drawing.Point(220, 8);
            this.rlistSentryBox.Name = "rlistSentryBox";
            this.rlistSentryBox.Size = new System.Drawing.Size(76, 24);
            this.rlistSentryBox.TabIndex = 18;
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel4.Location = new System.Drawing.Point(153, 9);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(68, 22);
            this.radLabel4.TabIndex = 17;
            this.radLabel4.Text = "进入岗亭:";
            // 
            // rlistParking
            // 
            this.rlistParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rlistParking.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlistParking.Location = new System.Drawing.Point(51, 8);
            this.rlistParking.Name = "rlistParking";
            this.rlistParking.Size = new System.Drawing.Size(97, 24);
            this.rlistParking.TabIndex = 11;
            this.rlistParking.SelectedIndexChanged += new Telerik.WinControls.UI.Data.PositionChangedEventHandler(this.rlistParking_SelectedIndexChanged);
            // 
            // rbFilter
            // 
            this.rbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rbFilter.Location = new System.Drawing.Point(713, 6);
            this.rbFilter.Name = "rbFilter";
            this.rbFilter.Size = new System.Drawing.Size(71, 26);
            this.rbFilter.TabIndex = 16;
            this.rbFilter.Text = "查找&S)";
            this.rbFilter.Click += new System.EventHandler(this.rbFilter_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel1.BackColor = System.Drawing.Color.Transparent;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(-3, 8);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(54, 22);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "停车场:";
            // 
            // rpBottom
            // 
            this.rpBottom.Controls.Add(this.rgvOperatorList);
            this.rpBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpBottom.Location = new System.Drawing.Point(0, 41);
            this.rpBottom.Name = "rpBottom";
            this.rpBottom.Size = new System.Drawing.Size(792, 529);
            this.rpBottom.TabIndex = 5;
            // 
            // ParkingCarSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rpBottom);
            this.Controls.Add(this.rpTop);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ParkingCarSearch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "在场明细查询";
            this.Load += new System.EventHandler(this.ParkingCarSearch_Load);
            this.Shown += new System.EventHandler(this.OperatorList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).EndInit();
            this.rpTop.ResumeLayout(false);
            this.rpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistSentryBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rlistParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpBottom)).EndInit();
            this.rpBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvOperatorList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.RadPanel rpTop;
        private Telerik.WinControls.UI.RadDropDownList rlistParking;
        private Telerik.WinControls.UI.RadButton rbFilter;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel rpBottom;
        private Telerik.WinControls.UI.RadDropDownList rlistSentryBox;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadDateTimePicker rdpStartTime;
        private Telerik.WinControls.UI.RadDateTimePicker rdpEndTime;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}