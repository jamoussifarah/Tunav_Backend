using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TunavBackend.Models;
using TunavBackend.Services;

namespace TunavBackend.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class ProduitsAvecDevisController : ControllerBase
    {
        private readonly ProduitAvecDevisService _service;

        public ProduitsAvecDevisController(ProduitAvecDevisService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var produit = await _service.GetByIdAsync(id);
            return produit == null ? NotFound() : Ok(produit);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm] ProduitAvecDevisCreateRequest request)
        {
            var produit = await _service.AddAsync(request);
            return CreatedAtAction(nameof(GetById), new { id = produit.Id }, produit);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromForm] ProduitAvecDevisUpdateRequest request)
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
