using AutoMapper;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;
using RoadblockWithMongoDb.Contracts.DTO.TruckDTO;

namespace RoadblockWithMongoDb.Core.Mapper
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<CreateCarDTO, Car>()
                .ForMember(dest => dest.VehicleNumber, act => act.MapFrom(src => src.VehicleNumber))
                .ForMember(dest => dest.Persons, act => act.MapFrom(src => src.Persons));

            CreateMap<EditCarDTO, Car>()
                .ForMember(dest => dest.VehicleNumber, act => act.MapFrom(src => src.VehicleNumber))
                .ForMember(dest => dest.Persons, act => act.MapFrom(src => src.Persons))
                .ForMember(dest => dest.AddedOn, act => act.MapFrom(src => src.AddedOn));

            CreateMap<CreateTruckDTO, Truck>()
                .ForMember(dest => dest.VehicleNumber, act => act.MapFrom(src => src.VehicleNumber))
                .ForMember(dest => dest.Driver, act => act.MapFrom(src => src.Driver))
                .ForMember(dest => dest.Model, act => act.MapFrom(src => src.Model))
                .ForMember(dest => dest.TruckWeight, act => act.MapFrom(src => src.TruckWeight));

            CreateMap<EditTruckDTO, Truck>()
                .ForMember(dest => dest.VehicleNumber, act => act.MapFrom(src => src.VehicleNumber))
                .ForMember(dest => dest.Driver, act => act.MapFrom(src => src.Driver))
                .ForMember(dest => dest.Model, act => act.MapFrom(src => src.Model))
                .ForMember(dest => dest.TruckWeight, act => act.MapFrom(src => src.TruckWeight))
                .ForMember(dest => dest.AddedOn, act => act.MapFrom(src => src.AddedOn));
        }
    }
}
