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
            grb_ThongTin = new GroupBox();
            comboBox1 = new ComboBox();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            grb_DanhSach = new GroupBox();
            dtg_HienThi = new DataGridView();
            pn_Btn_Them = new Panel();
            pn_Btn_Sua = new Panel();
            pn_Btn_Load = new Panel();
            pn_Btn_Xoa = new Panel();
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            button1 = new Button();
            pn_Form_NhanVien.SuspendLayout();
            grb_ThongTin.SuspendLayout();
            grb_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_HienThi).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pn_Form_NhanVien
            // 
            pn_Form_NhanVien.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_NhanVien.Controls.Add(groupBox1);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Xoa);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Load);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Sua);
            pn_Form_NhanVien.Controls.Add(pn_Btn_Them);
            pn_Form_NhanVien.Controls.Add(grb_DanhSach);
            pn_Form_NhanVien.Controls.Add(grb_ThongTin);
            pn_Form_NhanVien.Location = new Point(215, 60);
            pn_Form_NhanVien.Name = "pn_Form_NhanVien";
            pn_Form_NhanVien.Size = new Size(1689, 912);
            pn_Form_NhanVien.TabIndex = 0;
            // 
            // grb_ThongTin
            // 
            grb_ThongTin.Controls.Add(comboBox1);
            grb_ThongTin.Controls.Add(textBox5);
            grb_ThongTin.Controls.Add(label5);
            grb_ThongTin.Controls.Add(textBox4);
            grb_ThongTin.Controls.Add(label4);
            grb_ThongTin.Controls.Add(label3);
            grb_ThongTin.Controls.Add(textBox2);
            grb_ThongTin.Controls.Add(label2);
            grb_ThongTin.Controls.Add(textBox1);
            grb_ThongTin.Controls.Add(label1);
            grb_ThongTin.Location = new Point(27, 21);
            grb_ThongTin.Name = "grb_ThongTin";
            grb_ThongTin.Size = new Size(592, 329);
            grb_ThongTin.TabIndex = 11;
            grb_ThongTin.TabStop = false;
            grb_ThongTin.Text = "Thông tin nhân viên";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(174, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(331, 28);
            comboBox1.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(174, 243);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(331, 27);
            textBox5.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 246);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 18;
            label5.Text = "Mật khẩu:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(174, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(331, 27);
            textBox4.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 200);
            label4.Name = "label4";
            label4.Size = new Size(74, 20);
            label4.TabIndex = 16;
            label4.Text = "Tài khoản:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 152);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 15;
            label3.Text = "Chức  vụ:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(174, 103);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(331, 27);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 106);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 13;
            label2.Text = "Tên nhân viên:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(174, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(331, 27);
            textBox1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 62);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 11;
            label1.Text = "Mã nhân viên:";
            // 
            // grb_DanhSach
            // 
            grb_DanhSach.Controls.Add(dtg_HienThi);
            grb_DanhSach.Location = new Point(673, 21);
            grb_DanhSach.Name = "grb_DanhSach";
            grb_DanhSach.Size = new Size(978, 329);
            grb_DanhSach.TabIndex = 12;
            grb_DanhSach.TabStop = false;
            grb_DanhSach.Text = "Danh sách nhân viên";
            // 
            // dtg_HienThi
            // 
            dtg_HienThi.BackgroundColor = Color.White;
            dtg_HienThi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_HienThi.Location = new Point(6, 26);
            dtg_HienThi.Name = "dtg_HienThi";
            dtg_HienThi.RowHeadersWidth = 51;
            dtg_HienThi.RowTemplate.Height = 29;
            dtg_HienThi.Size = new Size(966, 297);
            dtg_HienThi.TabIndex = 0;
            // 
            // pn_Btn_Them
            // 
            pn_Btn_Them.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Them.Location = new Point(156, 411);
            pn_Btn_Them.Name = "pn_Btn_Them";
            pn_Btn_Them.Size = new Size(147, 41);
            pn_Btn_Them.TabIndex = 13;
            // 
            // pn_Btn_Sua
            // 
            pn_Btn_Sua.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Sua.Location = new Point(385, 411);
            pn_Btn_Sua.Name = "pn_Btn_Sua";
            pn_Btn_Sua.Size = new Size(147, 41);
            pn_Btn_Sua.TabIndex = 14;
            // 
            // pn_Btn_Load
            // 
            pn_Btn_Load.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Load.Location = new Point(765, 411);
            pn_Btn_Load.Name = "pn_Btn_Load";
            pn_Btn_Load.Size = new Size(147, 41);
            pn_Btn_Load.TabIndex = 15;
            // 
            // pn_Btn_Xoa
            // 
            pn_Btn_Xoa.BackColor = Color.FromArgb(255, 255, 192);
            pn_Btn_Xoa.Location = new Point(981, 411);
            pn_Btn_Xoa.Name = "pn_Btn_Xoa";
            pn_Btn_Xoa.Size = new Size(147, 41);
            pn_Btn_Xoa.TabIndex = 16;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Location = new Point(1166, 356);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(485, 107);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 26);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(473, 27);
            textBox3.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(203, 67);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 971);
            Controls.Add(pn_Form_NhanVien);
            Name = "Form_NhanVien";
            Text = "Form_NhanVien";
            pn_Form_NhanVien.ResumeLayout(false);
            grb_ThongTin.ResumeLayout(false);
            grb_ThongTin.PerformLayout();
            grb_DanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_HienThi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_NhanVien;
        private GroupBox grb_ThongTin;
        private ComboBox comboBox1;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox4;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private Panel pn_Btn_Xoa;
        private Panel pn_Btn_Load;
        private Panel pn_Btn_Sua;
        private Panel pn_Btn_Them;
        private GroupBox grb_DanhSach;
        private DataGridView dtg_HienThi;
        private GroupBox groupBox1;
        private Button button1;
        private TextBox textBox3;
    }
}