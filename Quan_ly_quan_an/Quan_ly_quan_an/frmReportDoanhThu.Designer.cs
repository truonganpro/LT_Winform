﻿namespace Quan_ly_quan_an
{
    partial class frmReportDoanhThu
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
            this.reportDoanhThu = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportDoanhThu
            // 
            this.reportDoanhThu.ActiveViewIndex = -1;
            this.reportDoanhThu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportDoanhThu.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.reportDoanhThu.Name = "reportDoanhThu";
            this.reportDoanhThu.Size = new System.Drawing.Size(800, 450);
            this.reportDoanhThu.TabIndex = 0;
            this.reportDoanhThu.Load += new System.EventHandler(this.reportDoanhThu_Load);
            // 
            // frmReportDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportDoanhThu);
            this.Name = "frmReportDoanhThu";
            this.Text = "frmReportDoanhThu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportDoanhThu;
    }
}