using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class SearchHomlUser:IdentityUser<int>
    {
        public string imgPath { get; set; }
        public string imgPathMin { get; set; }
    }
}
