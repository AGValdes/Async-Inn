﻿using System;
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
    public class AmenitiesController : ControllerBase
    {
        private readonly IAmenity _amenity;

        public AmenitiesController(IAmenity amenity)
        {
            _amenity = amenity;
        }

        // GET: api/Amenities
        [Authorize(Policy = "See Amenities")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AmenityDTO>>> GetAmenities()
        {
            return Ok(await _amenity.GetAmenities());
        }

        // GET: api/Amenities/5
        [Authorize(Policy = "See Amenities")]
        [HttpGet("{id}")]
        public async Task<ActionResult<AmenityDTO>> GetAmenity(int id)
        {
            var amenity = await _amenity.GetAmenity(id);

            if (amenity == null)
            {
                return NotFound();
            }

            return amenity;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(Policy = "Update Amenity")]
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenity(AmenityDTO amenity)
        {
       
            AmenityDTO updatedAmenity = await _amenity.UpdateAmenity(amenity);
            return Ok(updatedAmenity);
        }

        // POST: api/Amenities
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [Authorize(Policy = "Create Amenity")]
        [HttpPost]
        public async Task<ActionResult<Amenity>> PostAmenity(AmenityDTO amenity)
        {
            await _amenity.CreateAmenity(amenity);
            return CreatedAtAction("GetAmenity", new { id = amenity.ID }, amenity);
        }

        // DELETE: api/Amenities/5
        [Authorize(Policy = "Delete Amenity")]
        [HttpDelete("{id}")]
        public async Task<ActionResult<Amenity>> DeleteAmenity(int id)
        {
            await _amenity.DeleteAmenity(id);
            return NoContent();
        }
    }
}
