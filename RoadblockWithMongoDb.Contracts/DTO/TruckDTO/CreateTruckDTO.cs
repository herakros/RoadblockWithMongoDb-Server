using RoadblockWithMongoDb.Contracts.Data.Models;

namespace RoadblockWithMongoDb.Contracts.DTO.TruckDTO
{
    public class CreateTruckDTO
    {
        public Person Driver { get; set; }

        public double TruckWeight { get; set; }

        public string Model { get; set; }

        public string VehicleNumber { get; set; }
    }
}
