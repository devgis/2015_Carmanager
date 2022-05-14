namespace Devgis.Manager.ReportSearchs
{
    partial class ManulOpenSearch
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
            this.rlistOperator = new Telerik.WinControls.UI.RadDropDownList();
            this.rbCarNO = new Telerik.WinControls.UI.RadTextBox();
            this.rdpStartTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.rbQuery = new Telerik.WinControls.UI.RadButton();
            this.rdpEndTime = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rpBottom = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).BeginInit();
            this.rpTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlistOperator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCarNO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbQuery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
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
            gridViewTextBoxColumn1.HeaderText = "停车场";
            gridViewTextBoxColumn1.Name = "colParkingName";
            gridViewTextBoxColumn1.Width = 225;
            gridViewTextBoxColumn2.HeaderText = "车牌号";
            gridViewTextBoxColumn2.MinWidth = 200;
            gridViewTextBoxColumn2.Name = "colCarNO";
            gridViewTextBoxColumn2.Width = 200;
            gridViewTextBoxColumn3.HeaderText = "进或出";
            gridViewTextBoxColumn3.MinWidth = 150;
            gridViewTextBoxColumn3.Name = "colEnOrOut";
            gridViewTextBoxColumn3.Width = 150;
            gridViewTextBoxColumn4.HeaderText = "开闸时间";
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
            this.rpTop.Controls.Add(this.rlistOperator);
            this.rpTop.Controls.Add(this.rbCarNO);
            this.rpTop.Controls.Add(this.rdpStartTime);
            this.rpTop.Controls.Add(this.radLabel4);
            this.rpTop.Controls.Add(this.rbQuery);
            this.rpTop.Controls.Add(this.rdpEndTime);
            this.rpTop.Controls.Add(this.radLabel1);
            this.rpTop.Controls.Add(this.radLabel3);
            this.rpTop.Controls.Add(this.radLabel2);
            this.rpTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.rpTop.Location = new System.Drawing.Point(0, 0);
            this.rpTop.Name = "rpTop";
            this.rpTop.Size = new System.Drawing.Size(792, 41);
            this.rpTop.TabIndex = 4;
            // 
            // rlistOperator
            // 
            this.rlistOperator.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rlistOperator.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.rlistOperator.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rlistOperator.Location = new System.Drawing.Point(51, 9);
            this.rlistOperator.Name = "rlistOperator";
            this.rlistOperator.Size = new System.Drawing.Size(112, 24);
            this.rlistOperator.TabIndex = 11;
            // 
            // rbCarNO
            // 
            this.rbCarNO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbCarNO.Location = new System.Drawing.Point(208, 10);
            this.rbCarNO.Name = "rbCarNO";
            this.rbCarNO.Size = new System.Drawing.Size(85, 20);
            this.rbCarNO.TabIndex = 18;
            // 
            // rdpStartTime
            // 
            this.rdpStartTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdpStartTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpStartTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpStartTime.Location = new System.Drawing.Point(367, 8);
            this.rdpStartTime.Name = "rdpStartTime";
            this.rdpStartTime.Size = new System.Drawing.Size(135, 24);
            this.rdpStartTime.TabIndex = 13;
            this.rdpStartTime.TabStop = false;
            this.rdpStartTime.Text = "2015-10-05 15:00:01";
            this.rdpStartTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 1, 515);
            // 
            // radLabel4
            // 
            this.radLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel4.BackColor = System.Drawing.Color.Transparent;
            this.radLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel4.Location = new System.Drawing.Point(162, 9);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 22);
            this.radLabel4.TabIndex = 17;
            this.radLabel4.Text = "车牌：";
            // 
            // rbQuery
            // 
            this.rbQuery.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rbQuery.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.rbQuery.Location = new System.Drawing.Point(716, 8);
            this.rbQuery.Name = "rbQuery";
            this.rbQuery.Size = new System.Drawing.Size(71, 26);
            this.rbQuery.TabIndex = 16;
            this.rbQuery.Text = "查询(&S)";
            this.rbQuery.Click += new System.EventHandler(this.rbQuery_Click);
            // 
            // rdpEndTime
            // 
            this.rdpEndTime.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdpEndTime.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.rdpEndTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdpEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rdpEndTime.Location = new System.Drawing.Point(576, 8);
            this.rdpEndTime.Name = "rdpEndTime";
            this.rdpEndTime.Size = new System.Drawing.Size(134, 24);
            this.rdpEndTime.TabIndex = 15;
            this.rdpEndTime.TabStop = false;
            this.rdpEndTime.Text = "2015-10-05 15:00:38";
            this.rdpEndTime.Value = new System.DateTime(2015, 10, 5, 15, 0, 38, 265);
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
            // radLabel3
            // 
            this.radLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel3.BackColor = System.Drawing.Color.Transparent;
            this.radLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel3.Location = new System.Drawing.Point(501, 8);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(79, 22);
            this.radLabel3.TabIndex = 14;
            this.radLabel3.Text = "结束时间：";
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radLabel2.BackColor = System.Drawing.Color.Transparent;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(293, 8);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(79, 22);
            this.radLabel2.TabIndex = 12;
            this.radLabel2.Text = "开始时间：";
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
            // ManulOpenSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 570);
            this.Controls.Add(this.rpBottom);
            this.Controls.Add(this.rpTop);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "ManulOpenSearch";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "手动开闸查询";
            this.Load += new System.EventHandler(this.LogList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rgvOperatorList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpTop)).EndInit();
            this.rpTop.ResumeLayout(false);
            this.rpTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rlistOperator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCarNO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpStartTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbQuery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rdpEndTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpBottom)).EndInit();
            this.rpBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView rgvOperatorList;
        private Telerik.WinControls.UI.CommandBarRowElement commandBarRowElement2;
        private Telerik.WinControls.UI.RadPanel rpTop;
        private Telerik.WinControls.UI.RadDropDownList rlistOperator;
        private Telerik.WinControls.UI.RadButton rbQuery;
        private Telerik.WinControls.UI.RadDateTimePicker rdpEndTime;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker rdpStartTime;
        private Telerik.WinControls.UI.RadPanel rpBottom;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox rbCarNO;
    }
}