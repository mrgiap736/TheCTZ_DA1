namespace C_PRL.UI
{
	partial class Form_TrangChu
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
            pn_DSChucNang = new Panel();
            pn_HienThiChiTiet = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            pn_DSChucNang.SuspendLayout();
            SuspendLayout();
            // 
            // pn_DSChucNang
            // 
            pn_DSChucNang.BackColor = Color.FromArgb(255, 255, 192);
            pn_DSChucNang.Controls.Add(button1);
            pn_DSChucNang.Location = new Point(0, 0);
            pn_DSChucNang.Name = "pn_DSChucNang";
            pn_DSChucNang.Size = new Size(215, 674);
            pn_DSChucNang.TabIndex = 0;
            // 
            // pn_HienThiChiTiet
            // 
            pn_HienThiChiTiet.BackColor = Color.FromArgb(255, 128, 128);
            pn_HienThiChiTiet.Location = new Point(215, 0);
            pn_HienThiChiTiet.Name = "pn_HienThiChiTiet";
            pn_HienThiChiTiet.Size = new Size(1047, 125);
            pn_HienThiChiTiet.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 255, 255);
            panel1.Location = new Point(215, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 549);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(3, 136);
            button1.Name = "button1";
            button1.Size = new Size(209, 45);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form_TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(panel1);
            Controls.Add(pn_HienThiChiTiet);
            Controls.Add(pn_DSChucNang);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Form_TrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form_TrangChu";
            Load += Form_TrangChu_Load;
            pn_DSChucNang.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_DSChucNang;
		private Panel pn_HienThiChiTiet;
		private Panel panel1;
        private Button button1;
    }
}