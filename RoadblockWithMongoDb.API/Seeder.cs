using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using RoadblockWithMongoDb.Contracts.Data.Base;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Services;
using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.API
{
    public static class Seeder
    {
        public static async Task SeedDatabaseAsync(IServiceScope scope)
        {
            var env = scope.ServiceProvider.GetRequiredService<IWebHostEnvironment>();
            var db = scope.ServiceProvider.GetRequiredService<IDataService>();

            await ReadJson(db.Cars, env, "cars.json");
            await ReadJson(db.Trucks, env, "trucks.json");
        }

        private static async Task ReadJson<TEntity>(IRepository<TEntity> repository, 
            IWebHostEnvironment env,
            string fileName) where TEntity : BaseEntity
        {
            if (repository.GetAll().Count() == 0)
            {
                var entityJson = await File.ReadAllTextAsync(Path.Combine(env.WebRootPath, @$"assets/data/{fileName}"));
                var entities = JsonSerializer.Deserialize<TEntity[]>(entityJson); 

                foreach(var entity in entities)
                {
                    await repository.AddAsync(entity);
                }

                Console.WriteLine($"Records {fileName.Replace(".json", string.Empty)} added to DB: {repository.GetAll().Count()}");
            }
        }
    }
}
