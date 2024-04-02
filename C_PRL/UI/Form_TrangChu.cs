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







			//Thêm dữ liệu vào ds sản phẩm
			//stt
			int stt = 1;
			foreach (var item in data)
			{
				dtg_DSsanpham.Rows.Add(stt++, item.TenSanPham, item.HangSanXuat, item.ThongSoKyThuat, item.GiaBan, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng", item.MaSanPham);
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

						}
					}
				}
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
		}

		//nut xoa gio hang
		private void pn_BtnXoaGioHang_Click(object sender, EventArgs e)
		{
			dtg_GioHang.Rows.Clear();
		}


		//Nut tạo hóa đơn
		private void pn_BtnTaoHoaDon_Click(object sender, EventArgs e)
		{

		}






		//Nút cập nhật
		private void pn_BtnCapNhat_Click(object sender, EventArgs e)
		{
			LoadGrid(bhsv.GetAllSanPham());
		}

		//Nút thanh toán
		private void pn_buttonThanhToan_Click(object sender, EventArgs e)
		{

		}


		#endregion


		
	}
}
