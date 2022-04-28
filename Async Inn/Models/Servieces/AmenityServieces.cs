using Async_Inn.Data;
using Async_Inn.Models.DTOs;
using Async_Inn.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Servieces
{
    public class AmenityServieces : IAmenity
    {
        private readonly AsyncInnDbContext _context;

        public AmenityServieces(AsyncInnDbContext context)
        {
            _context = context;
        }
        public async Task<AmenityDTO> Create(AmenityDTO amenitydto)
        {
            Amenity amenities = new Amenity
            {
                Id = amenitydto.ID,
                Name = amenitydto.Name,
            };
            _context.Entry(amenities).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return amenitydto;
        }

        public async Task<AmenityDTO> GetAmenity(int id)
        {
            return await _context.Amenities

               .Select(amenity => new AmenityDTO 
               {
                   ID = id,
                   Name = amenity.Name,
               }).FirstOrDefaultAsync(a => a.ID == id); 
        }

        public async Task<List<AmenityDTO>> GetAmenities()
        {
            return await _context.Amenities

             .Select(amenity => new AmenityDTO 
             {
                 ID = amenity.Id,
                 Name = amenity.Name,
             }).ToListAsync();
        }

        public async Task<AmenityDTO> UpdateAmenity(int id, AmenityDTO amenitydto)
        {
            Amenity amenities = new Amenity
            {
                Id = amenitydto.ID,
                Name = amenitydto.Name,
            };
            _context.Entry(amenities).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return amenitydto;
        }
        public async Task Delete(int id)
        {
            Amenity amenity = await _context.Amenities.FindAsync(id);
            _context.Entry(amenity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
