namespace Devgis.Manager.Sys
{
    partial class OperatorList
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
            this.radCommandBar1 = new Telerik.WinControls.UI.RadCommandBar();
            this.commandBarRowElement1 = new Telerik.WinControls.UI.CommandBarRowElement();
            this.commandBarStripElement1 = new Telerik.WinControls.UI.CommandBarStripElement();
            this.cmdAddOperator = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdEditOperator = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdDelOperator = new Telerik.WinControls.UI.CommandBarButton();
            this.cmdRefresh = new Telerik.WinControls.UI.CommandBarButton();
            this.rgvOperatorList = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radCommandBar1
            // 
            this.radCommandBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.radCommandBar1.Location = new System.Drawing.Point(0, 0);
            this.radCommandBar1.Name = "radCommandBar1";
            this.radCommandBar1.Rows.AddRange(new Telerik.WinControls.UI.CommandBarRowElement[] {
            this.commandBarRowElement1});
            this.radCommandBar1.Size = new System.Drawing.Size(792, 55);
            this.radCommandBar1.TabIndex = 2;
            this.radCommandBar1.Text = "添加";
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
            this.cmdAddOperator,
            this.cmdEditOperator,
            this.cmdDelOperator,
            this.cmdRefresh});
            this.commandBarStripElement1.Name = "commandBarStripElement1";
            this.commandBarStripElement1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // cmdAddOperator
            // 
            this.cmdAddOperator.AccessibleDescription = "注销";
            this.cmdAddOperator.AccessibleName = "注销";
            this.cmdAddOperator.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdAddOperator.DisplayName = "commandBarButton6";
            this.cmdAddOperator.DrawText = true;
            this.cmdAddOperator.Image = global::Devgis.Manager.Properties.Resources.car;
            this.cmdAddOperator.Name = "cmdAddOperator";
            this.cmdAddOperator.Text = "添加";
            this.cmdAddOperator.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdAddOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdAddOperator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdAddOperator.Click += new System.EventHandler(this.cmdAddOperator_Click);
            // 
            // cmdEditOperator
            // 
            this.cmdEditOperator.AccessibleDescription = "退出";
            this.cmdEditOperator.AccessibleName = "退出";
            this.cmdEditOperator.DisabledTextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdEditOperator.DisplayName = "commandBarButton11";
            this.cmdEditOperator.DrawText = true;
            this.cmdEditOperator.Image = global::Devgis.Manager.Properties.Resources.edit;
            this.cmdEditOperator.Name = "cmdEditOperator";
            this.cmdEditOperator.Text = "编辑";
            this.cmdEditOperator.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdEditOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdEditOperator.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.cmdEditOperator.Click += new System.EventHandler(this.cmdEditOperator_Click);
            // 
            // cmdDelOperator
            // 
            this.cmdDelOperator.AccessibleDescription = "删除";
            this.cmdDelOperator.AccessibleName = "删除";
            this.cmdDelOperator.DisplayName = "commandBarButton1";
            this.cmdDelOperator.DrawText = true;
            this.cmdDelOperator.Image = global::Devgis.Manager.Properties.Resources.del;
            this.cmdDelOperator.Name = "cmdDelOperator";
            this.cmdDelOperator.Text = "删除";
            this.cmdDelOperator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmdDelOperator.Click += new System.EventHandler(this.cmdDelOperator_Click);
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
            // rgvOperatorList
            // 
            this.rgvOperatorList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rgvOperatorList.Location = new System.Drawing.Point(0, 55);
            // 
            // rgvOperatorList
            // 
            this.rgvOperatorList.MasterTemplate.AllowAddNewRow = false;
            this.rgvOperatorList.MasterTemplate.AllowCellContextMenu = false;
            this.rgvOperatorList.MasterTemplate.AllowDeleteRow = false;
            this.rgvOperatorList.MasterTemplate.AllowDragToGroup = false;
            this.rgvOperatorList.MasterTemplate.AllowEditRow = false;
            this.rgvOperatorList.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewCheckBoxColumn1.HeaderText = "选中";
            gridViewCheckBoxColumn1.Name = "colSelect";
            gridViewCheckBoxColumn1.Width = 57;
            gridViewTextBoxColumn1.HeaderText = "id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "colID";
            gridViewTextBoxColumn2.HeaderText = "登陆名";
            gridViewTextBoxColumn2.Name = "colLoginName";
            gridViewTextBoxColumn2.Width = 239;
            gridViewTextBoxColumn3.HeaderText = "真名";
            gridViewTextBoxColumn3.Name = "colRealName";
            gridViewTextBoxColumn3.Width = 239;
            gridViewTextBoxColumn4.HeaderText = "密码";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.Name = "colPassword";
            gridViewTextBoxColumn5.HeaderText = "角色";
            gridViewTextBoxColumn5.Name = "colRole";
            gridViewTextBoxColumn5.Width = 240;
            this.rgvOperatorList.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewCheckBoxColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.rgvOperatorList.MasterTemplate.EnableGrouping = false;
            this.rgvOperatorList.Name = "rgvOperatorList";
            this.rgvOperatorList.ReadOnly = true;
            this.rgvOperatorList.Size = new System.Drawing.Size(792, 512);
            this.rgvOperatorList.TabIndex = 3;
            this.rgvOperatorList.Text = "radGridView1";
            this.rgvOperatorList.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.rgvOperatorList_CellClick);
            // 
            // OperatorList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 567);
            this.Controls.Add(this.rgvOperatorList);
            this.Controls.Add(this.radCommandBar1);
            this.Name = "OperatorList";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "账号列表";
            this.Shown += new System.EventHandler(this.OperatorList_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.radCommandBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadCommandBar radCommandBar1;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement1;
        private Telerik.WinControls.UI.CommandBarStripElement commandBarStripElement1;
        private Telerik.WinControls.UI.CommandBarButton cmdAddOperator;
        private Telerik.WinControls.UI.CommandBarButton cmdEditOperator;
        private Telerik.WinControls.UI.CommandBarButton cmdDelOperator;
        private Telerik.WinControls.UI.RadGridView rgvOperatorList;
        private Telerik.WinControls.UI.CommandBarButton cmdRefresh;
    }
}