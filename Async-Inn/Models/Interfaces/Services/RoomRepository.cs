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
        public async Task<RoomDTO> GetRoom(int Id)
        {
            var room = await _context.Rooms.Include(Room => Room.RoomAmenities).ThenInclude(RoomAmenity => RoomAmenity.Amenity).ToListAsync();
            return room
             .Where(Room => Room != null)
             .Select(Room => new RoomDTO
             {
                 ID = Room.Id,
                 Name = Room.Name,
                 Layout = Room.Layout,
                 Amenities = Room.RoomAmenities
                 .Where(RoomAmenity => RoomAmenity != null)
               .Select(a => new AmenityDTO()
               {
                   ID = a.Amenity.Id,
                   Name = a.Amenity.Name
               }).ToList()

             }).FirstOrDefault();
        }

        public async Task<List<RoomDTO>> GetRooms()
        { 
            var rooms = await _context.Rooms.Include(Room => Room.RoomAmenities).ThenInclude(RoomAmenity => RoomAmenity.Amenity).ToListAsync();
            return rooms
                .Where(Room => Room != null)
           .Select(Room => new RoomDTO()
           {
               ID = Room.Id,
               Name = Room.Name,
               Layout = Room.Layout,
               Amenities = Room.RoomAmenities
               .Select(a => new AmenityDTO()
               {
                   ID = a.Amenity.Id,
                   Name = a.Amenity.Name

               }).ToList()
           }).ToList();

        
        }

        public async Task<Room> UpdateRoom(int Id, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return room;
        }

        public async Task DeleteRoom(int Id)
        {
            RoomDTO room = await GetRoom(Id);
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
