using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class Apartment
    {
        public int Id { get; set; }
        public string Tittle { get; set; }
        public string ExactAddress { get; set; }
        public double Price { get; set; }
        public string imgPath { get; set; }
        public string imgPathForPlace { get; set; }
        public double Area { get; set; }
        public int SearchHomlUserId { get; set; }
        public virtual SearchHomlUser SearchHomlUsers { get; set; }
        public int CityId { get; set; }
        public virtual City City { get; set; }
        public int RoomId { get; set; }
        public virtual Room Room { get; set; }
        public int ForRentOrSaleId { get; set; }
        public virtual ForRentOrSale ForRentOrSale { get; set; }
    }
}
