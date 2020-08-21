using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SearchHolm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.ViewComponents
{
    public class FindPropertyInCity : ViewComponent
    {
        readonly CompanyDbContext db;
        public FindPropertyInCity(CompanyDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke() 
        {
            var apartments = db.apartments.ToList();
            return View(apartments);
        }
    }
}
