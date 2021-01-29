using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Async_Inn.Models
{
    public class Amenity
    {
        public int Id { get; set; }
        public string Name { get; set; }


        //navigation properties
        public List<RoomAmenity> RoomAmenities { get; set; }
    }
}
