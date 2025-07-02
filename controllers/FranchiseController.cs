using Microsoft.AspNetCore.Mvc;
using TunavBackend.Models;
using TunavBackend.Services;

namespace TunavBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FranchiseController : ControllerBase
    {
        private readonly FranchiseService _service;

        public FranchiseController(FranchiseService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Franchise>>> GetAll() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Franchise>> Get(int id)
        {
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        public async Task<ActionResult<Franchise>> Create(Franchise item)
        {
            var created = await _service.AddAsync(item);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Franchise item)
        {
            if (id != item.Id) return BadRequest();
            var ok = await _service.UpdateAsync(item);
            return ok ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _service.DeleteAsync(id);
            return ok ? NoContent() : NotFound();
        }
        //test
    }
}