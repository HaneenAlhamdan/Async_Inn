using Async_Inn.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IAmenity
    {
        Task<AmenityDTO> Create(AmenityDTO amenity);
        Task<List<AmenityDTO>> GetAmenities();
        Task<AmenityDTO> GetAmenity(int id);
        Task<AmenityDTO> UpdateAmenity(int id, AmenityDTO amenity);
        Task Delete(int id);
    }
}
