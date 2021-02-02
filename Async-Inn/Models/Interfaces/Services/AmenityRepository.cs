using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces.Services
{
    public class AmenityRepository : IAmenity
    {
        public AsyncInnDbContext _context;
        public AmenityRepository(AsyncInnDbContext context)
        {
            _context = context;
        }

        public async Task<AmenityDTO> CreateAmenity(AmenityDTO amenity)
        {
            _context.Entry(amenity).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return amenity;
        }
        public async Task<List<AmenityDTO>> GetAmenities()
        {
            var amenities = await _context.Amenities
                            .Select(Amenity => new AmenityDTO()
                            {
                                ID = Amenity.Id,
                                Name = Amenity.Name
                            }).ToListAsync();
            return amenities;
          
        }

        public async Task<AmenityDTO> GetAmenity(int Id)
        {
            AmenityDTO amenity = await _context.Amenities
                 .Select(Amenity => new AmenityDTO()
                 {
                     ID = Amenity.Id,
                     Name = Amenity.Name
                 }).FirstOrDefaultAsync(amenity => amenity.ID == Id);
            return amenity;
        }

        public async Task<AmenityDTO> UpdateAmenity(AmenityDTO amenityDTO)
        {
           Amenity amenity = new Amenity
           {
               Id = amenityDTO.ID,
               Name = amenityDTO.Name,
           };

            _context.Entry(amenity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return amenityDTO;
        }
        public async Task DeleteAmenity(int Id)
        {
            AmenityDTO amenity = await GetAmenity(Id);
            _context.Entry(amenity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
