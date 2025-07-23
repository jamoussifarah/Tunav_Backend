using System.Text.Json;
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

        [HttpGet("count/IOT")]
        public async Task<IActionResult> GetNumberDevisWithProduit()
        {
            var count = await _service.GetNumberDevisWithProduitAsync();
            return Ok(new { DevisWithProduit = count });
        }

        [HttpGet("count/IT")]
        public async Task<IActionResult> GetNumberDevisWithoutProduit()
        {
            var count = await _service.GetNumberDevisWithoutProduitAsync();
            return Ok(new { DevisWithoutProduit = count });
        }
            
        [HttpPatch("{id}/etat")]
        public async Task<IActionResult> ChangerEtat(int id, [FromBody] JsonElement body)
        {
            if (!body.TryGetProperty("etat", out var etatProp))
                return BadRequest("Le champ 'etat' est requis.");

            if (!Enum.TryParse<EtatDevis>(etatProp.GetString(), out var nouvelEtat))
                return BadRequest("État invalide.");

            var devis = await _service.ChangerEtatAsync(id, nouvelEtat);
            if (devis == null)
                return NotFound();

            return Ok(devis);
        }
    
            }
}