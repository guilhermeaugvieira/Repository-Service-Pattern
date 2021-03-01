using Microsoft.AspNetCore.Mvc;
using RepositoryServicePattern.Data.Entities;
using RepositoryServicePattern.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RepositoryServicePattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        public readonly IFoodService _service;

        public FoodController(IFoodService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<FoodItem>>> GetAll()
        {
            return await _service.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<FoodItem>> GetById([FromRoute] long id)
        {
            var model = await _service.GetById(id);

            if (model == null)
            {
                return NoContent();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update([FromRoute] long id, FoodItem model)
        {
            if (id != model.ID)
            {
                return BadRequest();
            }

            await _service.Update(id, model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<FoodItem>> Create([FromBody]FoodItem model)
        {
            await _service.Create(model);

            return CreatedAtAction(nameof(GetAll), new { id = model.ID }, model);
        }


        [HttpDelete("{id}")]
        public async Task<ActionResult<FoodItem>> Delete([FromRoute]long id)
        {
            var model = await _service.GetById(id);

            if(model == null)
            {
                return NotFound();
            }

            await _service.Delete(id);

            return model;
        }
    }
}
