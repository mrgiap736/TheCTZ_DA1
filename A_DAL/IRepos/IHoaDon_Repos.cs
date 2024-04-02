﻿using A_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_DAL.IRepos
{
	public interface IHoaDon_Repos
	{
		public List<HoaDon> GetAll();
		public void Create(HoaDon hoaDon);
		public void Delete(string id);
	}
}
