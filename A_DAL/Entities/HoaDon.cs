using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class HoaDon
{
    public HoaDon(int? maKhachHang, string? maNhanVien, DateTime ngayMua, int tongTien, int tienKhachTra, int? giamGia, int trangThai)
    {
        MaKhachHang = maKhachHang;
        MaNhanVien = maNhanVien;
        NgayMua = ngayMua;
        TongTien = tongTien;
        TienKhachTra = tienKhachTra;
        GiamGia = giamGia;
        TrangThai = trangThai;
    }

    public int MaHoaDon { get; set; }

    public int? MaKhachHang { get; set; }

    public string? MaNhanVien { get; set; }

    public DateTime NgayMua { get; set; }

    public int TongTien { get; set; }

    public int TienKhachTra { get; set; }

    public int? GiamGia { get; set; }

    public int TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? MaKhachHangNavigation { get; set; }

    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
