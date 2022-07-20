using RoadblockWithMongoDb.Contracts.Data.Base;
using RoadblockWithMongoDb.Contracts.Data.Models;
using System.Collections.Generic;

namespace RoadblockWithMongoDb.Contracts.Data.Entities
{
    public class Car : BaseEntity
    {
        public IEnumerable<Person> Persons { get; set; }
    }
}
