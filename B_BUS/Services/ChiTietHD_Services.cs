﻿using A_DAL.Entities;
using A_DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_BUS.Services
{
	public class ChiTietHD_Services
	{
		ChiTietHD_Repos ctrp;

        public ChiTietHD_Services()
        {
             ctrp = new ChiTietHD_Repos();
        }

        public List<ChiTietHoaDon> GetAllCTHoaDon(int mahd)
        {
            return ctrp.GetAll(mahd);
        }

        public void TaoChiTietHoaDon(ChiTietHoaDon t)
        {
            ctrp.Create(t);
        }

        public void UpdateCTHoaDon(ChiTietHoaDon ct)
        {
            ctrp.Update(ct);
        }

        public void DeleteSPChiTietHoaDon(ChiTietHoaDon ct)
        {
            ctrp.Delete(ct);
        }
    }
}
