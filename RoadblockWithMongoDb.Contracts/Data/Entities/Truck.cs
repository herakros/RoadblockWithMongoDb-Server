using RoadblockWithMongoDb.Contracts.Data.Base;
using RoadblockWithMongoDb.Contracts.Data.Models;

namespace RoadblockWithMongoDb.Contracts.Data.Entities
{
    public class Truck : BaseAuto
    {
        public Person Driver { get; set; }

        public double TruckWeight { get; set; }

        public string Model { get; set; }
    }
}
