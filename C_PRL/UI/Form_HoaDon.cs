﻿using A_DAL.Entities;
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
            ctsv = new ChiTietHD_Services();

            LoadGrid(hdsv.GetAllHoaDon());

            rbt_notpayed.CheckedChanged += rbt_CheckedChanged;
            rbt_payed.CheckedChanged += rbt_CheckedChanged;
        }

        private void Form_HoaDon_Load(object sender, EventArgs e)
        {

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

        public void LoadGrid(dynamic data)
        {
            dtg_DSHoaDon.Rows.Clear();
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
            int stt = 1;
            foreach (HoaDon item in data)
            {
                dtg_DSHoaDon.Rows.Add(stt++, item.MaHoaDon, item.MaKhachHangNavigation.TenKhachHang, item.MaNhanVienNavigation.TenNhanVien, AddThousandSeparators(item.TongTien), AddThousandSeparators(item.TienKhachTra), AddThousandSeparators(Convert.ToInt32(item.GiamGia) * 10000), (item.TrangThai == 0) ? "Chưa thanh toán" : "Đã thanh toán");
            }


            //load cac cot cho hoa don chi tiet
            dtg_DSHoaDonCT.ColumnCount = 6;

            dtg_DSHoaDonCT.Columns[0].Name = "stt";
            dtg_DSHoaDonCT.Columns[0].HeaderText = "STT";

            dtg_DSHoaDonCT.Columns[1].Name = "macthd";
            dtg_DSHoaDonCT.Columns[1].HeaderText = "Mã CTHD";

            dtg_DSHoaDonCT.Columns[2].Name = "mahd";
            dtg_DSHoaDonCT.Columns[2].HeaderText = "Mã HD";

            dtg_DSHoaDonCT.Columns[3].Name = "tensp";
            dtg_DSHoaDonCT.Columns[3].HeaderText = "Tên sản phẩm";

            dtg_DSHoaDonCT.Columns[4].Name = "soluong";
            dtg_DSHoaDonCT.Columns[4].HeaderText = "Số lượng";

            dtg_DSHoaDonCT.Columns[5].Name = "dongia";
            dtg_DSHoaDonCT.Columns[5].HeaderText = "Đơn giá";
        }

        public static string AddThousandSeparators(int number)
        {
            // Chuyển đổi số sang chuỗi và sử dụng phương thức Format để thêm dấu chấm ngăn cách
            string formattedNumber = string.Format("{0:N0}", number);

            return formattedNumber;
        }

        private void dtg_DSHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtg_DSHoaDonCT.Rows.Clear();
            int rowIndex = e.RowIndex;

            //if (e.RowIndex < 0 || dtg_DSHoaDon.Rows[rowIndex].Cells[0].Value == null || dtg_DSHoaDon.RowCount > 1)
            //{
            //    return;
            //}
            //else
            //{
            int mahd = Convert.ToInt32(dtg_DSHoaDon.Rows[rowIndex].Cells[1].Value);
            int stt = 1;
            foreach (ChiTietHoaDon item in ctsv.GetAllCTHoaDon(mahd))
            {
                dtg_DSHoaDonCT.Rows.Add(stt++, item.MaChiTietHoaDon, item.MaHoaDon, item.MaSanPhamNavigation.TenSanPham, item.SoLuong, AddThousandSeparators(item.DonGia));
            }
            //}
        }

        private void tbx_Search_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(hdsv.SearchByNameKH(tbx_Search.Text));
        }

        private void rbt_CheckedChanged(object sender, EventArgs e)
        {
            int tt;
            if(rbt_notpayed.Checked == true)
            {
                tt = 0;
                LoadGrid(hdsv.FilByTT(tt));
            }
            else if(rbt_payed.Checked == true)
            {
                tt = 1;
                LoadGrid(hdsv.FilByTT(tt));
            }
            else if(rbt_all.Checked == true)
            {
                LoadGrid(hdsv.GetAllHoaDon());
            }
        }
    }
}
