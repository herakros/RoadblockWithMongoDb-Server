using RoadblockWithMongoDb.Contracts.Data.Models;
using System;

namespace RoadblockWithMongoDb.Contracts.DTO.TruckDTO
{
    public class EditTruckDTO
    {
        public Person Driver { get; set; }

        public double TruckWeight { get; set; }

        public string Model { get; set; }

        public string VehicleNumber { get; set; }

        public DateTime AddedOn { get; set; }
    }
}
