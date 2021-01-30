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
        public  async Task AddRoomToHotel(int roomId, int hotelId, int roomNumber, decimal rate, bool petFriendly)
        {
            HotelRoom HotelRoom = new HotelRoom()
            {
                RoomId = roomId,
                HotelId = hotelId,
                RoomNumber = roomNumber,
                Rate = rate,
                PetFriendly = petFriendly
            };

            _context.Entry(HotelRoom).State = EntityState.Added;
            await _context.SaveChangesAsync();
        }

        public async Task<HotelRoom> CreateHotelRoom(HotelRoom hotelRoom)
        {
            _context.Entry(hotelRoom).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return hotelRoom;
        }

        public async Task DeleteHotelRoom(int hotelId, int roomnumber)
        {
            HotelRoom HotelRoom = await GetHotelRoom(hotelId, roomnumber);
            _context.Entry(HotelRoom).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<HotelRoom> GetHotelRoom(int hotelId, int roomNumber)
        {
            return await _context.HotelRooms
                                .Where(h => h.HotelId == hotelId && h.RoomNumber == roomNumber)
                                      .FirstOrDefaultAsync();
        }

        public  async Task<List<HotelRoom>> GetHotelRooms(int hotelId)
        {
            return await _context.HotelRooms
                              .Where(h => h.HotelId == hotelId)
                                   .ToListAsync();
        }

        public async Task RemoveRoomFromHotel(int roomNumber, int hotelId)
        {
            var result = await _context.HotelRooms.FirstOrDefaultAsync(x => x.RoomNumber == roomNumber && x.HotelId == hotelId);
                                        
            _context.Entry(result).State = EntityState.Deleted;

            await _context.SaveChangesAsync();
        }

        public async Task<HotelRoom> UpdateHotelRoom( HotelRoom hotelRoom)
        {
            _context.Entry(hotelRoom).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return hotelRoom;
        }
    }
}
