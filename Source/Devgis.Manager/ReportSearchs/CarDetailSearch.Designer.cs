namespace Devgis.Manager.ReportSearchs
{
    partial class CarDetailSearch
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.rgvDataList = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElement2 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.rpTop = new Telerik.WinControls.UI.RadPanel();
            this.rbCarNO = new Telerik.WinControls.UI.RadTextBox();
            this.rbMobile = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rbFilter = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rpBottom = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).BeginInit();
            this.rpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbCarNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
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
            gridViewTextBoxColumn1.FieldName = "carno";
            gridViewTextBoxColumn1.HeaderText = "车牌";
            gridViewTextBoxColumn1.Name = "colCarNO";
            gridViewTextBoxColumn1.Width = 415;
            gridViewCommandColumn1.FieldName = "detail";
            gridViewCommandColumn1.HeaderText = "详细信息";
            gridViewCommandColumn1.MinWidth = 120;
            gridViewCommandColumn1.Name = "colDetail";
            gridViewCommandColumn1.Width = 120;
            gridViewCommandColumn2.FieldName = "parkinfo";
            gridViewCommandColumn2.HeaderText = "停车信息";
            gridViewCommandColumn2.MinWidth = 120;
            gridViewCommandColumn2.Name = "colParking";
            gridViewCommandColumn2.Width = 120;
            gridViewCommandColumn3.FieldName = "feeinfo";
            gridViewCommandColumn3.HeaderText = "缴费信息";
            gridViewCommandColumn3.MinWidth = 120;
            gridViewCommandColumn3.Name = "colFee";
            gridViewCommandColumn3.Width = 120;
            this.rgvDataList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.rgvDataList.MasterTemplate.EnableGrouping = false;
            this.rgvDataList.Name = "rgvDataList";
            this.rgvDataList.ReadOnly = true;
            this.rgvDataList.Size = new System.Drawing.Size(792, 529);
            this.rgvDataList.TabIndex = 3;
            this.rgvDataList.Text = "rgvDataList";
            this.rgvDataList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvDataList_CellClick);
            // 
            // commandBarRowElement2
            // 
            this.commandBarRowElement2.MinSize = new System.Drawing.Size(25, 25);
            // 
            // rpTop
            // 
            this.rpTop.Controls.Add(this.rbCarNO);
            this.rpTop.Controls.Add(this.rbMobile);
            this.rpTop.Controls.Add(this.radLabel4);
            this.rpTop.Controls.Add(this.rbFilter);
            this.rpTop.Controls.Add(this.radLabel1);
            this.rpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpTop.Location = new System.Drawing.Point(0, 0);
            this.rpTop.Name = "rpTop";
            this.rpTop.Size = new System.Drawing.Size(792, 41);
            this.rpTop.TabIndex = 4;
            // 
            // rbCarNO
            // 
            this.rbCarNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbCarNO.Location = new System.Drawing.Point(291, 10);
            this.rbCarNO.Name = "rbCarNO";
            this.rbCarNO.Size = new System.Drawing.Size(163, 20);
            this.rbCarNO.TabIndex = 24;
            // 
            // rbMobile
            // 
            this.rbMobile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbMobile.Location = new System.Drawing.Point(57, 11);
            this.rbMobile.Name = "rbMobile";
            this.rbMobile.Size = new System.Drawing.Size(163, 20);
            this.rbMobile.TabIndex = 26;
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel4.Location = new System.Drawing.Point(244, 8);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 22);
            this.radLabel4.TabIndex = 23;
            this.radLabel4.Text = "车牌：";
            // 
            // rbFilter
            // 
            this.rbFilter.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbFilter.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rbFilter.Location = new System.Drawing.Point(469, 7);
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
            this.radLabel1.Location = new System.Drawing.Point(10, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(50, 22);
            this.radLabel1.TabIndex = 25;
            this.radLabel1.Text = "手机：";
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
            // CarDetailSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rpBottom);
            this.Controls.Add(this.rpTop);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "CarDetailSearch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "车辆信息";
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).EndInit();
            this.rpTop.ResumeLayout(false);
            this.rpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rbCarNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbFilter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
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
        private Telerik.WinControls.UI.RadTextBox rbMobile;
        private Telerik.WinControls.UI.RadTextBox rbCarNO;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel4;
    }
}