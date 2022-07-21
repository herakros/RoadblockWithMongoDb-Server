using RoadblockWithMongoDb.Contracts.Data.Models;
using System;
using System.Collections.Generic;

namespace RoadblockWithMongoDb.Contracts.DTO.CarDTO
{
    public class EditCarDTO
    {
        public string VehicleNumber { get; set; }

        public IEnumerable<Person> Persons { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
