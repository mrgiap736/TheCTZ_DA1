using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class ChiTietHoaDon
{
    public int MaChiTietHoaDon { get; set; }

    public int? MaHoaDon { get; set; }

    public string? MaSanPham { get; set; }

    public int SoLuong { get; set; }

    public int DonGia { get; set; }

    public virtual HoaDon? MaHoaDonNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
