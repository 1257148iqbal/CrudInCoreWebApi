using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CrudInCoreWebApi.Models;
using CrudInCoreWebApi.Models.Repository;




namespace CrudInCoreWebApi.Controllers
{
    [Route("api/Trainee")]
    [ApiController]
    public class TraineeApiController : ControllerBase
    {
        private readonly IDataAccessRepository<Trainee> data;

        public TraineeApiController(IDataAccessRepository<Trainee> repository)
        {
            data = repository;
        }

        [HttpGet]
        [Route("GetTrainee")]
        public IActionResult GetTrainee()
        {
            IEnumerable<Trainee> trainees = data.GelAll();
            return Ok(trainees);
        }

        [HttpGet(Name ="Get")]
        [Route("GetTraineeById/{id}")]
        public IActionResult GetTraineeById(long id)
        {
            Trainee trainee = data.Get(id);
            if (trainee == null)
            {
                return NotFound("Trianee Record Not Found!!!!");
            }
            return Ok(trainee);
        }
    }
}
