﻿using Microsoft.AspNetCore.Mvc;
using RoadblockWithMongoDb.Contracts.Data.Entities;
using RoadblockWithMongoDb.Contracts.DTO.TruckDTO;
using RoadblockWithMongoDb.Contracts.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadblockWithMongoDb.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TruckController : Controller
    {
        private readonly ITruckService _truckService;
        public TruckController(ITruckService service)
        {
            _truckService = service;
        }

        [HttpGet]
        [Route("trucks")]
        public IEnumerable<Truck> GetTrucks()
        {
            return _truckService.GetTrucks();
        }

        [HttpPost]
        [Route("trucks")]
        public async Task AddTruck([FromBody] CreateTruckDTO truckDTO)
        {
            await _truckService.AddTruck(truckDTO);
        }

        [HttpGet]
        [Route("trucks/{id}")]
        public async Task<Truck> GetTruck([FromRoute] string id)
        {
            return await _truckService.GetTruck(id);
        }

        [HttpDelete]
        [Route("trucks/{id}")]
        public async Task DeleteTruck([FromRoute] string id)
        {
            await _truckService.DeleteTruck(id);
        }

        [HttpPut]
        [Route("trucks/{id}")]
        public async Task PutTruck([FromRoute] string id, [FromBody] EditTruckDTO truckDTO)
        {
            await _truckService.EditTruck(truckDTO, id);
        }
    }
}
