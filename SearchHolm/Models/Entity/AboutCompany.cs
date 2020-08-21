using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class AboutCompany
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int CompanyNumberId { get; set; }
        public virtual CompanyNumber CompanyNumber { get; set; }
        public int CompanyAdressId { get; set; }
        public virtual CompanyAdress CompanyAdresss { get; set; }
        public int CompanyEmailId { get; set; }
        public virtual CompanyEmail CompanyEmail { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Pinterest { get; set; }
        public string Youtube { get; set; }
        public string Dribbble { get; set; }
        public string imgPath { get; set; }
        public string context { get; set; }
    }
}
