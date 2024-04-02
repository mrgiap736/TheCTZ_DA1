﻿using A_DAL.Data;
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
	public class HoaDon_Repos : IHoaDon_Repos
	{
		SqlTheCtzContext context;

        public HoaDon_Repos()
        {
			context = new SqlTheCtzContext();
        }
        public void Create(HoaDon hoaDon)
		{
			context.HoaDons.Add(hoaDon);
			context.SaveChanges();
			return;
		}

		public void Delete(string id)
		{
			throw new NotImplementedException();
		}

		public List<HoaDon> GetAll()
		{
			return context.HoaDons.ToList();
		}

		public void Update(int a, int b, int c, int d, int e)
		{
			var hoadonUp = context.HoaDons.Find(a);

			hoadonUp.TienKhachTra = b;
			hoadonUp.GiamGia = c;
			hoadonUp.TongTien = d;
			hoadonUp.TrangThai = e;

			context.HoaDons.Update(hoadonUp);
			context.SaveChanges();
			return;
		}
	}
}