using A_DAL.Entities;
using A_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
    public class BanHang_Services
    {
        SanPham_Repos sprp;

        public BanHang_Services()
        {
            sprp = new SanPham_Repos();
        }

        public List<SanPham> GetAllSanPham()
        {
            return sprp.GetAll();
        }
    }
}
