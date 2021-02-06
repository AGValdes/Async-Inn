using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces.Services
{
    public class HotelRoomRepository : IHotelRoom
    {
        private readonly AsyncInnDbContext _context;
  
        public HotelRoomRepository(AsyncInnDbContext context)
        {
            _context = context;

        }
        /// <summary>
        /// The below method creates a new hotel room object and changes its state in to added in our database context, effectively adding it to our database.
        /// </summary>
        /// <param name="roomId"></param>
        /// <param name="hotelId"></param>
        /// <param name="roomNumber"></param>
        /// <param name="rate"></param>
        /// <param name="petFriendly"></param>
        /// <returns></returns>
        public  async Task AddRoomToHotel(int roomId, int hotelId, int roomNumber, decimal rate, bool petFriendly)
        {
            HotelRoom HotelRoom = new HotelRoom()
            {
                RoomId = roomId,
                HotelId = hotelId,
                RoomNumber = roomNumber,
                Rate = rate,
                PetFriendly = petFriendly,
                Room = await _context.Rooms.FirstOrDefaultAsync(r => r.Id == roomId),
                Hotel = await _context.Hotels.FirstOrDefaultAsync(h => h.Id == hotelId)
          
            };

            _context.Entry(HotelRoom).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// The below methodtakes in a hotel room and adds it to the database
        /// </summary>
        /// <param name="hotelRoom"></param>
        /// <returns></returns>
        public async Task<HotelRoom> CreateHotelRoom(HotelRoom hotelRoom)
        {
            _context.Entry(hotelRoom).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return hotelRoom;
        }
        /// <summary>
        /// The below method queries the database for a hotel room by its hotel and room ids, then changes that object's state to deleted, effectively removing it from the database.
        /// </summary>
        /// <param name="hotelId"></param>
        /// <param name="roomnumber"></param>
        /// <returns></returns>
        public async Task DeleteHotelRoom(int hotelId, int roomnumber)
        {
            HotelRoom HotelRoom = await GetHotelRoom(hotelId, roomnumber);
            _context.Entry(HotelRoom).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// 
        /// The below method queries the database and retrieves a hotelroom based on the hotelid and roomid.
        /// </summary>
        /// <param name="hotelId"></param>
        /// <param name="roomNumber"></param>
        /// <returns></returns>
        public async Task<HotelRoom> GetHotelRoom(int hotelId, int roomNumber)
        {
            return await _context.HotelRooms
                                .Where(h => h.HotelId == hotelId && h.RoomNumber == roomNumber)
                                      .FirstOrDefaultAsync();
        }

        /// <summary>
        /// The below method queries the database and retrieves a list of all hotel rooms.
        /// </summary>
        /// <param name="hotelId"></param>
        /// <returns></returns>
        public  async Task<List<HotelRoom>> GetHotelRooms(int hotelId)
        {
            return await _context.HotelRooms
                              .Where(h => h.HotelId == hotelId)
                                   .ToListAsync();
        }
        /// <summary>
        /// The below method queries the database for a specific hotelroom and then changes its state to deleted, effectively removing it from the database.
        /// </summary>
        /// <param name="roomNumber"></param>
        /// <param name="hotelId"></param>
        /// <returns></returns>
        public async Task RemoveRoomFromHotel(int roomNumber, int hotelId)
        {
            var result = await _context.HotelRooms.FirstOrDefaultAsync(x => x.RoomNumber == roomNumber && x.HotelId == hotelId);
                                        
            _context.Entry(result).State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }
        /// <summary>
        /// The below method changes the state of an input hotel room to modified in the database, effectly saving changes to the object in the database.
        /// </summary>
        /// <param name="hotelRoom"></param>
        /// <returns></returns>
        public async Task<HotelRoom> UpdateHotelRoom( HotelRoom hotelRoom)
        {
            _context.Entry(hotelRoom).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return hotelRoom;
        }
    }
}
