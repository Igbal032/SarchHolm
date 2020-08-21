using Microsoft.AspNetCore.Mvc;
using SearchHolm.Models;
using SearchHolm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.ViewComponents
{
    public class SearchProperties:ViewComponent
    {
        readonly CompanyDbContext db;
        public SearchProperties(CompanyDbContext db)
        {
            this.db = db;
        }

        public IViewComponentResult Invoke() 
        {
            List<State> States = db.States.ToList();
            return View(States);
        }
    }
}
