namespace Quan_ly_quan_an
{
    partial class frmBan
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtgvBanAn = new System.Windows.Forms.DataGridView();
            this.Idtable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tablename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSuaBanAn = new System.Windows.Forms.Button();
            this.btnXoaBanAn = new System.Windows.Forms.Button();
            this.btnThemBanAn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.lblTrangThaiBanAn = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txtTenBanAn = new System.Windows.Forms.TextBox();
            this.lblTenBanAn = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtIdBanAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtTrangThai = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvBanAn);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(25, 162);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 426);
            this.panel3.TabIndex = 4;
            // 
            // dtgvBanAn
            // 
            this.dtgvBanAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvBanAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idtable,
            this.Tablename,
            this.Status});
            this.dtgvBanAn.Location = new System.Drawing.Point(3, 15);
            this.dtgvBanAn.Name = "dtgvBanAn";
            this.dtgvBanAn.RowHeadersWidth = 51;
            this.dtgvBanAn.RowTemplate.Height = 24;
            this.dtgvBanAn.Size = new System.Drawing.Size(494, 411);
            this.dtgvBanAn.TabIndex = 0;
            // 
            // Idtable
            // 
            this.Idtable.DataPropertyName = "Idtable";
            this.Idtable.HeaderText = "Mã bàn";
            this.Idtable.MinimumWidth = 6;
            this.Idtable.Name = "Idtable";
            // 
            // Tablename
            // 
            this.Tablename.DataPropertyName = "TableName";
            this.Tablename.HeaderText = "Tên bàn";
            this.Tablename.MinimumWidth = 6;
            this.Tablename.Name = "Tablename";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLuu);
            this.panel5.Controls.Add(this.btnSuaBanAn);
            this.panel5.Controls.Add(this.btnXoaBanAn);
            this.panel5.Controls.Add(this.btnThemBanAn);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(25, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 72);
            this.panel5.TabIndex = 5;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Ivory;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = global::Quan_ly_quan_an.Properties.Resources.save2;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(382, 9);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 38);
            this.btnLuu.TabIndex = 0;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSuaBanAn
            // 
            this.btnSuaBanAn.BackColor = System.Drawing.Color.Ivory;
            this.btnSuaBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaBanAn.Image = global::Quan_ly_quan_an.Properties.Resources.update;
            this.btnSuaBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaBanAn.Location = new System.Drawing.Point(255, 9);
            this.btnSuaBanAn.Name = "btnSuaBanAn";
            this.btnSuaBanAn.Size = new System.Drawing.Size(112, 38);
            this.btnSuaBanAn.TabIndex = 0;
            this.btnSuaBanAn.Text = "Sửa";
            this.btnSuaBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaBanAn.UseVisualStyleBackColor = false;
            this.btnSuaBanAn.Click += new System.EventHandler(this.btnSuaBanAn_Click);
            // 
            // btnXoaBanAn
            // 
            this.btnXoaBanAn.BackColor = System.Drawing.Color.Ivory;
            this.btnXoaBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaBanAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaBanAn.Image = global::Quan_ly_quan_an.Properties.Resources.delete;
            this.btnXoaBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaBanAn.Location = new System.Drawing.Point(127, 9);
            this.btnXoaBanAn.Name = "btnXoaBanAn";
            this.btnXoaBanAn.Size = new System.Drawing.Size(112, 38);
            this.btnXoaBanAn.TabIndex = 0;
            this.btnXoaBanAn.Text = "Xóa";
            this.btnXoaBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaBanAn.UseVisualStyleBackColor = false;
            this.btnXoaBanAn.Click += new System.EventHandler(this.btnXoaBanAn_Click);
            // 
            // btnThemBanAn
            // 
            this.btnThemBanAn.BackColor = System.Drawing.Color.Ivory;
            this.btnThemBanAn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemBanAn.Image = global::Quan_ly_quan_an.Properties.Resources._;
            this.btnThemBanAn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemBanAn.Location = new System.Drawing.Point(0, 9);
            this.btnThemBanAn.Name = "btnThemBanAn";
            this.btnThemBanAn.Size = new System.Drawing.Size(112, 38);
            this.btnThemBanAn.TabIndex = 0;
            this.btnThemBanAn.Text = "Thêm";
            this.btnThemBanAn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemBanAn.UseVisualStyleBackColor = false;
            this.btnThemBanAn.Click += new System.EventHandler(this.btnThemBanAn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ THÔNG TIN BÀN ĂN";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel20);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.panel15);
            this.panel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel11.Location = new System.Drawing.Point(528, 84);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(374, 231);
            this.panel11.TabIndex = 8;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.txtTrangThai);
            this.panel20.Controls.Add(this.lblTrangThaiBanAn);
            this.panel20.Location = new System.Drawing.Point(13, 133);
            this.panel20.Margin = new System.Windows.Forms.Padding(4);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(349, 56);
            this.panel20.TabIndex = 2;
            // 
            // lblTrangThaiBanAn
            // 
            this.lblTrangThaiBanAn.AutoSize = true;
            this.lblTrangThaiBanAn.Location = new System.Drawing.Point(14, 21);
            this.lblTrangThaiBanAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrangThaiBanAn.Name = "lblTrangThaiBanAn";
            this.lblTrangThaiBanAn.Size = new System.Drawing.Size(106, 25);
            this.lblTrangThaiBanAn.TabIndex = 0;
            this.lblTrangThaiBanAn.Text = "Trạng thái:";
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txtTenBanAn);
            this.panel12.Controls.Add(this.lblTenBanAn);
            this.panel12.Location = new System.Drawing.Point(13, 69);
            this.panel12.Margin = new System.Windows.Forms.Padding(4);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(349, 56);
            this.panel12.TabIndex = 2;
            // 
            // txtTenBanAn
            // 
            this.txtTenBanAn.Location = new System.Drawing.Point(138, 21);
            this.txtTenBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenBanAn.Name = "txtTenBanAn";
            this.txtTenBanAn.Size = new System.Drawing.Size(170, 30);
            this.txtTenBanAn.TabIndex = 1;
            // 
            // lblTenBanAn
            // 
            this.lblTenBanAn.AutoSize = true;
            this.lblTenBanAn.Location = new System.Drawing.Point(14, 21);
            this.lblTenBanAn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenBanAn.Name = "lblTenBanAn";
            this.lblTenBanAn.Size = new System.Drawing.Size(118, 25);
            this.lblTenBanAn.TabIndex = 0;
            this.lblTenBanAn.Text = "Tên bàn ăn:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtIdBanAn);
            this.panel15.Controls.Add(this.label2);
            this.panel15.Location = new System.Drawing.Point(13, 5);
            this.panel15.Margin = new System.Windows.Forms.Padding(4);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(349, 56);
            this.panel15.TabIndex = 1;
            // 
            // txtIdBanAn
            // 
            this.txtIdBanAn.Location = new System.Drawing.Point(138, 21);
            this.txtIdBanAn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdBanAn.Name = "txtIdBanAn";
            this.txtIdBanAn.Size = new System.Drawing.Size(170, 30);
            this.txtIdBanAn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Quan_ly_quan_an.Properties.Resources.eat;
            this.pictureBox1.Location = new System.Drawing.Point(597, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Location = new System.Drawing.Point(138, 16);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Size = new System.Drawing.Size(170, 30);
            this.txtTrangThai.TabIndex = 1;
            // 
            // frmBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(903, 662);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBan";
            this.Text = "frmBan";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvBanAn)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel20.PerformLayout();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvBanAn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSuaBanAn;
        private System.Windows.Forms.Button btnXoaBanAn;
        private System.Windows.Forms.Button btnThemBanAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Label lblTrangThaiBanAn;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.TextBox txtTenBanAn;
        private System.Windows.Forms.Label lblTenBanAn;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtIdBanAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tablename;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TextBox txtTrangThai;
    }
}