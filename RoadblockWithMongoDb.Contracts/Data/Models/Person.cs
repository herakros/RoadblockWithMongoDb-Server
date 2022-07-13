using RoadblockWithMongoDb.Contracts.Data;

namespace RoadblockWithMongoDb.Contracts.Data.Models
{
    public class Person
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsDriver { get; set; }
    }
}
