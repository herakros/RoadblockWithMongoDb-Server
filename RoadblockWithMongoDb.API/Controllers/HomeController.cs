using Microsoft.AspNetCore.Mvc;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController
    {
        private readonly ICarService _carService;
        public HomeController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        [Route("cars")]
        public async Task AddCar([FromBody] Car car)
        {
            await _carService.AddCar(car);
        }

        [HttpGet]
        [Route("cars/{id}")]
        public async Task<Car> GetAsync([FromRoute] string id)
        {
            return await _carService.GetCar(id);
        }

        [HttpDelete]
        [Route("cars/{id}")]
        public async Task DeleteAsync([FromRoute]  string id)
        {
            await _carService.DeleteCar(id);
        }

        [HttpPut]
        [Route("cars/{id}")]
        public async Task PutAsync([FromRoute] string id, [FromBody] Car model)
        {
            model.SetId(id);
            await _carService.EditCar(model);
        }

        [HttpGet]
        [Route("cars")]
        public IEnumerable<Car> GetCars()
        {
            return _carService.GetCars();
        }
    }
}
