using TunavBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TunavBackend.Services
{
    public class FranchiseService
    {
        private readonly AppDbContext _context;

        public FranchiseService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Franchise>> GetAllAsync() =>
            await _context.Franchises.ToListAsync();

        public async Task<Franchise?> GetByIdAsync(int id) =>
            await _context.Franchises.FirstOrDefaultAsync(f => f.Id == id);

        public async Task<Franchise> AddAsync(Franchise franchise)
        {
            _context.Franchises.Add(franchise);
            await _context.SaveChangesAsync();
            return franchise;
        }

        public async Task<bool> UpdateAsync(Franchise franchise)
        {
            if (!_context.Franchises.Any(f => f.Id == franchise.Id)) return false;
            _context.Entry(franchise).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var item = await _context.Franchises.FindAsync(id);
            if (item == null) return false;
            _context.Franchises.Remove(item);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}