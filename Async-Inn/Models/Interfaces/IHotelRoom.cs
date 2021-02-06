using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotelRoom
    {
        /// <summary>
        /// The below methods will be required in the hotelroom respository
        /// </summary>
        /// <param name="hotelRoom"></param>
        /// <returns></returns>
        Task<HotelRoom> CreateHotelRoom(HotelRoom hotelRoom);
        Task<HotelRoom> GetHotelRoom(int hotelId, int roomNumber);
        Task<List<HotelRoom>> GetHotelRooms(int hotelId);
        Task<HotelRoom> UpdateHotelRoom(HotelRoom hotelRoom);
        Task DeleteHotelRoom(int hotelId, int roomNumber);

        Task AddRoomToHotel(int roomId, int hotelId, int roomNumber, decimal rate, bool petFriendly);

        Task RemoveRoomFromHotel(int roomId, int hotelId);
    }
}
