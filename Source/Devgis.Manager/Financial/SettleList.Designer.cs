namespace Devgis.Manager.Financial
{
    partial class SettleList
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.rgvDataList = new Telerik.WinControls.UI.RadGridView();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdRefresh = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdAdd = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdEdit = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdDel = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdVerify = new Telerik.WinControls.UI.CommandBarButton();
            this.mainCommandBar = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarButton1 = new Telerik.WinControls.UI.CommandBarButton();
            this.commandBarButton2 = new Telerik.WinControls.UI.CommandBarButton();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCommandBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            gridViewCheckBoxColumn1.HeaderText = "选中";
            gridViewCheckBoxColumn1.MaxWidth = 30;
            gridViewCheckBoxColumn1.MinWidth = 50;
            gridViewCheckBoxColumn1.Name = "colSelect";
            gridViewCheckBoxColumn1.Width = 30;
            gridViewTextBoxColumn1.HeaderText = "id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "colID";
            gridViewTextBoxColumn2.HeaderText = "停车场";
            gridViewTextBoxColumn2.MaxWidth = 100;
            gridViewTextBoxColumn2.MinWidth = 80;
            gridViewTextBoxColumn2.Name = "colParkingName";
            gridViewTextBoxColumn2.Width = 86;
            gridViewTextBoxColumn3.HeaderText = "金额";
            gridViewTextBoxColumn3.MaxWidth = 100;
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "colAmount";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.HeaderText = "银行";
            gridViewTextBoxColumn4.MinWidth = 100;
            gridViewTextBoxColumn4.Name = "colBankName";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.HeaderText = "账户户主";
            gridViewTextBoxColumn5.MaxWidth = 60;
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "colAccountOwner";
            gridViewTextBoxColumn5.Width = 60;
            gridViewTextBoxColumn6.HeaderText = "银行账号";
            gridViewTextBoxColumn6.MaxWidth = 150;
            gridViewTextBoxColumn6.MinWidth = 150;
            gridViewTextBoxColumn6.Name = "colBankAccount";
            gridViewTextBoxColumn6.Width = 150;
            gridViewTextBoxColumn7.HeaderText = "备注";
            gridViewTextBoxColumn7.MinWidth = 200;
            gridViewTextBoxColumn7.Name = "colRemarks";
            gridViewTextBoxColumn7.Width = 200;
            gridViewTextBoxColumn8.HeaderText = "操作员";
            gridViewTextBoxColumn8.MinWidth = 100;
            gridViewTextBoxColumn8.Name = "colOperatorName";
            gridViewTextBoxColumn8.Width = 100;
            gridViewTextBoxColumn9.HeaderText = "操作时间";
            gridViewTextBoxColumn9.MinWidth = 100;
            gridViewTextBoxColumn9.Name = "colOperatorTime";
            gridViewTextBoxColumn9.Width = 100;
            gridViewTextBoxColumn10.HeaderText = "最后编辑";
            gridViewTextBoxColumn10.MinWidth = 100;
            gridViewTextBoxColumn10.Name = "colLastEditOperator";
            gridViewTextBoxColumn10.Width = 100;
            gridViewTextBoxColumn11.HeaderText = "最后编辑时间";
            gridViewTextBoxColumn11.MinWidth = 100;
            gridViewTextBoxColumn11.Name = "colLastEditTime";
            gridViewTextBoxColumn11.Width = 100;
            gridViewTextBoxColumn12.HeaderText = "审核人";
            gridViewTextBoxColumn12.MinWidth = 100;
            gridViewTextBoxColumn12.Name = "colVerifyName";
            gridViewTextBoxColumn12.Width = 100;
            gridViewTextBoxColumn13.HeaderText = "审核时间";
            gridViewTextBoxColumn13.MinWidth = 100;
            gridViewTextBoxColumn13.Name = "colVerifyTime";
            gridViewTextBoxColumn13.Width = 100;
            gridViewTextBoxColumn14.HeaderText = "State";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.Name = "colState";
            gridViewTextBoxColumn14.Width = 21;
            gridViewTextBoxColumn15.HeaderText = "状态";
            gridViewTextBoxColumn15.MaxWidth = 50;
            gridViewTextBoxColumn15.Name = "colStateName";
            this.rgvDataList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15});
            this.rgvDataList.MasterTemplate.EnableGrouping = false;
            this.rgvDataList.Name = "rgvDataList";
            this.rgvDataList.ReadOnly = true;
            this.rgvDataList.Size = new System.Drawing.Size(792, 537);
            this.rgvDataList.TabIndex = 3;
            this.rgvDataList.Text = "radGridView1";
            this.rgvDataList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvDataList_CellClick);
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
            this.cmdAdd,
            this.cmdEdit,
            this.cmdDel,
            this.cmdVerify});
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
            // cmdAdd
            // 
            this.cmdAdd.AccessibleDescription = "添加";
            this.cmdAdd.AccessibleName = "添加";
            this.cmdAdd.DisplayName = "commandBarButton3";
            this.cmdAdd.DrawText = true;
            this.cmdAdd.Image = global::Devgis.Manager.Properties.Resources.car;
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Text = "添加";
            this.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click_1);
            // 
            // cmdEdit
            // 
            this.cmdEdit.AccessibleDescription = "编辑";
            this.cmdEdit.AccessibleName = "编辑";
            this.cmdEdit.DisplayName = "commandBarButton4";
            this.cmdEdit.DrawText = true;
            this.cmdEdit.Image = global::Devgis.Manager.Properties.Resources.edit;
            this.cmdEdit.Name = "cmdEdit";
            this.cmdEdit.Text = "编辑";
            this.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEdit.Click += new System.EventHandler(this.cmdEdit_Click_1);
            // 
            // cmdDel
            // 
            this.cmdDel.AccessibleDescription = "删除";
            this.cmdDel.AccessibleName = "删除";
            this.cmdDel.DisplayName = "commandBarButton5";
            this.cmdDel.DrawText = true;
            this.cmdDel.Image = global::Devgis.Manager.Properties.Resources.del;
            this.cmdDel.Name = "cmdDel";
            this.cmdDel.Text = "删除";
            this.cmdDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdDel.Click += new System.EventHandler(this.cmdDel_Click);
            // 
            // cmdVerify
            // 
            this.cmdVerify.AccessibleDescription = "审核";
            this.cmdVerify.AccessibleName = "审核";
            this.cmdVerify.DisplayName = "commandBarButton6";
            this.cmdVerify.DrawText = true;
            this.cmdVerify.Image = global::Devgis.Manager.Properties.Resources.huizong;
            this.cmdVerify.Name = "cmdVerify";
            this.cmdVerify.Text = "审核";
            this.cmdVerify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdVerify.Click += new System.EventHandler(this.cmdVerify_Click);
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
            // commandBarButton1
            // 
            this.commandBarButton1.AccessibleDescription = "刷新";
            this.commandBarButton1.AccessibleName = "刷新";
            this.commandBarButton1.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton1.DisplayName = "commandBarButton1";
            this.commandBarButton1.DrawText = true;
            this.commandBarButton1.Image = global::Devgis.Manager.Properties.Resources.refresh;
            this.commandBarButton1.Name = "commandBarButton1";
            this.commandBarButton1.Text = "刷新";
            this.commandBarButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // commandBarButton2
            // 
            this.commandBarButton2.AccessibleDescription = "刷新";
            this.commandBarButton2.AccessibleName = "刷新";
            this.commandBarButton2.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.commandBarButton2.DisplayName = "commandBarButton1";
            this.commandBarButton2.DrawText = true;
            this.commandBarButton2.Image = global::Devgis.Manager.Properties.Resources.refresh;
            this.commandBarButton2.Name = "commandBarButton2";
            this.commandBarButton2.Text = "刷新";
            this.commandBarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.commandBarButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // SettleList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 567);
            this.Controls.Add(this.rgvDataList);
            this.Controls.Add(this.mainCommandBar);
            this.Name = "SettleList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "结算历史";
            this.Shown += new System.EventHandler(this.OperatorList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainCommandBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvDataList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cmdRefresh;
        private Telerik.WinControls.UI.RadCommandBar mainCommandBar;
        private Telerik.WinControls.UI.CommandBarButton cmdAdd;
        private Telerik.WinControls.UI.CommandBarButton cmdEdit;
        private Telerik.WinControls.UI.CommandBarButton cmdDel;
        private Telerik.WinControls.UI.CommandBarButton cmdVerify;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton1;
        private Telerik.WinControls.UI.CommandBarButton commandBarButton2;
    }
}