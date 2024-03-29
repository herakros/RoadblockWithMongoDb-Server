﻿using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.DTO;
using RoadblockWithMongoDb.Contracts.DTO.CarDTO;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : Controller
    {
        private readonly ICarService _carService;

        public CarController(ICarService carService)
        {
            _carService = carService;
        }

        [HttpPost]
        [Route("cars")]
        public async Task AddCar([FromBody] CreateCarDTO carDTO)
        {
            await _carService.AddCar(carDTO);
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
        public async Task PutAsync([FromRoute] string id, [FromBody] EditCarDTO carDTO)
        {
            await _carService.EditCar(carDTO, id);
        }

        [HttpGet]
        [Route("cars")]
        public IEnumerable<Car> GetCars()
        {
            return _carService.GetCars();
        }
    }
}
