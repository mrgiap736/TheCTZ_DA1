using System;
using System.Collections.Generic;

namespace A_DAL.Entities;

public partial class SanPham
{
    public string MaSanPham { get; set; } = null!;

    public string TenSanPham { get; set; } = null!;

    public string HangSanXuat { get; set; } = null!;

    public string? ThongSoKyThuat { get; set; }

    public int GiaNhap { get; set; }

    public int GiaBan { get; set; }

    public int TrangThai { get; set; }
    public byte[]? HinhAnh { get; set; } // Thêm thuộc tính HinhAnh

    public byte[]? Hinhanh { get; set; }

    public virtual ICollection<ChiTietHoaDon> ChiTietHoaDons { get; set; } = new List<ChiTietHoaDon>();
}
