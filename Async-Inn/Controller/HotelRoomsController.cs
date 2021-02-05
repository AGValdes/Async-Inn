using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Async_Inn.Data;
using Async_Inn.Models;
using Async_Inn.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Async_Inn.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelRoomsController : ControllerBase
    {
        private readonly IHotelRoom _hotelroom;

        public HotelRoomsController(IHotelRoom hotelroom)
        {
            _hotelroom = hotelroom;
        }

        // GET: api/HotelRooms
        [HttpGet]
        [Route("Hotels/{hotelId}/Rooms")]
        public async Task<ActionResult<IEnumerable<HotelRoom>>> GetHotelRooms(int hotelId)
        {
            var hotelroom = await _hotelroom.GetHotelRooms(hotelId);
            return Ok(hotelroom);
        }

        // GET: api/HotelRooms/5
        [HttpGet]
        [Route("Hotels/{hotelId}/Rooms/{roomNumber}")]
        public async Task<ActionResult<HotelRoom>> GetHotelRoom(int hotelid, int roomNumber)
        {
            var hotelroom = await _hotelroom.GetHotelRoom(hotelid, roomNumber);

            if (hotelroom == null)
            {
                return NotFound();
            }

            return hotelroom;
        }

        // PUT: api/HotelRooms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(Policy = "Update HotelRooms")]
        [HttpPut]
        [Route("Hotels/{hotelId}/Rooms/{roomNumber}")]
        public async Task<IActionResult> PutHotelRoom(HotelRoom hotelRoom)
        { 

            var updatedHotelRoom = await _hotelroom.UpdateHotelRoom(hotelRoom);
            return Ok(updatedHotelRoom);
        }

        // POST: api/HotelRooms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(Policy = "Create HotelRooms")]
        [HttpPost]
        public async Task<ActionResult<HotelRoom>> PostHotelRoom(HotelRoom hotelRoom)
        {
            await _hotelroom.CreateHotelRoom(hotelRoom);
            return CreatedAtAction("GetHotelRoom", new { Hotelid = hotelRoom.HotelId, RoomId = hotelRoom.RoomId, RoomNumber = hotelRoom.RoomNumber, PetFriendly = hotelRoom.PetFriendly, Rate = hotelRoom.Rate, Room = hotelRoom.Room, Hotel = hotelRoom.Hotel  }, hotelRoom);
        }

        // DELETE: api/HotelRooms/5
        [Authorize(Policy = "Delete HotelRooms")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<HotelRoom>> DeleteHotelRoom(int hotelid, int roomNumber)
        {
            await _hotelroom.DeleteHotelRoom(hotelid, roomNumber);
            return NoContent();
        }
        //adds a room to a hotel
        [Authorize(Policy = "Add Room To Hotel")]
        [HttpPost]
        [Route("Hotels/{hotelId}/Rooms")]
        public async Task<IActionResult> AddRoomToHotel(int hotelId, int roomId, int roomNumber, decimal rate, bool petFriendly)
        {
            await _hotelroom.AddRoomToHotel(hotelId, roomId, roomNumber, rate, petFriendly);
            await _hotelroom.AddRoomToHotel(hotelId, roomId, roomNumber, rate, petFriendly);
            return NoContent();
        }
        //removes a room from a hotel
        [HttpDelete]
        [Route("Hotels/{hotelId}/Rooms/{roomNumber}")]
        public async Task<IActionResult> DeleteRoomFromHotel(int roomNumber, int hotelId)
        {
            await _hotelroom.RemoveRoomFromHotel(roomNumber, hotelId);
            return NoContent();
        }
    }
}
