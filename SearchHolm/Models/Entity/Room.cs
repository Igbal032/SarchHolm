using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchHolm.Models.Entity
{
    public class Room
    {
        public int  Id { get; set; }
        public int GarrageId { get; set; }
        public virtual Garrage Garrages { get; set; }
        public int BathRoomId { get; set; }
        public virtual BathRoom BathRooms { get; set; }
        public int BedRoomId { get; set; }
        public virtual BedRoom BedRooms { get; set; }

    }
}
