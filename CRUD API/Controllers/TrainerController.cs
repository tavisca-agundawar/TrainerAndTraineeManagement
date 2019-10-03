using System;
using System.Collections.Generic;
using CRUD_API.Model;
using CRUD_API.Service;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainerController : ControllerBase
    {
        private readonly TrainerService _trainerService = new TrainerService();
        // GET: api/Trainer
        [HttpGet]
        public ActionResult<IEnumerable<Trainer>> Get()
        {

            var result = _trainerService.GetTrainers();
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainers);
            }
        }

        // GET: api/Trainer/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<Trainer> Get(int id)
        {
            var result = _trainerService.GetTrainerById(id);
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainer);
            }
        }

        // POST: api/Trainer
        [HttpPost]
        public ActionResult<Trainer> Post([FromBody] Trainer newTrainer)
        {
            var result = _trainerService.AddTrainer(newTrainer);
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainer);
            }
        }

        // PUT: api/Trainer/5
        [HttpPut("{id}")]
        public ActionResult<Trainer> Put(int id, [FromBody] Trainer trainer)
        {
            var result = _trainerService.UpdateTrainer(trainer,id);
            if (result.Errors != null)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                return Ok(result.Trainer);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var result = _trainerService.DeleteTrainerById(id);
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
