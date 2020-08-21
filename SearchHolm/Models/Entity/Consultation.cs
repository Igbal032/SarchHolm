using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class Consultation
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public int CityId { get; set; }
        public virtual City city { get; set; }
        [Required]
        public int MeettingTypeId { get; set; }
        public virtual MeettingType MeettingType { get; set; }
    }
}
