using System;

namespace RoadblockWithMongoDb.Contracts.Data.Base
{
    public class BaseAuto : BaseEntity
    {
        public BaseAuto()
        {
            this.AddedOn = DateTime.UtcNow;
        }

        public string VehicleNumber { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
