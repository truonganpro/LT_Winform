namespace Quan_ly_quan_an
{
    partial class frmTaiKhoan
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
            this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.btnThemTaiKhoan = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.btnDatLaiMatKhau = new System.Windows.Forms.Button();
            this.panel22 = new System.Windows.Forms.Panel();
            this.nmrLoaiTaiKhoan = new System.Windows.Forms.NumericUpDown();
            this.txtLoaiTaiKhoan = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.txtTenHienThi = new System.Windows.Forms.TextBox();
            this.lblTenHienThi = new System.Windows.Forms.Label();
            this.panel24 = new System.Windows.Forms.Panel();
            this.txtTenTaiKhoan = new System.Windows.Forms.TextBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLoaiTaiKhoan)).BeginInit();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dtgvTaiKhoan);
            this.panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(31, 68);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 426);
            this.panel3.TabIndex = 4;
            // 
            // dtgvTaiKhoan
            // 
            this.dtgvTaiKhoan.AllowDrop = true;
            this.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.DisplayName,
            this.Type});
            this.dtgvTaiKhoan.Location = new System.Drawing.Point(3, 10);
            this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
            this.dtgvTaiKhoan.RowHeadersWidth = 51;
            this.dtgvTaiKhoan.RowTemplate.Height = 24;
            this.dtgvTaiKhoan.Size = new System.Drawing.Size(482, 411);
            this.dtgvTaiKhoan.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "UserName";
            this.UserName.HeaderText = "Tên tài khoản";
            this.UserName.MinimumWidth = 6;
            this.UserName.Name = "UserName";
            // 
            // DisplayName
            // 
            this.DisplayName.DataPropertyName = "DisplayName";
            this.DisplayName.HeaderText = "Tên hiển thị";
            this.DisplayName.MinimumWidth = 6;
            this.DisplayName.Name = "DisplayName";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Loại tài khoản";
            this.Type.MinimumWidth = 6;
            this.Type.Name = "Type";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnLuu);
            this.panel5.Controls.Add(this.btnSuaTaiKhoan);
            this.panel5.Controls.Add(this.btnXoaTaiKhoan);
            this.panel5.Controls.Add(this.btnThemTaiKhoan);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.Location = new System.Drawing.Point(34, 521);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(497, 72);
            this.panel5.TabIndex = 5;
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.BackColor = System.Drawing.Color.Ivory;
            this.btnSuaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaTaiKhoan.Image = global::Quan_ly_quan_an.Properties.Resources.update;
            this.btnSuaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(255, 9);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(112, 38);
            this.btnSuaTaiKhoan.TabIndex = 0;
            this.btnSuaTaiKhoan.Text = "Sửa";
            this.btnSuaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.BackColor = System.Drawing.Color.Ivory;
            this.btnXoaTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaTaiKhoan.Image = global::Quan_ly_quan_an.Properties.Resources.delete;
            this.btnXoaTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(127, 9);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(112, 38);
            this.btnXoaTaiKhoan.TabIndex = 0;
            this.btnXoaTaiKhoan.Text = "Xóa";
            this.btnXoaTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = false;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // btnThemTaiKhoan
            // 
            this.btnThemTaiKhoan.BackColor = System.Drawing.Color.Ivory;
            this.btnThemTaiKhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemTaiKhoan.Image = global::Quan_ly_quan_an.Properties.Resources._;
            this.btnThemTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemTaiKhoan.Location = new System.Drawing.Point(0, 9);
            this.btnThemTaiKhoan.Name = "btnThemTaiKhoan";
            this.btnThemTaiKhoan.Size = new System.Drawing.Size(112, 38);
            this.btnThemTaiKhoan.TabIndex = 0;
            this.btnThemTaiKhoan.Text = "Thêm";
            this.btnThemTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemTaiKhoan.UseVisualStyleBackColor = false;
            this.btnThemTaiKhoan.Click += new System.EventHandler(this.btnThemTaiKhoan_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(565, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "QUẢN LÝ THÔNG TIN TÀI KHOẢN";
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.btnDatLaiMatKhau);
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.panel23);
            this.panel21.Controls.Add(this.panel24);
            this.panel21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel21.Location = new System.Drawing.Point(534, 202);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(369, 338);
            this.panel21.TabIndex = 12;
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.BackColor = System.Drawing.Color.Ivory;
            this.btnDatLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLaiMatKhau.Image = global::Quan_ly_quan_an.Properties.Resources.refresh;
            this.btnDatLaiMatKhau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(102, 205);
            this.btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(186, 42);
            this.btnDatLaiMatKhau.TabIndex = 0;
            this.btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.nmrLoaiTaiKhoan);
            this.panel22.Controls.Add(this.txtLoaiTaiKhoan);
            this.panel22.Location = new System.Drawing.Point(13, 133);
            this.panel22.Margin = new System.Windows.Forms.Padding(4);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(333, 56);
            this.panel22.TabIndex = 2;
            // 
            // nmrLoaiTaiKhoan
            // 
            this.nmrLoaiTaiKhoan.Location = new System.Drawing.Point(160, 16);
            this.nmrLoaiTaiKhoan.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmrLoaiTaiKhoan.Name = "nmrLoaiTaiKhoan";
            this.nmrLoaiTaiKhoan.Size = new System.Drawing.Size(157, 30);
            this.nmrLoaiTaiKhoan.TabIndex = 1;
            // 
            // txtLoaiTaiKhoan
            // 
            this.txtLoaiTaiKhoan.AutoSize = true;
            this.txtLoaiTaiKhoan.Location = new System.Drawing.Point(14, 21);
            this.txtLoaiTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtLoaiTaiKhoan.Name = "txtLoaiTaiKhoan";
            this.txtLoaiTaiKhoan.Size = new System.Drawing.Size(139, 25);
            this.txtLoaiTaiKhoan.TabIndex = 0;
            this.txtLoaiTaiKhoan.Text = "Loại tài khoản:";
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.txtTenHienThi);
            this.panel23.Controls.Add(this.lblTenHienThi);
            this.panel23.Location = new System.Drawing.Point(13, 69);
            this.panel23.Margin = new System.Windows.Forms.Padding(4);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(333, 56);
            this.panel23.TabIndex = 2;
            // 
            // txtTenHienThi
            // 
            this.txtTenHienThi.Location = new System.Drawing.Point(160, 16);
            this.txtTenHienThi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenHienThi.Name = "txtTenHienThi";
            this.txtTenHienThi.Size = new System.Drawing.Size(157, 30);
            this.txtTenHienThi.TabIndex = 1;
            // 
            // lblTenHienThi
            // 
            this.lblTenHienThi.AutoSize = true;
            this.lblTenHienThi.Location = new System.Drawing.Point(14, 21);
            this.lblTenHienThi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenHienThi.Name = "lblTenHienThi";
            this.lblTenHienThi.Size = new System.Drawing.Size(120, 25);
            this.lblTenHienThi.TabIndex = 0;
            this.lblTenHienThi.Text = "Tên hiển thị:";
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.txtTenTaiKhoan);
            this.panel24.Controls.Add(this.lblTenTaiKhoan);
            this.panel24.Location = new System.Drawing.Point(13, 5);
            this.panel24.Margin = new System.Windows.Forms.Padding(4);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(333, 56);
            this.panel24.TabIndex = 1;
            // 
            // txtTenTaiKhoan
            // 
            this.txtTenTaiKhoan.Location = new System.Drawing.Point(160, 16);
            this.txtTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenTaiKhoan.Name = "txtTenTaiKhoan";
            this.txtTenTaiKhoan.Size = new System.Drawing.Size(157, 30);
            this.txtTenTaiKhoan.TabIndex = 1;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(15, 21);
            this.lblTenTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(137, 25);
            this.lblTenTaiKhoan.TabIndex = 0;
            this.lblTenTaiKhoan.Text = "Tên tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(562, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Loại tài khoản = 1 : Quản trị viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(562, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(270, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Loại tài khoản = 0 : Nhân viên";
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Ivory;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = global::Quan_ly_quan_an.Properties.Resources.save2;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(382, 9);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(112, 40);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(885, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel22.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrLoaiTaiKhoan)).EndInit();
            this.panel23.ResumeLayout(false);
            this.panel23.PerformLayout();
            this.panel24.ResumeLayout(false);
            this.panel24.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button btnThemTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button btnDatLaiMatKhau;
        private System.Windows.Forms.Panel panel22;
        private System.Windows.Forms.NumericUpDown nmrLoaiTaiKhoan;
        private System.Windows.Forms.Label txtLoaiTaiKhoan;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.TextBox txtTenHienThi;
        private System.Windows.Forms.Label lblTenHienThi;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.TextBox txtTenTaiKhoan;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.Button btnLuu;
    }
}