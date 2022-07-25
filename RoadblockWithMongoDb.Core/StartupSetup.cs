using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using RoadblockWithMongoDb.Contracts.Services;
using RoadblockWithMongoDb.Core.Mapper;
using RoadblockWithMongoDb.Core.Services;
using FluentValidation.AspNetCore;
using RoadblockWithMongoDb.Core.Validators;

namespace RoadblockWithMongoDb.Core
{
    public static class StartupSetup
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<ICarService, CarService>();
            services.AddScoped<ITruckService, TruckService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ApplicationProfile());
            });

            IMapper mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }

        public static void AddFluentValidator(this IServiceCollection services)
        {
            services.AddFluentValidation(x => x.RegisterValidatorsFromAssemblyContaining<CreateCarValidator>());
        }
    }
}
