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
        /// <summary>
        /// The below method takes in an Amenity data transfer object, and adds it to the database.
        /// </summary>
        /// <param name="amenity"></param>
        /// <returns></returns>
        public async Task<AmenityDTO> CreateAmenity(AmenityDTO amenityDTO)
        {
            _context.Entry(amenityDTO).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return amenityDTO;
        }
        /// <summary>
        /// This method queries the database context for amenities, and returns a list of amenity data transfer objects that contains the properties we want to display to the user.
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// The below method 
        /// </summary>The below method is very similar to the first, but it returns a specific amenity by Id
        /// <param name="Id"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The below method takes in an amenity data transfer object, makes an amenity object with the properties of the DTO, and updates the database context.
        /// </summary>
        /// <param name="amenityDTO"></param>
        /// <returns></returns>
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
        /// <summary>
        /// The below method deletes an amenity from the database context
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task DeleteAmenity(int Id)
        {
            AmenityDTO amenity = await GetAmenity(Id);
            _context.Entry(amenity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
