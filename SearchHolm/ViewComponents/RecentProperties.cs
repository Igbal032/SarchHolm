using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SearchHolm.Models;
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

            var properties = db.apartments.ToList();

            return View(properties);
        }
    }
}
