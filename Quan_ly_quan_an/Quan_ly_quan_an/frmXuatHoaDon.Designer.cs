namespace Quan_ly_quan_an
{
    partial class frmXuatHoaDon
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
            this.reportXuatHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportXuatHoaDon
            // 
            this.reportXuatHoaDon.ActiveViewIndex = -1;
            this.reportXuatHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportXuatHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportXuatHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportXuatHoaDon.Location = new System.Drawing.Point(0, 0);
            this.reportXuatHoaDon.Name = "reportXuatHoaDon";
            this.reportXuatHoaDon.Size = new System.Drawing.Size(800, 450);
            this.reportXuatHoaDon.TabIndex = 0;
            // 
            // frmXuatHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportXuatHoaDon);
            this.Name = "frmXuatHoaDon";
            this.Text = "frmXuatHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportXuatHoaDon;
    }
}