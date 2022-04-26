using Async_Inn.Data;
using Async_Inn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Services
{
    public class RoomServieces : IRoom
    {
        private readonly AsyncInnDbContext _context;

        public RoomServieces(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task<Room> Create(Room room)
        {
            _context.Entry(room).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task<Room> GetRoom(int id)
        {
            return await _context.Rooms
                                 .Include(a => a.RoomAmenity)
                                 .ThenInclude(b => b.Amenity)
                                 .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                               .Include(a => a.RoomAmenity)
                               .ThenInclude(b => b.Amenity)
                               .ToListAsync();
        }

        public async Task<Room> UpdateRoom(int id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return room;
        }
        public async Task Delete(int id)
        {
            Room room = await GetRoom(id);
            _context.Entry(room).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
        public async Task AddAmenityToRoom(int roomId, int amenityId)
        {
            AmenityRoom amenity = new AmenityRoom()
            {
                AmenetiesID = amenityId,
                RoomID = roomId
            };
            _context.Entry(amenity).State = EntityState.Added; 
            await _context.SaveChangesAsync();
        }
        public async Task RemoveAmenityFromRoom(int roomId, int amenityId)
        {
            var removedAmenity = await _context.AmenitiesRoom.FirstOrDefaultAsync(i => i.RoomID == roomId && i.AmenetiesID == amenityId);
            _context.AmenitiesRoom.Remove(removedAmenity);
            await _context.SaveChangesAsync();
        }
    }
}
