namespace Devgis.Manager.Parking
{
    partial class ParkingList
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
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn1 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.mainCommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdAdd = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdEdit = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdRefresh = new Telerik.WinControls.UI.CommandBarButton();
            this.rgvDataList = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mainCommandBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // mainCommandBar
            // 
            this.mainCommandBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainCommandBar.Location = new System.Drawing.Point(0, 0);
            this.mainCommandBar.Name = "mainCommandBar";
            this.mainCommandBar.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.mainCommandBar.Size = new System.Drawing.Size(792, 30);
            this.mainCommandBar.TabIndex = 2;
            this.mainCommandBar.Text = "添加";
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
            this.cmdAdd,
            this.cmdEdit,
            this.cmdRefresh});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cmdAdd
            // 
            this.cmdAdd.AccessibleDescription = "注销";
            this.cmdAdd.AccessibleName = "注销";
            this.cmdAdd.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdAdd.DisplayName = "commandBarButton6";
            this.cmdAdd.DrawText = true;
            this.cmdAdd.Image = global::Devgis.Manager.Properties.Resources.car;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Text = "添加";
            this.cmdAdd.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // cmdEdit
            // 
            this.cmdEdit.AccessibleDescription = "退出";
            this.cmdEdit.AccessibleName = "退出";
            this.cmdEdit.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdEdit.DisplayName = "commandBarButton11";
            this.cmdEdit.DrawText = true;
            this.cmdEdit.Image = global::Devgis.Manager.Properties.Resources.edit;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Text = "编辑";
            this.cmdEdit.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.AccessibleDescription = "刷新";
            this.cmdRefresh.AccessibleName = "刷新";
            this.cmdRefresh.DisplayName = "commandBarButton1";
            this.cmdRefresh.DrawText = true;
            this.cmdRefresh.Image = global::Devgis.Manager.Properties.Resources.refresh;
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Text = "刷新";
            this.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // rgvDataList
            // 
            this.rgvDataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvDataList.Location = new System.Drawing.Point(0, 30);
            // 
            // rgvDataList
            // 
            this.rgvDataList.MasterTemplate.AllowAddNewRow = false;
            this.rgvDataList.MasterTemplate.AllowCellContextMenu = false;
            this.rgvDataList.MasterTemplate.AllowDeleteRow = false;
            this.rgvDataList.MasterTemplate.AllowDragToGroup = false;
            this.rgvDataList.MasterTemplate.AllowEditRow = false;
            this.rgvDataList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn1.HeaderText = "选中";
            gridViewCheckBoxColumn1.MaxWidth = 50;
            gridViewCheckBoxColumn1.MinWidth = 50;
            gridViewCheckBoxColumn1.Name = "colSelect";
            gridViewTextBoxColumn1.HeaderText = "id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "colID";
            gridViewTextBoxColumn2.HeaderText = "名称";
            gridViewTextBoxColumn2.MaxWidth = 500;
            gridViewTextBoxColumn2.MinWidth = 80;
            gridViewTextBoxColumn2.Name = "colName";
            gridViewTextBoxColumn2.Width = 80;
            gridViewTextBoxColumn3.HeaderText = "地区";
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "colZone";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "地址";
            gridViewTextBoxColumn4.MaxWidth = 600;
            gridViewTextBoxColumn4.MinWidth = 300;
            gridViewTextBoxColumn4.Name = "colAddress";
            gridViewTextBoxColumn4.Width = 300;
            gridViewTextBoxColumn5.HeaderText = "停车位数";
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "colSpaceCount";
            gridViewTextBoxColumn5.Width = 100;
            gridViewTextBoxColumn6.HeaderText = "经度";
            gridViewTextBoxColumn6.MaxWidth = 100;
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "colX";
            gridViewTextBoxColumn6.Width = 100;
            gridViewTextBoxColumn7.HeaderText = "纬度";
            gridViewTextBoxColumn7.MaxWidth = 100;
            gridViewTextBoxColumn7.MinWidth = 100;
            gridViewTextBoxColumn7.Name = "colY";
            gridViewTextBoxColumn7.Width = 100;
            gridViewTextBoxColumn8.HeaderText = "账户余额(元)";
            gridViewTextBoxColumn8.MaxWidth = 150;
            gridViewTextBoxColumn8.MinWidth = 150;
            gridViewTextBoxColumn8.Name = "colBalance";
            gridViewTextBoxColumn8.Width = 150;
            this.rgvDataList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.rgvDataList.MasterTemplate.EnableGrouping = false;
            this.rgvDataList.Name = "rgvDataList";
            this.rgvDataList.ReadOnly = true;
            this.rgvDataList.Size = new System.Drawing.Size(792, 537);
            this.rgvDataList.TabIndex = 3;
            this.rgvDataList.Text = "radGridView1";
            this.rgvDataList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvDataList_CellClick);
            // 
            // ParkingList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 567);
            this.Controls.Add(this.rgvDataList);
            this.Controls.Add(this.mainCommandBar);
            this.Name = "ParkingList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "停车场列表";
            this.Shown += new System.EventHandler(this.OperatorList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.mainCommandBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar mainCommandBar;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cmdAdd;
        private Telerik.WinControls.UI.CommandBarButton cmdEdit;
        private Telerik.WinControls.UI.RadGridView rgvDataList;
        private Telerik.WinControls.UI.CommandBarButton cmdRefresh;
    }
}