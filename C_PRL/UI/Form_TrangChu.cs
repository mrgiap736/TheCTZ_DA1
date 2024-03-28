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
		}

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
				dtg_DSsanpham.Rows.Add(stt++,item.TenSanPham, item.HangSanXuat, item.ThongSoKyThuat, item.Gia);
			}

        }
	}
}
