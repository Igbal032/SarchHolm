using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SearchHolm.Models;
using SearchHolm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.ViewComponents
{
    public class RecentProperties:ViewComponent
    {
        readonly CompanyDbContext db;
        public RecentProperties(CompanyDbContext db)
        {
            this.db = db;
        }
        public IViewComponentResult Invoke() {
            List<Apartment> properties = db.apartments.ToList();
            return View(properties);
        }
    }
}
