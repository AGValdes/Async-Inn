using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotelRoom
    {
        Task<HotelRoom> CreateHotelRoom(HotelRoom hotelRoom);
        Task<HotelRoom> GetHotelRoom(int Id, int roomNumber);
        Task<List<HotelRoom>> GetHotelRooms();
        Task<Room> UpdateHotelRoom(int Id, HotelRoom hotelRoom);
        Task DeleteHotelRoom(int Id);

        Task AddRoomToHotel(int roomId, int hotelId, int roomNumber, decimal rate, bool petFriendly);

        Task RemoveRoomFromHotel(int roomId, int hotelId);
    }
}
