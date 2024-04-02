using A_DAL.Data;
using A_DAL.Entities;
using A_DAL.IRepos;
using A_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.Repos
{
	public class ChiTietHD_Repos : IChiTietHD_Repos
	{
		SqlTheCtzContext context;

        public ChiTietHD_Repos()
        {
				context = new SqlTheCtzContext();	
        }
        public void Create(ChiTietHoaDon cthd)
		{
			context.ChiTietHoaDons.Add(cthd);
			context.SaveChanges();
			return;
		}

		public List<ChiTietHoaDon> GetAll()
		{
			return context.ChiTietHoaDons.ToList();
		}
	}
}
