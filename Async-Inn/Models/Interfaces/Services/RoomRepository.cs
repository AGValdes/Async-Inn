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
        /// <summary>
        /// THe below method gets called by the RoomsController, it takes in a Room Data Transfer Object and creates a new room,
        /// so that it can be posted to the database by the Post Room Route
        /// </summary>
        /// <param name="roomDTO"></param>
        /// <returns></returns>
        public async Task<RoomDTO> CreateRoom(RoomDTO roomDTO)
        {
           _context.Entry(roomDTO).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return roomDTO;
        }
        /// <summary>
        ///The below method takes in a room id, queries the database context for rooms, including their room ammenities,
        ///then returns a room Data Transfer Object. The amenities property is populated using an amenity Data TRansfer object.
        ///This is called in the rooms controller to get a room by Id.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<RoomDTO> GetRoom(int Id)
        {
            var room = await _context.Rooms.Include(Room => Room.RoomAmenities).ThenInclude(RoomAmenity => RoomAmenity.Amenity).ToListAsync();
            return room
            .Select(Room => new RoomDTO
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

             }).FirstOrDefault();
        }
        /// <summary>
        /// The Below method is very similar to the above, accept it returns a list of room Data Transer Objects that represent all rooms in the database.
        /// </summary>
        /// <returns></returns>
        public async Task<List<RoomDTO>> GetRooms()
        { 
            var rooms = await _context.Rooms.Include(Room => Room.RoomAmenities).ThenInclude(RoomAmenity => RoomAmenity.Amenity).ToListAsync();
            return rooms
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
        /// <summary>
        /// The below method takes in a room data transfer object, modifies the room in the database,
        /// and returns a room object with the updated properties from the DTO.
        /// </summary>
        /// <param name="roomDTO"></param>
        /// <returns></returns>
        public async Task<Room> UpdateRoom(RoomDTO roomDTO)
        {
            Room room = new Room
            {
                Id = roomDTO.ID,
                Name = roomDTO.Name,
                Layout = roomDTO.Layout
            };

            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return room;
        }
        /// <summary>
        /// The below method takes in a room Id and deletes the corresponding room from the database.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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
