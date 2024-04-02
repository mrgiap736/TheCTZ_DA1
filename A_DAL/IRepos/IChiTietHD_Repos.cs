using A_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepos
{
	public interface IChiTietHD_Repos
	{
		public List<ChiTietHoaDon> GetAll();

		public void Create(ChiTietHoaDon cthd);
	}
}
