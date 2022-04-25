using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class HotelRoom
    {
        public int HotelId { get; set; }
        public int RoomNum { get; set; }
        public int RoomId { get; set; }
        public decimal Rate { get; set; }
        public bool IsPetFriendly { get; set; }


        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
    }
}
