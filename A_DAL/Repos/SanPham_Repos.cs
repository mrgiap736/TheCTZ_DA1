using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
    public class SanPham_Repos : ISanPham_Repos
    {
        SqlTheCtzContext context;

        public SanPham_Repos()
        {
            context = new SqlTheCtzContext();
            
        }
        public List<SanPham> GetAll()
        {
            return context.SanPhams.ToList();
        }

		public bool AddSP(SanPham sp)
		{
			context.Add(sp);
			context.SaveChanges();
			return true;
		}


		public bool RemoveSP(SanPham sp)
		{
			context.Remove(sp);
			context.SaveChanges();
			return true;
		}

		public bool UpdateSP(SanPham sp)
		{
			context.Update(sp);
			context.SaveChanges();
			return true;
		}

        public List<SanPham> SearchByName(string name)
        {
            return context.SanPhams.Where(x => x.TenSanPham.ToLower().Contains(name.ToLower().Trim())).ToList();
        }

        public List<SanPham> FilterByPrice(int index)
        {
            int max = 0;
            int min = 0;

            if(index >= 0)
            {
                if(index == 0)
                {
                    return GetAll();
                }

                else if(index == 1)
                {
                    max = 1000000;
                    min = 0;
                }
                else if(index == 2)
                {
                    max = 10000000;
                    min = 1000000;
                }
                else if(index == 3)
                {
                    max = 50000000;
                    min = 10000000;
                }
                else
                {
                    max = int.MaxValue;
                    min = 50000000;
                }

                return context.SanPhams.Where(x => x.GiaBan > min && x.GiaBan < max).ToList();
            }

            return GetAll();
        }

        public List<SanPham> LocTheoHang(int index)
        {
            // Lấy danh sách hãng sản xuất từ cơ sở dữ liệu
            List<string> allManufacturers = GetAllManufacturers();

            // Thực hiện lọc dựa trên chỉ số index
            if (index == 0)
            {
                // Nếu index là 0, trả về tất cả sản phẩm
                return GetAll();
            }
            else if (index > 0 && index <= allManufacturers.Count)
            {
                // Lấy hãng sản xuất dựa trên chỉ số index
                string selectedManufacturer = allManufacturers[index - 1];

                // Lọc sản phẩm theo hãng sản xuất được chọn
                return context.SanPhams.Where(x => x.HangSanXuat == selectedManufacturer).ToList();
            }

            // Nếu index không hợp lệ hoặc không có hãng sản xuất tương ứng, trả về danh sách trống
            return new List<SanPham>();
        }


        public List<string> GetAllManufacturers()
        {
            // Lấy danh sách hãng sản xuất từ cơ sở dữ liệu và sắp xếp chúng theo thứ tự mong muốn
            return context.SanPhams
                .Select(s => s.HangSanXuat)
                .Distinct()
                .OrderBy(h => h) // Sắp xếp danh sách theo thứ tự bảng chữ cái
                .ToList();
        }


        public List<SanPham> FilterByTheFirm(int index)
        {
            throw new NotImplementedException();
        }
    }
}
