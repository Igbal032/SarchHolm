using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class ApartmentAndImage
    {
        public int Id { get; set; }
        public int ImageId { get; set; }
        public virtual Images Image { get; set; }
        public int ApartmentId { get; set; }
        public virtual Apartment Apartment { get; set; }
    }
}
