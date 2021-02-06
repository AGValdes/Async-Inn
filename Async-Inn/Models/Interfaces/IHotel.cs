using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces
{
    public interface IHotel
    {
        /// <summary>
        /// The below methods will be required in the hotel repository
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        Task<Hotel> CreateHotel(Hotel hotel);
        Task<Hotel> GetHotel(int Id);
        Task<List<Hotel>> GetHotels();
        Task<Hotel> UpdateHotel(int Id, Hotel hotel);
        Task DeleteHotel(int Id);
    }
}
