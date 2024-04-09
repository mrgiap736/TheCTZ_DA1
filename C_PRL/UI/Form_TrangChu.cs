using A_DAL.Entities;
using B_BUS.Services;
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

namespace C_PRL.UI
{
    public partial class Form_TrangChu : Form
    {
        BanHang_Services bhsv;
        HoaDon_Services hdsv;
        ChiTietHD_Services ctsv;
        public Form_TrangChu(NhanVien? nv)
        {

            InitializeComponent();

            bhsv = new BanHang_Services();
            hdsv = new HoaDon_Services();
            ctsv = new ChiTietHD_Services();

            GetCtrl();

            LoadCBX1();
            LoadCBX2();

            //Lấy mã nhân viên từ tk pw đăng nhập vào app

            if(nv == null)
            {
                nvien = null;
            }
            else nvien = nv;

        }
        NhanVien nvien;

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

        private void Form_TrangChu_Load(object sender, EventArgs e)
        {
            if(nvien == null)
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

            if (dtg_HoaDonCho.SelectedRows.Count > 1 || dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value == null || e.RowIndex < 0)
            {
                return;
            }
            else
            {
                idUpdate = Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value);

                tbx_TienKhachTra.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[4].Value.ToString();
                tbx_Giamgia.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[5].Value.ToString();
                lb_TongTien.Text = dtg_HoaDonCho.Rows[rowIndex].Cells[3].Value.ToString();

                int tienthua = Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[4].Value) - Convert.ToInt32(dtg_HoaDonCho.Rows[rowIndex].Cells[3].Value);

                if (tienthua < 0)
                {
                    tienthua = 0;
                }

                lb_TienThua.Text = tienthua.ToString();
            }
        }


        //Click giỏ hàng
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
            KhachHang kh = bhsv.GetKhachHang(tbx_SDTkh.Text);

            if (kh != null)
            {
                lb_TenKH.Text = kh.TenKhachHang;
                lb_TichLuy.Text = kh.TichLuy.ToString();
                maKH = kh.MaKhachHang;
            }
            else
            {

                return;
            }
        }






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

        //Hàm thanh toán
        public void ThanhToan()
        {
            //Lấy dữ liệu
            int makhachhang = maKH;
            string manhanvien = nvien.MaNhanVien;
            DateTime ngaymua = DateTime.Now;

            int tongtien = TinhTongTien();

            int tienkhachtra = Convert.ToInt32(tbx_TienKhachTra.Text);

            int giamgia = Convert.ToInt32(tbx_Giamgia.Text);

            int trangthai = 1;

            if (!ValidateHD(makhachhang, tienkhachtra, tongtien, trangthai))
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
                    MessageBox.Show("Thanh toán thành công");
                    ClearInput();
                }
                else
                {
                    hdsv.CapNhatHoaDon(idUpdate, tienkhachtra, giamgia, tongtien);
                    MessageBox.Show("Thanh toán thành công");
                    ClearInput();
                }


                dtg_GioHang.Rows.Clear();
                LoadGrid(bhsv.GetAllSanPham());
            }
        }

        //Hàm tạo hóa đơn chờ
        public void TaoHoaDonCho()
        {
            int makhachhang = maKH;
            string manhanvien = nvien.MaNhanVien;
            DateTime ngaymua = DateTime.Now;

            int tongtien = TinhTongTien();

            int tienkhachtra = Convert.ToInt32(tbx_TienKhachTra.Text);

            int giamgia = Convert.ToInt32(tbx_Giamgia.Text);

            int trangthai = 0;

            if (!ValidateHD(makhachhang, tienkhachtra, tongtien, trangthai))
            {
                return;
            }
            {
                HoaDon hd = new HoaDon(makhachhang, manhanvien, ngaymua, tongtien, tienkhachtra, giamgia, trangthai);


                hdsv.TaoHoaDon(hd);

                //ChiTietHoaDon cthd = new ChiTietHoaDon();

                //ctsv.TaoChiTietHoaDon(cthd);  //Chua su dung den

                LoadGrid(bhsv.GetAllSanPham());
                ClearInput();
            }
        }

        //Nut tạo hóa đơn
        private void pn_BtnTaoHoaDon_Click(object sender, EventArgs e)
        {
            TaoHoaDonCho();
        }

        public bool ValidateHD(int makh, int tienkhachtra, int tongtien, int f)
        {
            //b - ma khach hang
            //e - tong tien
            //f - trang thai


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
            TextBox textBox = (TextBox)sender;

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
            TextBox textBox = (TextBox)sender;

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


    }
}
