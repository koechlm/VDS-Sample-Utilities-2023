
namespace VdsSampleUtilities
{
    partial class VdsSampleProgressForm
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
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
            this.lblProgress = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBarControl1
            // 
            this.progressBarControl1.Location = new System.Drawing.Point(12, 31);
            this.progressBarControl1.Name = "progressBarControl1";
            this.progressBarControl1.Size = new System.Drawing.Size(423, 30);
            this.progressBarControl1.TabIndex = 0;
            this.progressBarControl1.ToolTip = "Thank you for your patience.";
            this.progressBarControl1.ToolTipTitle = "VDS-Sample configuration handles valueable data.";
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(12, 12);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(54, 13);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "Progress...";
            // 
            // VdsSampleProgressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 73);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBarControl1);
            this.IconOptions.Image = global::VdsSampleUtilities.Properties.Resources.Vault_Pro;
            this.Name = "VdsSampleProgressForm";
            this.Text = "VDS-Sample-Configuration";
            ((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
        private DevExpress.XtraEditors.LabelControl lblProgress;
    }
}