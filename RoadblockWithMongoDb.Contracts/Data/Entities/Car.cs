using RoadblockWithMongoDb.Contracts.Data;
using RoadblockWithMongoDb.Contracts.Data.Models;
using System;
using System.Collections.Generic;

namespace RoadblockWithMongoDb.Contracts.Data.Entities
{
    public class Car : BaseEntity
    {
        public Car()
        {
            this.AddedOn = DateTime.UtcNow;
        }

        public string VehicleNumber { get; set; }

        public IEnumerable<Person> Persons { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
