namespace Devgis.Manager.APP
{
    partial class AddRecharge
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
            this.rtbAmount = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.rbSave = new Telerik.WinControls.UI.RadButton();
            this.rbCancel = new Telerik.WinControls.UI.RadButton();
            this.rtbRemarks = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.dlistMember = new Telerik.WinControls.UI.RadDropDownList();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbRemarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlistMember)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel1.Location = new System.Drawing.Point(81, 66);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 29);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "会员：";
            // 
            // rtbAmount
            // 
            this.rtbAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbAmount.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbAmount.Location = new System.Drawing.Point(214, 106);
            this.rtbAmount.MaxLength = 20;
            this.rtbAmount.Name = "rtbAmount";
            this.rtbAmount.Size = new System.Drawing.Size(286, 31);
            this.rtbAmount.TabIndex = 3;
            // 
            // radLabel2
            // 
            this.radLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel2.Location = new System.Drawing.Point(81, 106);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(107, 29);
            this.radLabel2.TabIndex = 2;
            this.radLabel2.Text = "充值金额：";
            // 
            // rbSave
            // 
            this.rbSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rbSave.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rbSave.Location = new System.Drawing.Point(163, 295);
            this.rbSave.Name = "rbSave";
            this.rbSave.Size = new System.Drawing.Size(110, 33);
            this.rbSave.TabIndex = 8;
            this.rbSave.Text = "充值(&R)";
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
            // rtbRemarks
            // 
            this.rtbRemarks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbRemarks.AutoSize = false;
            this.rtbRemarks.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbRemarks.Location = new System.Drawing.Point(214, 148);
            this.rtbRemarks.MaxLength = 50;
            this.rtbRemarks.Multiline = true;
            this.rtbRemarks.Name = "rtbRemarks";
            this.rtbRemarks.Size = new System.Drawing.Size(286, 94);
            this.rtbRemarks.TabIndex = 5;
            // 
            // radLabel5
            // 
            this.radLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radLabel5.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.radLabel5.Location = new System.Drawing.Point(81, 148);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(68, 29);
            this.radLabel5.TabIndex = 4;
            this.radLabel5.Text = "备注：";
            // 
            // dlistMember
            // 
            this.dlistMember.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dlistMember.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.dlistMember.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dlistMember.Location = new System.Drawing.Point(214, 66);
            this.dlistMember.Name = "dlistMember";
            this.dlistMember.Size = new System.Drawing.Size(286, 31);
            this.dlistMember.TabIndex = 12;
            // 
            // AddRecharge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 377);
            this.Controls.Add(this.dlistMember);
            this.Controls.Add(this.rtbRemarks);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.rbCancel);
            this.Controls.Add(this.rbSave);
            this.Controls.Add(this.rtbAmount);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "AddRecharge";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员充值";
            this.Load += new System.EventHandler(this.AddRecharge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rtbRemarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dlistMember)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox rtbAmount;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadButton rbSave;
        private Telerik.WinControls.UI.RadButton rbCancel;
        private Telerik.WinControls.UI.RadTextBox rtbRemarks;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadDropDownList dlistMember;

    }
}