using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotelRoom
    {
        Task<HotelRoom> Create(HotelRoom hotelRoom);
        Task<List<HotelRoom>> GetHotelRooms();
        Task<HotelRoom> GetHotelRoom(int HotelId, int RoomNum);
        Task<HotelRoom> UpdateHotelRoom(int HotelId, int RoomNum, HotelRoom hotelRoom);
        Task Delete(int HotelId, int RoomNum);
    }
}
