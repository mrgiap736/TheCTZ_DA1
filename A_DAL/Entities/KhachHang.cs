using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class KhachHang
{
    public int MaKhachHang { get; set; }

    public string TenKhachHang { get; set; } = null!;

    public string SoDienThoai { get; set; } = null!;

    public virtual ICollection<HoaDon> HoaDons { get; set; } = new List<HoaDon>();
}
