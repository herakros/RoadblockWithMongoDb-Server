using AutoMapper;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;

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
        }
    }
}
