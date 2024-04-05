namespace C_PRL.UI
{
    partial class Form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DangNhap));
            label1 = new Label();
            tbx_usn = new TextBox();
            btn_DangNhap = new Button();
            tbx_pass = new TextBox();
            label2 = new Label();
            pn_iconus = new Panel();
            pn_passicon = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(120, 58);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 25);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // tbx_usn
            // 
            tbx_usn.Location = new Point(120, 86);
            tbx_usn.Margin = new Padding(4, 4, 4, 4);
            tbx_usn.Name = "tbx_usn";
            tbx_usn.PlaceholderText = "Nhập tài khoản";
            tbx_usn.Size = new Size(380, 31);
            tbx_usn.TabIndex = 1;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.FromArgb(255, 128, 0);
            btn_DangNhap.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangNhap.ForeColor = Color.White;
            btn_DangNhap.Location = new Point(234, 225);
            btn_DangNhap.Margin = new Padding(4, 4, 4, 4);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(138, 50);
            btn_DangNhap.TabIndex = 2;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // tbx_pass
            // 
            tbx_pass.Location = new Point(120, 168);
            tbx_pass.Margin = new Padding(4, 4, 4, 4);
            tbx_pass.Name = "tbx_pass";
            tbx_pass.PasswordChar = '*';
            tbx_pass.PlaceholderText = "Nhập mật khẩu";
            tbx_pass.Size = new Size(380, 31);
            tbx_pass.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(120, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // pn_iconus
            // 
            pn_iconus.BackColor = Color.Transparent;
            pn_iconus.BackgroundImage = (Image)resources.GetObject("pn_iconus.BackgroundImage");
            pn_iconus.BackgroundImageLayout = ImageLayout.Stretch;
            pn_iconus.ForeColor = SystemColors.ActiveCaptionText;
            pn_iconus.Location = new Point(75, 86);
            pn_iconus.Margin = new Padding(4, 4, 4, 4);
            pn_iconus.Name = "pn_iconus";
            pn_iconus.Size = new Size(38, 34);
            pn_iconus.TabIndex = 5;
            // 
            // pn_passicon
            // 
            pn_passicon.BackColor = Color.Transparent;
            pn_passicon.BackgroundImage = (Image)resources.GetObject("pn_passicon.BackgroundImage");
            pn_passicon.BackgroundImageLayout = ImageLayout.Stretch;
            pn_passicon.Location = new Point(75, 168);
            pn_passicon.Margin = new Padding(4, 4, 4, 4);
            pn_passicon.Name = "pn_passicon";
            pn_passicon.Size = new Size(38, 34);
            pn_passicon.TabIndex = 6;
            // 
            // Form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(602, 316);
            Controls.Add(pn_passicon);
            Controls.Add(pn_iconus);
            Controls.Add(tbx_pass);
            Controls.Add(label2);
            Controls.Add(btn_DangNhap);
            Controls.Add(tbx_usn);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Form_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbx_usn;
        private Button btn_DangNhap;
        private TextBox tbx_pass;
        private Label label2;
        private Panel pn_iconus;
        private Panel pn_passicon;
    }
}