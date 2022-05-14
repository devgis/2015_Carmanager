namespace Devgis.Manager.Car
{
    partial class AddBlack
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
            this.rtbCarNos = new Telerik.WinControls.UI.RadTextBox();
            this.rbSave = new Telerik.WinControls.UI.RadButton();
            this.rbCancel = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbCarNos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(81, 66);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(87, 29);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "黑名单：";
            // 
            // rtbCarNos
            // 
            this.rtbCarNos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbCarNos.AutoSize = false;
            this.rtbCarNos.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbCarNos.Location = new System.Drawing.Point(168, 66);
            this.rtbCarNos.MaxLength = 20;
            this.rtbCarNos.Multiline = true;
            this.rtbCarNos.Name = "rtbCarNos";
            this.rtbCarNos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.rtbCarNos.Size = new System.Drawing.Size(286, 173);
            this.rtbCarNos.TabIndex = 1;
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
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(454, 70);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 22);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "(多个请用,分隔)";
            // 
            // AddBlack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.rbCancel);
            this.Controls.Add(this.rbSave);
            this.Controls.Add(this.rtbCarNos);
            this.Controls.Add(this.radLabel1);
            this.Name = "AddBlack";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加黑名单";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbCarNos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox rtbCarNos;
        private Telerik.WinControls.UI.RadButton rbSave;
        private Telerik.WinControls.UI.RadButton rbCancel;
        private Telerik.WinControls.UI.RadLabel radLabel2;

    }
}