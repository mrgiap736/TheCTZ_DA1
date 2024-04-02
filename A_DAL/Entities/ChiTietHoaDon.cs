using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class ChiTietHoaDon
{
    public string MaChiTietHoaDon { get; set; } = null!;

    public int? MaHoaDon { get; set; }

    public string DanhSachSanPham { get; set; } = null!;

    public virtual HoaDon? MaHoaDonNavigation { get; set; }
}
