using A_DAL.Entities;
using B_BUS.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
		public Form_TrangChu()
		{

			InitializeComponent();

			bhsv = new BanHang_Services();
			hdsv = new HoaDon_Services();
			ctsv = new ChiTietHD_Services();

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
					dtg_HoaDonCho.Rows.Add(item.MaHoaDon, item.MaKhachHang, trangthai, item.TongTien, item.TienKhachTra, item.GiamGia);
				}
			}

		}


		//Thêm sản phẩm vào giỏ hàng 

		private void dtg_DSsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
		{

			int rowIndex = e.RowIndex;
			if (dtg_DSsanpham.SelectedRows.Count > 1)
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

			if (dtg_HoaDonCho.SelectedRows.Count > 1 || dtg_HoaDonCho.Rows[rowIndex].Cells[0].Value == null)
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

			idGHindex = dtg_GioHang.Rows[rowIndex].Cells[0].Value.ToString();

			if (dtg_GioHang.SelectedRows.Count > 1 || dtg_GioHang.Rows[rowIndex].Cells[0].Value == null)
			{
				return;
			}
			{

			}
		}


		//Hàm tính tổng tiền 
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

		//Hàm chuyển số ngăn cách phần nghìn 
		public static string AddThousandSeparators(int number)
		{
			// Chuyển đổi số sang chuỗi và sử dụng phương thức Format để thêm dấu chấm ngăn cách
			string formattedNumber = string.Format("{0:N0}", number);

			return formattedNumber;
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


		//Nut tạo hóa đơn

		private void pn_BtnTaoHoaDon_Click(object sender, EventArgs e)
		{
			int makhachhang = 1; //Tạm thời chưa sửa
			string manhanvien = "NV1"; //Tạm thời chưa sửa 
			DateTime ngaymua = DateTime.Now;

			int tongtien = TinhTongTien();

			int tienkhachtra = Convert.ToInt32(tbx_TienKhachTra.Text);

			int giamgia = Convert.ToInt32(tbx_Giamgia.Text);

			int trangthai = 0;

			if (!ValidateHD(makhachhang, manhanvien, ngaymua, tongtien, trangthai))
			{
				return;
			}
			{
				HoaDon hd = new HoaDon(makhachhang, manhanvien, ngaymua, tongtien, tienkhachtra, giamgia, trangthai);


				hdsv.TaoHoaDon(hd);

				//ChiTietHoaDon cthd = new ChiTietHoaDon();

				//ctsv.TaoChiTietHoaDon(cthd);
				dtg_GioHang.Rows.Clear();
				LoadGrid(bhsv.GetAllSanPham());


			}


		}

		public bool ValidateHD(int b, string c, DateTime d, int e, int f)
		{
			//
			//b - ma khach hang
			//c - ma nhan vien
			//d - ngay mua
			//e - tong tien
			//f - trang thai


			bool check = true;
			//

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
			int makhachhang = 1; //Tạm thời chưa sửa
			string manhanvien = "NV1"; //Tạm thời chưa sửa 
			DateTime ngaymua = DateTime.Now;

			int tongtien = TinhTongTien();

			int tienkhachtra = Convert.ToInt32(tbx_TienKhachTra.Text);

			int giamgia = Convert.ToInt32(tbx_Giamgia.Text);

			int trangthai = 1;

			if (!ValidateHD(makhachhang, manhanvien, ngaymua, tongtien, trangthai))
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
				}
				else
				{
					hdsv.CapNhatHoaDon(idUpdate, tienkhachtra, giamgia, tongtien, trangthai);
					MessageBox.Show("Thanh toán thành công");
				}


				dtg_GioHang.Rows.Clear();
				LoadGrid(bhsv.GetAllSanPham());
			}
		}


		#endregion



		#region sự kiện textbox
		private void tbx_TienKhachTra_TextChanged(object sender, EventArgs e)
		{
			int tienthua = 0;
			if (!int.TryParse(tbx_TienKhachTra.Text, out int tienKhachTra) || tienKhachTra > 999999999)
			{
				tbx_TienKhachTra.Text = "";
			}

			if (int.TryParse(tbx_TienKhachTra.Text, out tienKhachTra))
			{
				int tongTien;
				if (int.TryParse(lb_TongTien.Text, out tongTien))
				{
					tienthua = tienKhachTra - tongTien;
				}

			}

			if (tienthua < 0)
			{
				tienthua = 0;
			}

			lb_TienThua.Text = AddThousandSeparators(tienthua);
		}

		//Sự kiện giảm giá 
		private void tbx_Giamgia_TextChanged(object sender, EventArgs e)
		{

			int tongtien = TinhTongTien();

			lb_TongTien.Text = AddThousandSeparators(tongtien);

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
		private void tbx_TienKhachTra_Click(object sender, EventArgs e)
		{
			tbx_TienKhachTra.SelectAll();
		}

		private void tbx_Giamgia_Click(object sender, EventArgs e)
		{
			tbx_Giamgia.SelectAll();
		}

		#endregion

	}
}
