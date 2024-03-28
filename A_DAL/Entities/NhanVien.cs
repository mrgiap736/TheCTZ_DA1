using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class NhanVien
{
    public string MaNhanVien { get; set; } = null!;

    public string TenNhanVien { get; set; } = null!;

    public string ChucVu { get; set; } = null!;

    public string? TaiKhoan { get; set; }

    public string? MatKhau { get; set; }

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
