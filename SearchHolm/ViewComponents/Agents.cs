using Microsoft.AspNetCore.Identity;
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
    public class Agents:ViewComponent
    {
        readonly CompanyDbContext db;
        readonly UserManager<SearchHomlUser> userManager;
        readonly RoleManager<SearchHomlRole> roleManager;
        public Agents(CompanyDbContext db, UserManager<SearchHomlUser> userManager, RoleManager<SearchHomlRole> roleManager)
        {
            this.db = db;
            this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public IViewComponentResult Invoke()
        {
            var agents = db.UserRoles.Where(w => w.RoleId == 1).ToList();
            var users = new List<SearchHomlUser>();
            foreach (var item in agents)
            {
                var findUser = db.Users.Where(w => w.Id == item.UserId).FirstOrDefault();
                users.Add(findUser);
            }
            return View(users);
        }
    }
}
