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
    public class RoomsController : ControllerBase
    {
        private readonly IRoom _room;

        public RoomsController(IRoom room)
        {
            _room = room;
        }

        // GET: api/Rooms
        [Authorize(Policy = "See Rooms")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RoomDTO>>> GetRooms()
        {
            return Ok(await _room.GetRooms());
        }

        // GET: api/Rooms/5
        [Authorize(Policy = "See Rooms")]
        [HttpGet("{id}")]
        public async Task<ActionResult<RoomDTO>> GetRoom(int Id)
        {
            RoomDTO room = await _room.GetRoom(Id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        // PUT: api/Rooms/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(Policy = "Update Rooms")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(RoomDTO roomDTO)
        {
       
            var updatedRoom = await _room.UpdateRoom(roomDTO);
            return Ok(updatedRoom);
        }

        // POST: api/Rooms
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(Policy = "Create Rooms")]
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(RoomDTO roomDTO)
        {
            await _room.CreateRoom(roomDTO);
            return CreatedAtAction("GetRooms", new { id = roomDTO.ID }, roomDTO);

        }

        // DELETE: api/Rooms/5
        [Authorize(Policy = "Delete Rooms")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Room>> DeleteRoom(int id)
        {
            await _room.DeleteRoom(id);
            return NoContent();
        }

        //new routes that take in the room id and amenity id

        //Adds an amenity to a room
        [Authorize(Policy = "Add Amenity to Room")]
        [HttpPost]
        [Route("{roomId}/{amenityId}")]
        public async Task<IActionResult> AddAmenityToRoom(int roomId, int amenityId)
        {
            await _room.AddAmenityToRoom(roomId, amenityId);
            return NoContent();
        }
        //removes an amenity from a room
        [Authorize(Policy = "Delete Amenity From Room")]
        [HttpDelete]
        [Route("{roomId}/{amenityId}")]
        public async Task<IActionResult> DeleteAmenityFromRoom(int roomId, int amenityId)
        {
            await _room.RemoveAmenityFromRoom(roomId, amenityId);
            return NoContent();
        }
    }
}
