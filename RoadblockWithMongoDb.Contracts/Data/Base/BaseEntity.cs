using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace RoadblockWithMongoDb.Contracts.Data.Base
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; private set; }

        public void SetId(string id) => Id = id;

        public BaseEntity()
        {
            this.AddedOn = DateTime.UtcNow;
        }

        public string VehicleNumber { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
