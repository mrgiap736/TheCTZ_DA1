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
            textBox1 = new TextBox();
            btn_DangNhap = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(96, 46);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 0;
            label1.Text = "Tài khoản";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(96, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(305, 27);
            textBox1.TabIndex = 1;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.BackColor = Color.FromArgb(255, 128, 0);
            btn_DangNhap.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DangNhap.ForeColor = Color.White;
            btn_DangNhap.Location = new Point(196, 181);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(110, 40);
            btn_DangNhap.TabIndex = 2;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(96, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(305, 27);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.White;
            label2.Location = new Point(96, 111);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu";
            // 
            // Form_DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(482, 253);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(btn_DangNhap);
            Controls.Add(textBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form_DangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btn_DangNhap;
        private TextBox textBox2;
        private Label label2;
    }
}