using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TunavBackend.Models;
using TunavBackend.Services;

namespace TunavBackend.Controllers
{   [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly BlogService _service;

        public BlogController(BlogService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Blog>>> GetAll() =>
            Ok(await _service.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<ActionResult<Blog>> Get(int id)
        {
            var item = await _service.GetByIdAsync(id);
            return item == null ? NotFound() : Ok(item);
        }

        [HttpPost]
        [RequestSizeLimit(100_000_000)]
        public async Task<ActionResult<Blog>> Create([FromForm] BlogCreateRequest request)
        {
            var created = await _service.AddAsync(request);
            return CreatedAtAction(nameof(Get), new { id = created.Id }, created);
        }

        [HttpPut("{id}")]
        [RequestSizeLimit(100_000_000)]
        public async Task<IActionResult> Update(int id, [FromForm] BlogUpdateRequest request)
        {
            var result = await _service.UpdateAsync(id, request);
            if (!result) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var ok = await _service.DeleteAsync(id);
            return ok ? NoContent() : NotFound();
        }
        
        [HttpPost("{id}/like")]
        public async Task<IActionResult> IncrementLike(int id)
        {
            var blog = await _service.IncrementLikeAsync(id);
            if (blog == null)
                return NotFound();

            return Ok(new { message = "Like ajouté", likes = blog.Likes });
        }
 }
}
