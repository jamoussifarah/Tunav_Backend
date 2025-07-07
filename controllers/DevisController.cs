using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TunavBackend.Models;
using TunavBackend.Services;

namespace TunavBackend.Controllers
{   [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class DevisController : ControllerBase
    {
        private readonly DevisService _service;

        public DevisController(DevisService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var devis = await _service.GetByIdAsync(id);
            return devis == null ? NotFound() : Ok(devis);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DevisCreateRequest request)
        {
            var devis = await _service.AddAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = devis.Id }, devis);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] DevisCreateRequest request)
        {
            var updated = await _service.UpdateAsync(id, request);
            return updated ? NoContent() : NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _service.DeleteAsync(id);
            return deleted ? NoContent() : NotFound();
        }
    }
}