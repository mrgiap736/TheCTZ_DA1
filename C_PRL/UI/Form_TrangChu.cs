using B_BUS.Services;
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
    public partial class Form_TrangChu : Form
    {
        BanHang_Services bhsv;
        public Form_TrangChu()
        {

            InitializeComponent();

            bhsv = new BanHang_Services();

            GetCtrl();
        }

        #region chuyển panel


        List<Control> _lstCtrl = new List<Control>();
        public List<Control> GetCtrl()
        {
            foreach (Control item in pn_Form_BanHang.Controls)
            {
                _lstCtrl.Add(item);
            }

            return _lstCtrl;
        }
        private void pn_BanHang_Click(object sender, EventArgs e)
        {
            pn_Form_BanHang.Controls.Clear();

            foreach (Control item in GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(38, 80, 115);

        }

        private void pn_HoaDon_Click(object sender, EventArgs e)
        {
            pn_Form_BanHang.Controls.Clear();

            Form_HoaDon form = new Form_HoaDon();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(38, 80, 115);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_SanPham_Click(object sender, EventArgs e)
        {
            pn_Form_BanHang.Controls.Clear();

            Form_SanPham form = new Form_SanPham();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(38, 80, 115);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_KhachHang_Click(object sender, EventArgs e)
        {
            pn_Form_BanHang.Controls.Clear();

            Form_KhachHang form = new Form_KhachHang();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(38, 80, 115);
            pn_NhanVien.BackColor = Color.FromArgb(45, 149, 150);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
        }

        private void pn_NhanVien_Click(object sender, EventArgs e)
        {
            pn_Form_BanHang.Controls.Clear();

            Form_NhanVien form = new Form_NhanVien();

            foreach (var item in form.GetCtrl())
            {
                pn_Form_BanHang.Controls.Add(item);
            }

            pn_HoaDon.BackColor = Color.FromArgb(45, 149, 150);
            pn_KhachHang.BackColor = Color.FromArgb(45, 149, 150);
            pn_NhanVien.BackColor = Color.FromArgb(38, 80, 115);
            pn_SanPham.BackColor = Color.FromArgb(45, 149, 150);
            pn_BanHang.BackColor = Color.FromArgb(45, 149, 150);
        }
        #endregion

        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            LoadGrid(bhsv.GetAllSanPham());

        }

        public void LoadGrid(dynamic data)
        {
            //dtg_DSsanpham.DataSource = data;

            dtg_DSsanpham.ColumnCount = 5;

            dtg_DSsanpham.Columns[0].Name = "stt";
            dtg_DSsanpham.Columns[0].HeaderText = "STT";
            dtg_DSsanpham.Columns[0].Width = 40;

            dtg_DSsanpham.Columns[1].Name = "ten";
            dtg_DSsanpham.Columns[1].HeaderText = "Tên sản phẩm";

            dtg_DSsanpham.Columns[2].Name = "hang";
            dtg_DSsanpham.Columns[2].HeaderText = "Hãng sản xuất";

            dtg_DSsanpham.Columns[3].Name = "thongso";
            dtg_DSsanpham.Columns[3].HeaderText = "Thông số kĩ thuật";

            dtg_DSsanpham.Columns[4].Name = "gia";
            dtg_DSsanpham.Columns[4].HeaderText = "Giá";

            foreach (var item in data)
            {
                int stt = 0;
                dtg_DSsanpham.Rows.Add(stt++, item.TenSanPham, item.HangSanXuat, item.ThongSoKyThuat, item.Gia);
            }

        }

    }
}
