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

        public List<SanPham> FilterByTheFirm(int index)
        {
            throw new NotImplementedException();
        }
    }
}
