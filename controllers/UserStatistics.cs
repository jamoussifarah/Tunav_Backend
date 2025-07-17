using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TunavBackend.Models;

namespace TunavBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserStatisticsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public UserStatisticsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("track/visit")]
        public async Task<IActionResult> TrackVisit()
        {
            var stats = await GetOrCreateStatsAsync();
            stats.Visitors++;
            stats.LastUpdated = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("track/signup")]
        public async Task<IActionResult> TrackSignUp()
        {
            var stats = await GetOrCreateStatsAsync();
            stats.SignUps++;
            stats.LastUpdated = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPost("track/login")]
        public async Task<IActionResult> TrackLogin()
        {
            var stats = await GetOrCreateStatsAsync();
            stats.Logins++;
            stats.LastUpdated = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpGet("stats")]
        public async Task<ActionResult<UserStatistics>> GetStats()
        {
            var stats = await GetOrCreateStatsAsync();
            return Ok(stats);
        }

        private async Task<UserStatistics> GetOrCreateStatsAsync()
        {
            var stats = await _context.UserStatistics.FirstOrDefaultAsync();
            if (stats == null)
            {
                stats = new UserStatistics();
                _context.UserStatistics.Add(stats);
                await _context.SaveChangesAsync();
            }
            return stats;
        }
    }
}
