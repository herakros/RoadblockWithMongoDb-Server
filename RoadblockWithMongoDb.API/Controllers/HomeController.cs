using Microsoft.AspNetCore.Mvc;
using RoadblockWithMongoDb.Contracts.Data.Repositories;
using RoadblockWithMongoDb.Contracts.Entities;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;

namespace RoadblockWithMongoDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController
    {
        private readonly IRepository<Car> _carRepository;
        private readonly IRepository<Person> _personRepository;
        public HomeController(IDataService ds)
        {
            _carRepository = ds.Cars;
            _personRepository = ds.Persons;
        }

        [HttpGet]
        [Route("cars")]
        public IEnumerable<Car> GetCars()
        {
            return _carRepository.GetAll();
        }

        [HttpGet]
        [Route("persons")]
        public IEnumerable<Person> GetPersons()
        {
            return _personRepository.GetAll();
        }
    }
}
