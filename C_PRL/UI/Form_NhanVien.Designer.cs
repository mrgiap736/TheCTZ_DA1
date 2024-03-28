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
            SuspendLayout();
            // 
            // pn_Form_NhanVien
            // 
            pn_Form_NhanVien.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_NhanVien.Location = new Point(215, 60);
            pn_Form_NhanVien.Name = "pn_Form_NhanVien";
            pn_Form_NhanVien.Size = new Size(1689, 912);
            pn_Form_NhanVien.TabIndex = 0;
            // 
            // Form_NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 971);
            Controls.Add(pn_Form_NhanVien);
            Name = "Form_NhanVien";
            Text = "Form_NhanVien";
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_NhanVien;
    }
}