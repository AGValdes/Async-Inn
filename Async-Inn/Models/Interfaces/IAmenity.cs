using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IAmenity
    {
        Task<AmenityDTO> CreateAmenity(AmenityDTO amenityDTO);
        Task<AmenityDTO> GetAmenity(int Id);
        Task<List<AmenityDTO>> GetAmenities();
        Task<AmenityDTO> UpdateAmenity(AmenityDTO amenityDTO);
        Task DeleteAmenity(int Id);
    }
}
