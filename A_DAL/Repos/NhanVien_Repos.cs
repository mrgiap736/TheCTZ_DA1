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
    public class NhanVien_Repos : INhanVien_Repos
    {
        SqlTheCtzContext context;

        public NhanVien_Repos()
        {
            context = new SqlTheCtzContext();
        }

        public List<NhanVien> GetAll()
        {
            return context.NhanViens.ToList();
        }
    }
}
