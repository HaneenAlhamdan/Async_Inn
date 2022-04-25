using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Layout { get; set; }


        public HotelRoom HotelRooms { get; set; }
        public List<AmenityRoom> RoomAmenity { get; set; }

    }
}
