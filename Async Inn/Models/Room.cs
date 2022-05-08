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
        public Layout Layout { get; set; }


        public List<HotelRoom> HotelRooms { get; set; }
        public List<RoomAmenity> RoomAmenity { get; set; }

    }

    public enum Layout
    {
        studio,
        onebedroom,
        twobedroom
    }
    }
