using Async_Inn.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotelRoom
    {
        Task<HotelRoomDTO> Create(HotelRoomDTO hotelRoom);
        Task<List<HotelRoomDTO>> GetHotelRooms();
        Task<HotelRoomDTO> GetHotelRoom(int HotelId, int RoomNum);
        Task<HotelRoomDTO> UpdateHotelRoom(int HotelId, int RoomNum, HotelRoomDTO hotelRoom);
        Task Delete(int HotelId, int RoomNum);
        }
    }
