namespace C_PRL.UI
{
    partial class Form_NhanVien
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
            pn_Form_NhanVien = new Panel();
            groupBox1 = new GroupBox();
            txt_Search = new TextBox();
            pn_Btn_Xoa = new Panel();
            label9 = new Label();
            pn_Btn_LamMoi = new Panel();
            label8 = new Label();
            pn_Btn_Sua = new Panel();
            label7 = new Label();
            pn_Btn_Them = new Panel();
            label6 = new Label();
            grb_DanhSach = new GroupBox();
            dtgView = new DataGridView();
            grb_ThongTin = new GroupBox();
            Cmb_ChucVu = new ComboBox();
            txt_MatKhau = new TextBox();
            label5 = new Label();
            txt_TaiKhoan = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txt_TenNV = new TextBox();
            label2 = new Label();
            txt_MaNV = new TextBox();
            label1 = new Label();
            pn_Form_NhanVien.SuspendLayout();
            groupBox1.SuspendLayout();
            pn_Btn_Xoa.SuspendLayout();
            pn_Btn_LamMoi.SuspendLayout();
            pn_Btn_Sua.SuspendLayout();
            pn_Btn_Them.SuspendLayout();
            grb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            grb_ThongTin.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Form_NhanVien
            // 
            pn_Form_NhanVien.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_NhanVien.Controls.Add(groupBox1);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Xoa);
            pn_Form_NhanVien.Controls.Add(pn_Btn_LamMoi);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Sua);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Them);
            pn_Form_NhanVien.Controls.Add(grb_DanhSach);
            pn_Form_NhanVien.Controls.Add(grb_ThongTin);
            pn_Form_NhanVien.Location = new Point(269, 75);
            pn_Form_NhanVien.Margin = new Padding(4);
            pn_Form_NhanVien.Name = "pn_Form_NhanVien";
            pn_Form_NhanVien.Size = new Size(2111, 1140);
            pn_Form_NhanVien.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Search);
            groupBox1.Location = new Point(1441, 456);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4);
            groupBox1.Size = new Size(606, 98);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm";
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(8, 32);
            txt_Search.Margin = new Padding(4);
            txt_Search.Name = "txt_Search";
            txt_Search.PlaceholderText = "Mời nhập tên nhân viên muốn tìm?";
            txt_Search.Size = new Size(590, 31);
            txt_Search.TabIndex = 0;
            txt_Search.TextChanged += txt_Search_TextChanged;
            // 
            // pn_Btn_Xoa
            // 
            pn_Btn_Xoa.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Xoa.Controls.Add(label9);
            pn_Btn_Xoa.Location = new Point(1232, 479);
            pn_Btn_Xoa.Margin = new Padding(4);
            pn_Btn_Xoa.Name = "pn_Btn_Xoa";
            pn_Btn_Xoa.Size = new Size(184, 51);
            pn_Btn_Xoa.TabIndex = 16;
            pn_Btn_Xoa.Click += pn_Btn_Xoa_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(28, 15);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 24;
            label9.Text = "Xoá nhân viên";
            label9.Click += label9_Click;
            // 
            // pn_Btn_LamMoi
            // 
            pn_Btn_LamMoi.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_LamMoi.Controls.Add(label8);
            pn_Btn_LamMoi.Location = new Point(962, 479);
            pn_Btn_LamMoi.Margin = new Padding(4);
            pn_Btn_LamMoi.Name = "pn_Btn_LamMoi";
            pn_Btn_LamMoi.Size = new Size(184, 51);
            pn_Btn_LamMoi.TabIndex = 15;
            pn_Btn_LamMoi.Click += pn_Btn_LamMoi_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(54, 15);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(81, 25);
            label8.TabIndex = 23;
            label8.Text = "Làm mới";
            label8.Click += label8_Click;
            // 
            // pn_Btn_Sua
            // 
            pn_Btn_Sua.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Sua.Controls.Add(label7);
            pn_Btn_Sua.Location = new Point(487, 479);
            pn_Btn_Sua.Margin = new Padding(4);
            pn_Btn_Sua.Name = "pn_Btn_Sua";
            pn_Btn_Sua.Size = new Size(184, 51);
            pn_Btn_Sua.TabIndex = 14;
            pn_Btn_Sua.Click += pn_Btn_Sua_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 15);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(151, 25);
            label7.TabIndex = 22;
            label7.Text = "Update nhân viên";
            label7.Click += label7_Click;
            // 
            // pn_Btn_Them
            // 
            pn_Btn_Them.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Them.Controls.Add(label6);
            pn_Btn_Them.Location = new Point(201, 479);
            pn_Btn_Them.Margin = new Padding(4);
            pn_Btn_Them.Name = "pn_Btn_Them";
            pn_Btn_Them.Size = new Size(184, 51);
            pn_Btn_Them.TabIndex = 13;
            pn_Btn_Them.Click += pn_Btn_Them_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 15);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(137, 25);
            label6.TabIndex = 21;
            label6.Text = "Thêm nhân viên";
            label6.Click += label6_Click;
            // 
            // grb_DanhSach
            // 
            grb_DanhSach.Controls.Add(dtgView);
            grb_DanhSach.Location = new Point(841, 26);
            grb_DanhSach.Margin = new Padding(4);
            grb_DanhSach.Name = "grb_DanhSach";
            grb_DanhSach.Padding = new Padding(4);
            grb_DanhSach.Size = new Size(1222, 411);
            grb_DanhSach.TabIndex = 12;
            grb_DanhSach.TabStop = false;
            grb_DanhSach.Text = "Danh sách nhân viên";
            // 
            // dtgView
            // 
            dtgView.BackgroundColor = Color.White;
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(8, 32);
            dtgView.Margin = new Padding(4);
            dtgView.Name = "dtgView";
            dtgView.RowHeadersWidth = 51;
            dtgView.RowTemplate.Height = 29;
            dtgView.Size = new Size(1208, 371);
            dtgView.TabIndex = 0;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // grb_ThongTin
            // 
            grb_ThongTin.Controls.Add(Cmb_ChucVu);
            grb_ThongTin.Controls.Add(txt_MatKhau);
            grb_ThongTin.Controls.Add(label5);
            grb_ThongTin.Controls.Add(txt_TaiKhoan);
            grb_ThongTin.Controls.Add(label4);
            grb_ThongTin.Controls.Add(label3);
            grb_ThongTin.Controls.Add(txt_TenNV);
            grb_ThongTin.Controls.Add(label2);
            grb_ThongTin.Controls.Add(txt_MaNV);
            grb_ThongTin.Controls.Add(label1);
            grb_ThongTin.Location = new Point(34, 26);
            grb_ThongTin.Margin = new Padding(4);
            grb_ThongTin.Name = "grb_ThongTin";
            grb_ThongTin.Padding = new Padding(4);
            grb_ThongTin.Size = new Size(740, 411);
            grb_ThongTin.TabIndex = 11;
            grb_ThongTin.TabStop = false;
            grb_ThongTin.Text = "Thông tin nhân viên";
            // 
            // Cmb_ChucVu
            // 
            Cmb_ChucVu.BackColor = SystemColors.ButtonHighlight;
            Cmb_ChucVu.ForeColor = Color.Black;
            Cmb_ChucVu.Items.AddRange(new object[] { "Admin", "Nhân Viên" });
            Cmb_ChucVu.Location = new Point(218, 186);
            Cmb_ChucVu.Margin = new Padding(4);
            Cmb_ChucVu.Name = "Cmb_ChucVu";
            Cmb_ChucVu.Size = new Size(413, 33);
            Cmb_ChucVu.TabIndex = 20;
            Cmb_ChucVu.Text = "---Chọn chức vụ---";
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(218, 304);
            txt_MatKhau.Margin = new Padding(4);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(413, 31);
            txt_MatKhau.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 308);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 18;
            label5.Text = "Mật khẩu:";
            // 
            // txt_TaiKhoan
            // 
            txt_TaiKhoan.Location = new Point(218, 246);
            txt_TaiKhoan.Margin = new Padding(4);
            txt_TaiKhoan.Name = "txt_TaiKhoan";
            txt_TaiKhoan.Size = new Size(413, 31);
            txt_TaiKhoan.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 250);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(90, 25);
            label4.TabIndex = 16;
            label4.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 190);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 25);
            label3.TabIndex = 15;
            label3.Text = "Chức  vụ:";
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(218, 129);
            txt_TenNV.Margin = new Padding(4);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(413, 31);
            txt_TenNV.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 132);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 13;
            label2.Text = "Tên nhân viên:";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(218, 74);
            txt_MaNV.Margin = new Padding(4);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(413, 31);
            txt_MaNV.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(60, 78);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 25);
            label1.TabIndex = 11;
            label1.Text = "Mã nhân viên:";
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1050);
            Controls.Add(pn_Form_NhanVien);
            Margin = new Padding(4);
            Name = "Form_NhanVien";
            Text = "Form_NhanVien";
            pn_Form_NhanVien.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pn_Btn_Xoa.ResumeLayout(false);
            pn_Btn_Xoa.PerformLayout();
            pn_Btn_LamMoi.ResumeLayout(false);
            pn_Btn_LamMoi.PerformLayout();
            pn_Btn_Sua.ResumeLayout(false);
            pn_Btn_Sua.PerformLayout();
            pn_Btn_Them.ResumeLayout(false);
            pn_Btn_Them.PerformLayout();
            grb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            grb_ThongTin.ResumeLayout(false);
            grb_ThongTin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_NhanVien;
        private GroupBox grb_ThongTin;
        private ComboBox Cmb_ChucVu;
        private TextBox txt_MatKhau;
        private Label label5;
        private TextBox txt_TaiKhoan;
        private Label label4;
        private Label label3;
        private TextBox txt_TenNV;
        private Label label2;
        private TextBox txt_MaNV;
        private Label label1;
        private Panel pn_Btn_Xoa;
        private Panel pn_Btn_LamMoi;
        private Panel pn_Btn_Sua;
        private Panel pn_Btn_Them;
        private GroupBox grb_DanhSach;
        private DataGridView dtgView;
        private GroupBox groupBox1;
        private TextBox txt_Search;
        private Label label7;
        private Label label6;
        private Label label8;
        private Label label9;
    }
}