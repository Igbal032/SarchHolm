using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class CompanyAdress
    {
        public int Id { get; set; }
        public string AdressName { get; set; }
        public int CityId { get; set; }
        public virtual City city{ get; set; }
    }
}
