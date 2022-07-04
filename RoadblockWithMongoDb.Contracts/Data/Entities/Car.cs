using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace RoadblockWithMongoDb.Contracts.Entities
{
    public class Car
    {
        public Car()
        {
            this.AddedOn = DateTime.UtcNow;
        }

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string VehicleNumber { get; set; }

        public ICollection<Person> Persons { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
