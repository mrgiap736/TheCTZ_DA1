using A_DAL.Entities;
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
    public partial class Form_HoaDon : Form
    {
        HoaDon_Services hdsv;
        ChiTietHD_Services ctsv;
        public Form_HoaDon()
        {
            InitializeComponent();
            hdsv = new HoaDon_Services();

        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        public List<Control> GetCtrl()
        {
            List<Control> ctrls = new List<Control>();

            foreach (Control ctrl in pn_Form_HoaDon.Controls)
            {
                ctrls.Add(ctrl);
            }
            return ctrls;
        }

        public void LoadGrid()
        {
            //Load cac cot cho hoa don
            dtg_DSHoaDon.ColumnCount = 8;

            dtg_DSHoaDon.Columns[0].Name = "stt";
            dtg_DSHoaDon.Columns[0].HeaderText = "STT";

            dtg_DSHoaDon.Columns[1].Name = "mahoadon";
            dtg_DSHoaDon.Columns[1].HeaderText = "Mã HĐ";

            dtg_DSHoaDon.Columns[2].Name = "tenkhachhang";
            dtg_DSHoaDon.Columns[2].HeaderText = "Tên khách hàng";

            dtg_DSHoaDon.Columns[3].Name = "tennhanvien";
            dtg_DSHoaDon.Columns[3].HeaderText = "Tên nhân viên";

            dtg_DSHoaDon.Columns[4].Name = "tongtien";
            dtg_DSHoaDon.Columns[4].HeaderText = "Tổng giá tiền";

            dtg_DSHoaDon.Columns[5].Name = "tienkhachtra";
            dtg_DSHoaDon.Columns[5].HeaderText = "Tiền khách trả";

            dtg_DSHoaDon.Columns[6].Name = "giamgia";
            dtg_DSHoaDon.Columns[6].HeaderText = "Giảm giá";

            dtg_DSHoaDon.Columns[7].Name = "trangthai";
            dtg_DSHoaDon.Columns[7].HeaderText = "Trạng thái";


            //load data cho hoa don
            int stt = 0;
            foreach (HoaDon item in hdsv.GetAllHoaDon())
            {
                dtg_DSHoaDon.Rows.Add(stt++, item.MaHoaDon, item.MaKhachHangNavigation.TenKhachHang, item.MaNhanVienNavigation.TenNhanVien, item.TongTien, item.TienKhachTra, item.TrangThai);
            }


            ////load cac cot cho hoa don chi tiet
            //dtg_DSHoaDonCT.ColumnCount = 6;

            //dtg_DSHoaDonCT.Columns[0].Name = "stt";
            //dtg_DSHoaDonCT.Columns[0].HeaderText = "STT";

        }

       
    }
}
