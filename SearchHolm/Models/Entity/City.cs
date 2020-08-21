using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
        public virtual State state { get; set; }
    }
}
