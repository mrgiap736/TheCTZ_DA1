﻿using A_DAL.Data;
using A_DAL.Entities;
using B_BUS.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_PRL.UI
{
    public partial class Form_TrangChu : Form
    {
        BanHang_Services bhsv;
        HoaDon_Services hdsv;
        KhachHang_Services khsv;
        ChiTietHD_Services ctsv;

        public Form_TrangChu(NhanVien? nv)
        {

            InitializeComponent();

            bhsv = new BanHang_Services();
            hdsv = new HoaDon_Services();
            ctsv = new ChiTietHD_Services();
            khsv = new KhachHang_Services();

            GetCtrl();

            LoadCBX1();
            LoadCBX2();

            //Lấy mã nhân viên từ tk pw đăng nhập vào app

            if (nv == null)
            {
                nvien = null;
            }
            else nvien = nv;

        }
        NhanVien nvien;

        KhachHang kHang;

        private void PhanQuyen_NhanVien(NhanVien nvien)
        {
            if(nvien.ChucVu.Equals("Nhân viên"))
            {
                pn_NhanVien.Click -= pn_NhanVien_Click;

                foreach (Control item in pn_NhanVien.Controls)
                {
                    item.Click -= pn_NhanVien_Click;

                    item.Click += NotClick;
                }


            }
        }
        //Su kien thong bao nhan vien k dc phep su dung chuc nang
        private void NotClick(object sender, EventArgs e)
        {
            MessageBox.Show("Nhân viên không thể sử dụng chức năng này !");
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

            Form_SanPham form = new Form_SanPham(nvien);

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

            Form_KhachHang form = new Form_KhachHang(nvien);

            foreach (var item in form.Gekhtrl())
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


        #region Load data
        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            //Phân quyền chức năng trước khi thao tác
            PhanQuyen_NhanVien(nvien);
            //
            //
             
            if (nvien == null)
            {
                lb_NameNV.Text = "Đang bảo trì";
            }
            else lb_NameNV.Text = nvien.TenNhanVien;

            LoadGrid(bhsv.GetAllSanPham());

            tbx_TienKhachTra.Click += tbx_Click;
            tbx_Giamgia.Click += tbx_Click;

            tbx_TienKhachTra.LostFocus += tbx_LostFocus;
            tbx_Giamgia.LostFocus += tbx_LostFocus;

            foreach (DataGridViewColumn column in dtg_GioHang.Columns)
            {
                column.ReadOnly = true;
            }

        }

        //Hàm clear tb
        public void ClearInput()
        {
            cbx_Filter1.SelectedIndex = 0;
            cbx_Filter2.SelectedIndex = 0;

            tbx_Search.Text = "";
            tbx_TienKhachTra.Text = "0";
            tbx_GhiChu.Text = "";
            tbx_SDTkh.Text = "";
            dtg_GioHang.Rows.Clear();

            lb_TenKH.Text = "...";
            lb_TichLuy.Text = "...";
        }

        //Load du lieu cho 2 combobox
        public void LoadCBX1()
        {
            cbx_Filter1.Items.Add("Tất cả");

            //Tự động chọn item 0 (tất cả)
            cbx_Filter1.SelectedIndex = 0;
        }
        public void LoadCBX2()
        {
            cbx_Filter2.Items.Add("Tất cả");
            cbx_Filter2.Items.Add("Dưới 1 triệu");
            cbx_Filter2.Items.Add("Từ 1 triệu đến 10 triệu");
            cbx_Filter2.Items.Add("Từ 10 triệu đến 50 triệu");
            cbx_Filter2.Items.Add("Trên 50 triệu");

            //Tự động chọn item 0 (tất cả)
            cbx_Filter2.SelectedIndex = 0;
        }

        private void LoadGioHang(dynamic data)
        {
            //Xóa dữ liệu trước khi thêm
            dtg_GioHang.Rows.Clear();

            foreach (var item in data)
            {
                int sttGH = dtg_GioHang.Rows.Count;
                dtg_GioHang.Rows.Add(item.MaSanPhamNavigation.MaSanPham, sttGH++, item.MaSanPhamNavigation.TenSanPham, item.SoLuong, item.DonGia);
            }
        }

        public void LoadGrid(dynamic data)
        {
            dtg_DSsanpham.Rows.Clear();
            dtg_HoaDonCho.Rows.Clear();

            //Tạo cột cho ds sản phẩm 
            dtg_DSsanpham.ColumnCount = 7;

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
            dtg_DSsanpham.Columns[4].HeaderText = "Giá bán";

            dtg_DSsanpham.Columns[5].Name = "trangthai";
            dtg_DSsanpham.Columns[5].HeaderText = "Trạng thái";

            dtg_DSsanpham.Columns[6].Name = "Id";
            dtg_DSsanpham.Columns[6].Visible = false;

            //Tạo cột cho giỏ hàng
            dtg_GioHang.ColumnCount = 5;

            dtg_GioHang.Columns[0].Name = "Id";
            dtg_GioHang.Columns[0].Visible = false;

            dtg_GioHang.Columns[1].Name = "stt";
            dtg_GioHang.Columns[1].HeaderText = "STT";
            dtg_GioHang.Columns[1].Width = 40;

            dtg_GioHang.Columns[2].Name = "ten";
            dtg_GioHang.Columns[2].HeaderText = "Tên sản phẩm";

            dtg_GioHang.Columns[3].Name = "soluong";
            dtg_GioHang.Columns[3].HeaderText = "Số lượng";
            dtg_GioHang.Columns[3].Width = 40;
            dtg_GioHang.Columns[3].ReadOnly = false;


            dtg_GioHang.Columns[4].Name = "dongia";
            dtg_GioHang.Columns[4].HeaderText = "Đơn giá";

            //Tạo cột cho hóa đơn chờ 
            dtg_HoaDonCho.ColumnCount = 6;

            dtg_HoaDonCho.Columns[0].Name = "Id";
            dtg_HoaDonCho.Columns[0].HeaderText = "Mã";
            dtg_HoaDonCho.Columns[0].Width = 40;

            dtg_HoaDonCho.Columns[1].Name = "NameKH";
            dtg_HoaDonCho.Columns[1].HeaderText = "Tên khách hàng";


            dtg_HoaDonCho.Columns[2].Name = "tt";
            dtg_HoaDonCho.Columns[2].HeaderText = "Trạng thái";

            dtg_HoaDonCho.Columns[3].Name = "tongtien";
            dtg_HoaDonCho.Columns[3].Visible = false;

            dtg_HoaDonCho.Columns[4].Name = "tienkhachtra";
            dtg_HoaDonCho.Columns[4].Visible = false;

            dtg_HoaDonCho.Columns[5].Name = "giamgia";
            dtg_HoaDonCho.Columns[5].Visible = false;

            //Thêm dữ liệu vào ds sản phẩm
            //stt
            int stt = 1;
            foreach (var item in data)
            {
                dtg_DSsanpham.Rows.Add(stt++, item.TenSanPham, item.HangSanXuat, item.ThongSoKyThuat, item.GiaBan, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng", item.MaSanPham);
            }


            //Thêm dữ liệu vào hóa đơn chờ 
            foreach (var item in hdsv.GetAllHoaDon())
            {
                if (item.TrangThai == 0)
                {
                    string trangthai = "Chưa thanh toán";
                    dtg_HoaDonCho.Rows.Add(item.MaHoaDon, item.MaKhachHangNavigation.TenKhachHang, trangthai, item.TongTien, item.TienKhachTra, item.GiamGia);
                }
            }

        }


        #endregion


        #region Sự kiện cell click
        //Thêm sản phẩm vào giỏ hàng 
        private void dtg_DSsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            if (dtg_DSsanpham.SelectedRows.Count > 1 || e.RowIndex < 0)
            {
                return;
            }
            else
            {

                if (dtg_DSsanpham.Rows[rowIndex].Selected)
                {
                    if (dtg_DSsanpham.Rows[rowIndex].Cells[0].Value == null)
                    {
                        return;
                    }
                    else
                    {
                        if (dtg_DSsanpham.Rows[rowIndex].Cells[5].Value == "Hết hàng")
                        {
                            MessageBox.Show("Sản phẩm đang hết hàng !");
                            return;
                        }
                        else
                        {
                            string id = dtg_DSsanpham.Rows[rowIndex].Cells[6].Value.ToString();
                            string name = dtg_DSsanpham.Rows[rowIndex].Cells[1].Value.ToString();
                            string dongia = dtg_DSsanpham.Rows[rowIndex].Cells[4].Value.ToString();
                            int soluong = 1;
                            bool check = true;
                            var list = dtg_GioHang.Rows;
                            for (int i = 0; i < list.Count; i++)
                            {
                                if (list[i].Cells[0].Value != null && list[i].Cells[0].Value.ToString() == id)
                                {
                                    list[i].Cells[3].Value = Convert.ToInt32(list[i].Cells[3].Value) + 1;
                                    check = false;
                                }

                            }
                            if (check)
                            {
                                int sttGH = dtg_GioHang.Rows.Count;
                                dtg_GioHang.Rows.Add(id, sttGH++, name, soluong, dongia);
                            }

                            lb_TongTien.Text = AddThousandSeparators(TinhTongTien());

                        }
                    }
                }
            }

        }

        //Cell click hóa đơn chờ 
        private void dtg_HoaDonCho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (dtg_HoaDonCho.Rows.Count <= 1)
            {
                if (dtg_HoaDonCho.SelectedRows.Count <= 1)
                {
                    return;
                }
            }

            if (dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value == null || e.RowIndex < 0)
            {
                return;
            }
            else
            {
                idUpdate = Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value);

                tbx_TienKhachTra.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[4].Value.ToString();
                tbx_Giamgia.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[5].Value.ToString();
                lb_TongTien.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[3].Value.ToString();

                string nameKH_search = dtg_HoaDonCho.Rows[rowIndex].Cells[1].Value.ToString();

                //Load lại sản phẩm trong giỏ hàng của hóa đơn đó 
                LoadGioHang(ctsv.GetAllCTHoaDon(idUpdate));

                //Lấy dữ liệu khách hàng từ tên khách hàng
                kHang = khsv.Search_KH_By_Name(nameKH_search);

                tbx_SDTkh.Text = kHang.SoDienThoai;
                lb_TenKH.Text = kHang.TenKhachHang;
                lb_TichLuy.Text = kHang.TichLuy.ToString();


                int tienthua = Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[4].Value) - Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[3].Value);

                if (tienthua < 0)
                {
                    tienthua = 0;
                }

                lb_TienThua.Text = tienthua.ToString();
            }
        }


        //Cell click giỏ hàng
        string idGHindex;
        private void dtg_GioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;


            if (e.RowIndex < 0 || dtg_GioHang.SelectedRows.Count > 1 || dtg_GioHang.Rows[rowIndex].Cells[0].Value == null)
            {
                return;
            }
            {
                idGHindex = dtg_GioHang.Rows[rowIndex].Cells[0].Value.ToString();
            }
        }


        #endregion


        #region Các hàm xử lý logic 
        //Hàm tính tổng tiền sau khi giam gia
        public int TinhTongTien()
        {

            int kq = 0;
            int SauKhiGiamGia = 0;
            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[3].Value != null && item.Cells[4].Value != null)
                {
                    kq = kq + (Convert.ToInt32(item.Cells[4].Value) * Convert.ToInt32(item.Cells[3].Value));
                }

            }

            if (int.TryParse(tbx_Giamgia.Text, out int giamgia))
            {
                SauKhiGiamGia = kq - (kq / 100 * giamgia);
            }


            return SauKhiGiamGia;

        }

        //Tính các loại tiền để gán cho các sự kiện textchanged
        public void TinhAllTien()
        {
            int tongtien = TinhTongTien();
            int tienthua = 0;

            string tienKhachTraStr = tbx_TienKhachTra.Text.Replace(",", ""); // Loại bỏ dấu phẩy từ chuỗi

            //Nếu đầu vào không phải số return
            if (!int.TryParse(tienKhachTraStr, out int tienKhachTra) || tienKhachTra > 999999999)
            {
                tbx_TienKhachTra.Text = "";
            }

            if (int.TryParse(tienKhachTraStr, out tienKhachTra))
            {
                tienthua = tienKhachTra - tongtien; //tính tiền thừa cho khách 
            }

            if (tienthua < 0)
            {
                tienthua = 0;
            }

            //Thêm dấu phảy ngăn cách phần nghìn 
            lb_TongTien.Text = AddThousandSeparators(tongtien);
            lb_TienThua.Text = AddThousandSeparators(tienthua);



        }

        //Hàm chuyển số ngăn cách phần nghìn 
        public static string AddThousandSeparators(int number)
        {
            // Chuyển đổi số sang chuỗi và sử dụng phương thức Format để thêm dấu chấm ngăn cách
            string formattedNumber = string.Format("{0:N0}", number);

            return formattedNumber;
        }

        //Hàm tìm kiếm khách hàng
        //Lấy mã khách hàng để tạo hóa đơn  
        int maKH = 0;
        public void SearchCustomer()
        {
            kHang = bhsv.GetKhachHang(tbx_SDTkh.Text);

            if (kHang != null)
            {
                lb_TenKH.Text = kHang.TenKhachHang;
                lb_TichLuy.Text = kHang.TichLuy.ToString();
                maKH = kHang.MaKhachHang;
            }
            else
            {
                return;
            }
        }

        //Hàm validate dữ liệu đầu vào tạo hóa đơn 
        public bool ValidateTaoHD(int makh, int tienkhachtra, int tongtien)
        {
            bool check = true;
            //
            if (dtg_GioHang.Rows.Count == 1)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn !");
                check = false;
            }
            else if (makh == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng !");
                check = false;
            }
            else if (tienkhachtra == 0)
            {
                MessageBox.Show("Chưa nhập số tiền khách trả !");
                check = false;
            }
            else
            {
                if (tienkhachtra < tongtien)
                {
                    MessageBox.Show("Số tiền khách gửi không đủ !");
                    check = false;
                }
            }
            //
            return check;
        }

        //Hàm validate dữ liệu đầu vào tạo hóa đơn chờ
        public bool ValidateTaoHDCho(int makh)
        {
            bool check = true;
            //
            if (dtg_GioHang.Rows.Count == 1)
            {
                MessageBox.Show("Không có sản phẩm nào được chọn !");
                check = false;
            }
            else if (makh == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng !");
                check = false;
            }
            //
            return check;
        }

        //Hàm thanh toán (Tạo hóa đơn)
        public void ThanhToan()
        {
            //Lấy dữ liệu
            int makhachhang = maKH;
            string manhanvien = nvien.MaNhanVien;
            DateTime ngaymua = DateTime.Now;

            int tongtien = TinhTongTien();

            int tienkhachtra = Convert.ToInt32(tbx_TienKhachTra.Text.Replace(",",""));

            int giamgia = Convert.ToInt32(tbx_Giamgia.Text);

            int trangthai = 1;

            if (!ValidateTaoHD(makhachhang, tienkhachtra, tongtien))
            {
                return;
            }
            {
                bool check = true;
                foreach (var item in hdsv.GetAllHoaDon())
                {
                    if (item.MaHoaDon == idUpdate)
                    {
                        check = false;
                    }
                }

                if (check)
                {
                    HoaDon hd = new HoaDon(makhachhang, manhanvien, ngaymua, tongtien, tienkhachtra, giamgia, trangthai);
                    hdsv.TaoHoaDon(hd);
                    AddHDChiTiet(hd.MaHoaDon);
                    MessageBox.Show("Thanh toán thành công");

                    //cập nhật tích lũy cho khách hàng
                    kHang.TichLuy = kHang.TichLuy + tongtien / 100000;
                    khsv.Update(kHang);

                    //Xoa du lieu input
                    ClearInput();
                }
                else
                {

                    //Thanh toán hóa đơn chờ
                    hdsv.CapNhatHoaDon(idUpdate, tienkhachtra, giamgia, tongtien);
                    UpdateHDChiTiet();
                    MessageBox.Show("Thanh toán thành công");

                    //cập nhật tích lũy cho khách hàng
                    int? tichluymoi;
                    if (tbx_Giamgia.Text == "0")
                    {
                        //nếu khách hàng mua không giảm giá thì tích lũy
                        tichluymoi = kHang.TichLuy + tongtien / 100000;
                        kHang.TichLuy = tichluymoi;

                    }
                    else
                    {
                        //nếu khách hàng mua với giảm giá thì không tích lũy và trừ bớt điểm tích lũy đang có
                        tichluymoi = kHang.TichLuy - Convert.ToInt32(tbx_Giamgia.Text);
                        kHang.TichLuy = tichluymoi;
                    }

                    khsv.Update(kHang);

                    //Xoa du lieu input
                    ClearInput();
                }


                dtg_GioHang.Rows.Clear();
                LoadGrid(bhsv.GetAllSanPham());
            }
        }

        //Hàm tạo hóa đơn chờ (Tạo hóa đơn)
        public void TaoHoaDonCho()
        {
            int makhachhang = maKH;
            string manhanvien = nvien.MaNhanVien;
            DateTime ngaymua = DateTime.Now;

            int tongtien = TinhTongTien();

            int tienkhachtra = 0;

            int giamgia = 0;

            int trangthai = 0;

            if (!ValidateTaoHDCho(makhachhang))
            {
                return;
            }
            {
                HoaDon hdonUpdate = hdsv.GetHD(idUpdate);
                if (hdonUpdate != null)
                {
                    UpdateHDChiTiet();
                }
                else
                {
                    HoaDon hd = new HoaDon(makhachhang, manhanvien, ngaymua, tongtien, tienkhachtra, giamgia, trangthai);
                    hdsv.TaoHoaDon(hd);
                    AddHDChiTiet(hd.MaHoaDon);
                }

                //

                LoadGrid(bhsv.GetAllSanPham());
                ClearInput();
            }
        }

        //Hàm tạo chi tiết hóa đơn (được gọi sau khi tạo hóa đơn)
        public void AddHDChiTiet(int mahd)
        {
            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    ChiTietHoaDon ctHoaDon = new ChiTietHoaDon();
                    ctHoaDon.MaHoaDon = mahd;
                    ctHoaDon.MaSanPham = item.Cells[0].Value.ToString();
                    ctHoaDon.SoLuong = Convert.ToInt32(item.Cells[3].Value);
                    ctHoaDon.DonGia = Convert.ToInt32(item.Cells[4].Value);

                    ctsv.TaoChiTietHoaDon(ctHoaDon);
                }
            }
        }

        //Hàm update chi tiết hóa đơn (được gọi sau khi thanh toán hóa đơn chờ)
        public void UpdateHDChiTiet()
        {

            foreach (var item in ctsv.GetAllCTHoaDon(idUpdate).ToList())
            {
                bool foundInCart = false;
                foreach (DataGridViewRow row in dtg_GioHang.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (item.MaSanPham == row.Cells[0].Value.ToString())
                        {
                            // Cập nhật số lượng
                            item.SoLuong = Convert.ToInt32(row.Cells[3].Value);
                            ctsv.UpdateCTHoaDon(item);
                            foundInCart = true;
                            break;
                        }
                    }
                }

                // Xóa nếu không còn tồn tại trong giỏ hàng
                if (!foundInCart)
                {
                    ctsv.DeleteSPChiTietHoaDon(item);
                }
            }

            // Tạo mới nếu không tồn tại trong hóa đơn
            foreach (DataGridViewRow row in dtg_GioHang.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    bool foundInOrder = false;
                    foreach (var item in ctsv.GetAllCTHoaDon(idUpdate))
                    {
                        if (item.MaSanPham == row.Cells[0].Value.ToString())
                        {
                            foundInOrder = true;
                            break;
                        }
                    }

                    if (!foundInOrder)
                    {
                        ChiTietHoaDon ctHoaDon = new ChiTietHoaDon();
                        ctHoaDon.MaHoaDon = idUpdate;
                        ctHoaDon.MaSanPham = row.Cells[0].Value.ToString();
                        ctHoaDon.SoLuong = Convert.ToInt32(row.Cells[3].Value);
                        ctHoaDon.DonGia = Convert.ToInt32(row.Cells[4].Value);

                        ctsv.TaoChiTietHoaDon(ctHoaDon);
                    }
                }
            }
        }


        #endregion


        #region các nút 

        //Nut xoa sp
        private void pn_BtnXoaSP_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow item in dtg_GioHang.Rows)
            {
                if (item.Cells[0].Value == idGHindex)
                {
                    dtg_GioHang.Rows.Remove(item);
                }
            }

            lb_TongTien.Text = AddThousandSeparators(TinhTongTien());
        }

        //nut xoa gio hang
        private void pn_BtnXoaGioHang_Click(object sender, EventArgs e)
        {
            dtg_GioHang.Rows.Clear();
            lb_TongTien.Text = AddThousandSeparators(TinhTongTien());
        }

        //Nut tạo hóa đơn
        private void pn_BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDonCho();
        }


        //Nút cập nhật
        private void pn_BtnCapNhat_Click(object sender, EventArgs e)
        {
            LoadGrid(bhsv.GetAllSanPham());
        }


        //Nút thanh toán
        int idUpdate;
        private void pn_buttonThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan();
        }


        #endregion


        #region sự kiện textbox
        private void tbx_TienKhachTra_TextChanged(object sender, EventArgs e)
        {
            TinhAllTien();

            string text = tbx_TienKhachTra.Text.Replace(",", "");
            int tien;

            if (text == "" || text == "0")
            {
                return;
            }
            else
            {
                tien = Convert.ToInt32(text);
            }

            if(tien > 500000000)
            {
                tbx_TienKhachTra.Text = "0";
            }

            tbx_TienKhachTra.Text = AddThousandSeparators(tien);

            tbx_TienKhachTra.SelectionStart = tbx_TienKhachTra.Text.Length;         
        }

        //Sự kiện giảm giá 
        private void tbx_Giamgia_TextChanged(object sender, EventArgs e)
        {
            TinhAllTien();
        }

        //Sự kiện tìm kiếm khách hàng theo số điện thoại
        private void tbx_SDTkh_TextChanged(object sender, EventArgs e)
        {
            SearchCustomer();
        }

        //Chỉ được nhập số 
        private void tbx_TienKhachTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void tbx_Giamgia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        private void tbx_SDTkh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự được nhập vào TextBox
            }
        }

        //Click 
        private void tbx_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            // Kiểm tra nếu TextBox đã được chọn (đã bôi đen)
            if (textBox.SelectionLength > 0)
            {
                // Nếu đã bôi đen, xóa bôi đen
                textBox.SelectionLength = 0;
            }

            textBox.Text = "";
        }
        //Focus
        private void tbx_LostFocus(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;

            if (textBox.Text == "")
            {
                textBox.Text = "0";
            }
        }

        //su kien tim kiem san pham theo ten
        private void tbx_Search_TextChanged(object sender, EventArgs e)
        {
            LoadGrid(bhsv.GetSPByName(tbx_Search.Text));
        }

        #endregion


        #region Sự kiện combobox
        private void cbx_Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadGrid(bhsv.GetSPByPrice(cbx_Filter2.SelectedIndex));
        }

        #endregion


        #region Sự kiện thay đổi giá trị cell 

        //Thay đổi số lượng mua thì cập nhật tổng giá tiền
        private void dtg_GioHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            TinhAllTien();
        }

        #endregion


        #region Sự kiện cell content click 
        private void dtg_GioHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            dtg_GioHang.Rows[index].Cells[3].ReadOnly = false;
        }

        #endregion
    }
}
