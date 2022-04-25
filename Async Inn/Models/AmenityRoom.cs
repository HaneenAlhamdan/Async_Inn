using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class AmenityRoom
    {
        public int AmenetiesID { get; set; }
        public int RoomID { get; set; }


        public Amenity Amenity { get; set; }
        public Room Room { get; set; }

    }
}
