using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces.Services
{
    public class RoomRepository : IRoom
    {
        public AsyncInnDbContext _context;
        public RoomRepository(AsyncInnDbContext context)
        {
            _context = context;
        }
 
        public async Task<Room> CreateRoom(Room room)
        {
           _context.Entry(room).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return room;
        }
        public async Task<Room> GetRoom(int Id)
        {
            return await _context.Rooms
                                  .Include(a => a.RoomAmenities)
                                    .ThenInclude(r => r.Amenity)
                                        .FirstOrDefaultAsync(a => a.Id == Id);
        }

        public async Task<List<Room>> GetRooms()
        {
            return await _context.Rooms
                             .Include(a => a.RoomAmenities)
                                 .ThenInclude(r => r.Amenity)
                                      .ToListAsync();
        }

        public async Task<Room> UpdateRoom(int Id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task DeleteRoom(int Id)
        {
            Room room = await GetRoom(Id);
            _context.Entry(room).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        //logic to add and remove amenities from rooms

        public async Task AddAmenityToRoom(int roomId, int amenityId)
        {

            RoomAmenity RoomAmenity = new RoomAmenity()
            {
                RoomId = roomId,
                AmenityId = amenityId
            };

            _context.Entry(RoomAmenity).State = EntityState.Added;
            await _context.SaveChangesAsync();

        }

        public async Task RemoveAmenityFromRoom(int roomId, int amenityId)
        {
           
            var result = await _context.RoomAmenities.FirstOrDefaultAsync(x => x.RoomId == roomId && x.AmenityId == amenityId);

            _context.Entry(result).State = EntityState.Deleted;

            await _context.SaveChangesAsync();

        }
    }
}
