using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using SearchHolm.Models;
using SearchHolm.Models.Entity;

namespace SearchHolm.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        readonly UserManager<SearchHomlUser> userManager;
        readonly RoleManager<SearchHomlRole> roleManager;
        readonly SignInManager<SearchHomlUser> signInManager;
        readonly CompanyDbContext db;

        public HomeController(ILogger<HomeController> logger, SignInManager<SearchHomlUser> signInManager, UserManager<SearchHomlUser> userManager, RoleManager<SearchHomlRole> roleManager, CompanyDbContext db)
        {
            _logger = logger;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.db = db;
        }

        public void aboutCompany()
        {
            List<AboutCompany> aboutSite = db.aboutCompany.Include(n => n.CompanyNumber).Include(a => a.CompanyAdresss).Include(e => e.CompanyEmail).ToList();
            ViewData["aboutSite"] = aboutSite.FirstOrDefault();
        }

        public IActionResult Index()
        {
            aboutCompany();
            List<Apartment> propertiesList = db.apartments.ToList();
            List<Apartment> propertiesListForNew = db.apartments.Where(w => w.ForRentOrSale.Name == "For Sale").ToList();
            List<Apartment> propertiesListForRent = db.apartments.Where(w => w.ForRentOrSale.Name == "For Rent").ToList();
            ViewData["allProperties"] = propertiesList;
            ViewData["forSale"] = propertiesListForNew;
            ViewData["forRent"] = propertiesListForRent;
            return View();
        }
        public async Task<IActionResult> sentMessage(Consultation consultation)
        {
            if (!ModelState.IsValid)
            {
                aboutCompany();
                Index();
                return View("Index");
            }
            else
            {
                Consultation findConsultation = db.consultations.Where(w => w.Name == consultation.Name).FirstOrDefault();
                if (findConsultation==null)
                {
                    await db.consultations.AddAsync(consultation);
                    await db.SaveChangesAsync();
                    aboutCompany();
                    Index();
                    return View("Index");
                }
                else
                {
                    aboutCompany();
                    ViewData["existUser"] = "This User has already taken consultation!!!!";
                    Index();
                    return View("Index");
                }
                
            }
        }
        [HttpGet]
        public IActionResult GetCities(int Id)
        {
            aboutCompany();
            List<City> cities = db.cities.Where(w => w.StateId == Id).ToList();
            return PartialView(cities);
        }
        List<Apartment> findApartment;
        public IActionResult searchSubmit(int StateId, int CityId)
        {
            City city;
            State state;
            aboutCompany();
            if (StateId != 0 && CityId != 0)
            {
                state = db.States.Where(w => w.Id == StateId).FirstOrDefault();
                city = db.cities.Where(w => w.Id == CityId).FirstOrDefault();
                findApartment = db.apartments.Where(w => w.City.state.StateName == state.StateName && w.City.CityName == city.CityName).ToList();
            }
            else if (StateId != 0)
            {
                state = db.States.Where(w => w.Id == StateId).FirstOrDefault();
                findApartment = db.apartments.Where(w => w.City.state.StateName == state.StateName).ToList();
            }
            return PartialView(findApartment);
        }

        //public async Task<IActionResult> SignInSubmit(string UserName, string Password)
        //{
        //    var checkUser = await userManager.FindByNameAsync(UserName);
        //    if (checkUser != null)
        //    {
        //        if (!string.IsNullOrWhiteSpace(Password))
        //        {
        //            var result = await signInManager.PasswordSignInAsync(UserName, Password, true, true);

        //            if (result.Succeeded)
        //            {
        //                var claims = new List<Claim> {
        //                    new Claim(ClaimTypes.Name,UserName)

        //                };
        //                var identity = new ClaimsIdentity(
        //                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
        //                var principal = new ClaimsPrincipal(identity);
        //                var props = new AuthenticationProperties();
        //                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
        //                ViewData["aboutSite"] = db.aboutCompany.FirstOrDefault();
        //                ViewBag.logIN = "Log In successed";
        //                var sessionName = userManager.GetUserName(HttpContext.User);
        //                ViewBag.Session = sessionName;
        //                return View("Index");
        //            }
        //        }
        //    }
        //    else
        //    {
        //        var newUser = new SearchHomlUser
        //        {
        //            UserName = UserName,
        //        };

        //        var addUser = await userManager.CreateAsync(newUser, Password);
        //        if (addUser.Succeeded)
        //        {
        //            var findRole = await roleManager.FindByIdAsync("1");

        //            //var x = await userManager.AddToRoleAsync(newUser, findRole.Name);
        //        }
        //    }
        //    ViewData["aboutSite"] = db.aboutCompany.FirstOrDefault();
        //    return View("Index");
        //}
        //[HttpPost]
        //public async Task<IActionResult> logOut()
        //{
        //    await HttpContext.SignOutAsync(
        //         CookieAuthenticationDefaults.AuthenticationScheme);
        //    var x = userManager.GetUserName(HttpContext.User);
        //    ViewData["aboutSite"] = db.aboutCompany.FirstOrDefault();
        //    return View("Index");
        //}



    }
}
