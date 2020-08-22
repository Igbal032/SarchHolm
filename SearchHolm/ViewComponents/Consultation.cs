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
    public class Consultation:ViewComponent
    {
        readonly CompanyDbContext db;
        public Consultation(CompanyDbContext db)
        {
            this.db = db;
        }
        Consultation consultation;
        public IViewComponentResult Invoke(){

            List<City> cities = db.cities.Include(c => c.state).ToList();
            List<MeettingType> meetingTypes = db.meettingTypes.ToList();
            ViewData["cities"] = cities;
            ViewData["meetingTypes"] = meetingTypes;
            return View(consultation);
        }
    }
}
