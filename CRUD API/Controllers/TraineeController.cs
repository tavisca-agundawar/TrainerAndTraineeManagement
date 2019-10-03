using System.Collections.Generic;
using CRUD_API.Model;
using CRUD_API.Service;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TraineeController : ControllerBase
    {
        private static readonly TraineeService _traineeService = new TraineeService();

        // GET: api/Trainee
        [HttpGet]
        public ActionResult<IEnumerable<Trainee>> Get()
        {
            var result = _traineeService.GetTrainees();
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainees);
            }
        }

        // GET: api/Trainee/5
        [HttpGet("{id}", Name = "GetTrainee")]
        public ActionResult<Trainee> Get(int id)
        {
            var result = _traineeService.GetTraineeById(id);
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainee);
            }
        }

        // POST: api/Trainee
        [HttpPost]
        public ActionResult<Trainee> Post([FromBody] Trainee newTrainee)
        {
            var result = _traineeService.AddTrainee(newTrainee);
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainee);
            }
        }

        // PUT: api/Trainee/5
        [HttpPut("{id}")]
        public ActionResult<Trainee> Put(int id, [FromBody] Trainee trainee)
        {
            var result = _traineeService.UpdateTrainee(trainee,id);
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainee);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _traineeService.DeleteTraineeById(id);
            if (result)
            {
                return Ok();
            }
            else
            {
                return StatusCode(500, "Invalid Id / Bad request");
            }
        }
    }
}
