using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_PRL.UI
{
    public partial class Form_KhachHang : Form
    {
        public Form_KhachHang()
        {
            InitializeComponent();
        }

        public List<Control> GetCtrl()
        {
            List<Control> ctrls = new List<Control>();

            foreach (Control ctrl in pn_Form_KhachHang.Controls)
            {
                ctrls.Add(ctrl);
            }
            return ctrls;
        }
    }
}
