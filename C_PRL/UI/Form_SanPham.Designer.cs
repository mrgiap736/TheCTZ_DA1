namespace C_PRL.UI
{
    partial class Form_SanPham
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
            pn_Form_SanPham = new Panel();
            SuspendLayout();
            // 
            // pn_Form_SanPham
            // 
            pn_Form_SanPham.BackColor = Color.FromArgb(255, 192, 192);
            pn_Form_SanPham.Location = new Point(215, 60);
            pn_Form_SanPham.Name = "pn_Form_SanPham";
            pn_Form_SanPham.Size = new Size(1689, 912);
            pn_Form_SanPham.TabIndex = 0;
            // 
            // Form_SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 971);
            Controls.Add(pn_Form_SanPham);
            Name = "Form_SanPham";
            Text = "Form_SanPham";
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_SanPham;
    }
}