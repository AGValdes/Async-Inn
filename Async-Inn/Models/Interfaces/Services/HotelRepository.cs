using Async_Inn.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models.Interfaces.Services
{
    public class HotelRepository : IHotel
    {
        public AsyncInnDbContext _context;
        public HotelRepository(AsyncInnDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// The below method takes in a hotel and changes its state to "added" in our database context, effectively adding a hotel object to the database.
        /// it is called by the addhotel post route in the hotel controller.
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Added;
            await _context.SaveChangesAsync();
            return hotel;
        }

        /// <summary>
        /// The below method queries the database and retrieves a hotel based on it's unique id. It is called by the GetHotel get route in our hotel controller.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task<Hotel> GetHotel(int Id)
        {
            Hotel hotel = await _context.Hotels.FindAsync(Id);
            return hotel;
        }

        /// <summary>
        /// The below method queries the database and retrieves all hotel objects. It is called by the GetHotels get route in our hotel controller
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hotel>> GetHotels()
        {
            var hotels = await _context.Hotels.ToListAsync();
            return hotels;
        }
        /// <summary>
        /// The below method changes the state of the input hotel's to modified, effectively saving changes to the database.
        /// It is called by our UpdateHotel put route in our hotel controller
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public async Task<Hotel> UpdateHotel(int Id, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return hotel;
        }

        /// <summary>
        /// The below method queries the database and retrieves a hotel by Id, then changes its state to deleted,
        /// effectively deleting the hotel object from the database. it is called by the deletehotels delete route in the hotle controller.
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public async Task DeleteHotel(int Id)
        {
            Hotel hotel = await GetHotel(Id);
            _context.Entry(hotel).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
        }
    }
}
