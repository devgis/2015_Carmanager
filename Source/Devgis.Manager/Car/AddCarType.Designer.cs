namespace Devgis.Manager.Car
{
    partial class AddCarType
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.rtbTypeName = new Telerik.WinControls.UI.RadTextBox();
            this.rbSave = new Telerik.WinControls.UI.RadButton();
            this.rbCancel = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbTypeName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(81, 115);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(107, 29);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "类型名称：";
            // 
            // rtbTypeName
            // 
            this.rtbTypeName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbTypeName.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbTypeName.Location = new System.Drawing.Point(188, 115);
            this.rtbTypeName.MaxLength = 20;
            this.rtbTypeName.Name = "rtbTypeName";
            this.rtbTypeName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbTypeName.Size = new System.Drawing.Size(286, 31);
            this.rtbTypeName.TabIndex = 1;
            // 
            // rbSave
            // 
            this.rbSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSave.Location = new System.Drawing.Point(163, 295);
            this.rbSave.Name = "rbSave";
            this.rbSave.Size = new System.Drawing.Size(110, 33);
            this.rbSave.TabIndex = 8;
            this.rbSave.Text = "新增(&A)";
            this.rbSave.Click += new System.EventHandler(this.rbSave_Click);
            // 
            // rbCancel
            // 
            this.rbCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbCancel.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbCancel.Location = new System.Drawing.Point(293, 295);
            this.rbCancel.Name = "rbCancel";
            this.rbCancel.Size = new System.Drawing.Size(110, 33);
            this.rbCancel.TabIndex = 9;
            this.rbCancel.Text = "取消(&C)";
            // 
            // AddCarType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.rbCancel);
            this.Controls.Add(this.rbSave);
            this.Controls.Add(this.rtbTypeName);
            this.Controls.Add(this.radLabel1);
            this.Name = "AddCarType";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加车辆类型";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbTypeName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox rtbTypeName;
        private Telerik.WinControls.UI.RadButton rbSave;
        private Telerik.WinControls.UI.RadButton rbCancel;

    }
}