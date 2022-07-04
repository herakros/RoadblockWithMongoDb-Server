using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RoadblockWithMongoDb.Contracts.Entities
{
    public class Person
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Age { get; set; }

        public string PhoneNumber { get; set; }

        public bool IsDriver { get; set; }
    }
}
