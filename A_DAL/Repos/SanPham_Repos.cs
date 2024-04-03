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
	}
}
