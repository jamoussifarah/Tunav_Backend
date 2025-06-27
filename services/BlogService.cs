using TunavBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TunavBackend.Services
{
    public class BlogService
    {
        private readonly AppDbContext _context;

        public BlogService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Blog>> GetAllAsync() =>
            await _context.Blogs.Include(b => b.User).ToListAsync();

        public async Task<Blog?> GetByIdAsync(int id) =>
            await _context.Blogs.Include(b => b.User).FirstOrDefaultAsync(b => b.Id == id);

        public async Task<Blog> AddAsync(Blog blog)
        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
            return blog;
        }

        public async Task<bool> UpdateAsync(Blog blog)
        {
            if (!_context.Blogs.Any(b => b.Id == blog.Id)) return false;
            _context.Entry(blog).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await _context.Blogs.FindAsync(id);
            if (item == null) return false;
            _context.Blogs.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}