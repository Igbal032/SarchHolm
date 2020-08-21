using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class MeettingType
    {
        public int Id { get; set; }
        public string MeetingTypeName { get; set; }
    }
}
