using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class SanPham
{
    public string MaSanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public string HangSanXuat { get; set; } = null!;

    public string? ThongSoKyThuat { get; set; }

    public int Gia { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}
