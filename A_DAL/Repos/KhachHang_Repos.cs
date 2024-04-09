using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
    public class KhachHang_Repos : IKhachHang_Repos
    {
        SqlTheCtzContext context;
        public KhachHang_Repos()
        {
            context = new SqlTheCtzContext();
        }
        public bool AddKH(KhachHang kh)
        {
            context.Add(kh);
            context.SaveChanges();
            return true;
        }

        public List<KhachHang> GetAll()
        {
            return context.KhachHangs.ToList();
        }

        public bool RemoveKH(KhachHang kh)
        {
            context.Remove(kh);
            context.SaveChanges();
            return true;
        }

        public KhachHang SearchByPhone(string phone)
        {
            return context.KhachHangs.FirstOrDefault(x => x.SoDienThoai == phone);
        }

        public bool UpdateKH(KhachHang kh)
        {
            context.Update(kh);
            context.SaveChanges();
            return true;
        }
    }
}
