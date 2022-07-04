using RoadblockWithMongoDb.Contracts.Data;

namespace RoadblockWithMongoDb.Contracts.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string Age { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsDriver { get; set; }
    }
}
