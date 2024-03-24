using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class HoaDon
{
    public string MaHoaDon { get; set; } = null!;

    public int? MaKhachHang { get; set; }

    public string? MaNhanVien { get; set; }

    public DateTime NgayMua { get; set; }

    public int TongTien { get; set; }

    public int? TrangThai { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();

    public virtual KhachHang? MaKhachHangNavigation { get; set; }

    public virtual NhanVien? MaNhanVienNavigation { get; set; }
}
