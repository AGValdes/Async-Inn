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
        private readonly IRoom _rooms;
        public HotelRoomRepository(AsyncInnDbContext context, IRoom rooms)
        {
            _context = context;
            _rooms = rooms;
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

        public async Task DeleteHotelRoom(int Id)
        {
            HotelRoom HotelRoom = await GetHotelRoom(Id, _);
            _context.Entry(HotelRoom).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }

        public async Task<HotelRoom> GetHotelRoom(int hotelId, int roomNumber)
        {
           var hotelRoom = await 
                                  
        }

        public Task<List<Room>> GetHotelRooms()
        {
            throw new NotImplementedException();
        }

        public Task RemoveRoomFromHotel(int roomId, int hotelId)
        {
            throw new NotImplementedException();
        }

        public Task<Room> UpdateHotelRoom(int Id, HotelRoom hotelRoom)
        {
            throw new NotImplementedException();
        }
    }
}
