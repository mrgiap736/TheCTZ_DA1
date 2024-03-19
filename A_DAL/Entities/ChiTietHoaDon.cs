using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class ChiTietHoaDon
{
    public string MaChiTietHoaDon { get; set; } = null!;

    public string? MaHoaDon { get; set; }

    public string? MaSanPham { get; set; }

    public virtual HoaDon? MaHoaDonNavigation { get; set; }

    public virtual SanPham? MaSanPhamNavigation { get; set; }
}
