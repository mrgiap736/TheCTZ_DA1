using A_DAL.Entities;
using A_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
	public class HoaDon_Services
	{
		HoaDon_Repos hdrp;

        public HoaDon_Services()
        {
            hdrp = new HoaDon_Repos();
        }

        public void TaoHoaDon(HoaDon hd)
        {
            try
            {
				hdrp.Create(hd);
			}
            catch(Exception ex)
            {
                return;
            }          
        }

        public List<HoaDon> GetAllHoaDon()
        {
            return hdrp.GetAll();
        }

    }
}
