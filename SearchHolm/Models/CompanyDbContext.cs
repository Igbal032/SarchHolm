using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SearchHolm.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models
{
    public class CompanyDbContext:IdentityDbContext<SearchHomlUser,SearchHomlRole,int>
    {
        public CompanyDbContext(DbContextOptions options)
            :base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
        }
        public DbSet<AboutCompany> aboutCompany { get; set; }
        public DbSet<CompanyAdress> companyAdresses { get; set; }
        public DbSet<CompanyNumber> companyNumbers { get; set; }
        public DbSet<Apartment> apartments { get; set; }
        public DbSet<City> cities { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Consultation> consultations { get; set; }
        public DbSet<MeettingType> meettingTypes { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Subscribe> subscribes { get; set; }
        public DbSet<Room> rooms { get; set; }
        public DbSet<ForRentOrSale> forRentOrSales { get; set; }
        public DbSet<BedRoom> bedRooms { get; set; }
        public DbSet<Garrage> garrages { get; set; }
        public DbSet<BathRoom> bathRooms { get; set; }
        public DbSet<Images> images { get; set; }
        public DbSet<CompanyEmail> companyEmails { get; set; }
        public DbSet<ApartmentAndImage> ApartmentAndImage { get; set; }
    }
}
