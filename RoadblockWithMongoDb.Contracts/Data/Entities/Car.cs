using RoadblockWithMongoDb.Contracts.Data;
using System;
using System.Collections.Generic;

namespace RoadblockWithMongoDb.Contracts.Entities
{
    public class Car : BaseEntity
    {
        public Car()
        {
            this.AddedOn = DateTime.UtcNow;
        }

        public string VehicleNumber { get; set; }

        public ICollection<Person> Persons { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
