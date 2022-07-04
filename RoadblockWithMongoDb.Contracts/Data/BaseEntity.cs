using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace RoadblockWithMongoDb.Contracts.Data
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; private set; }

        public void SetId(string id) =>
            Id = id;
    }
}
