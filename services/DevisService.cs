using Microsoft.EntityFrameworkCore;
using TunavBackend.Models;

namespace TunavBackend.Services
{
    public class DevisService
    {
        private readonly AppDbContext _context;

        public DevisService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Devis>> GetAllAsync() =>
            await _context.Devis.ToListAsync();

        public async Task<Devis?> GetByIdAsync(int id) =>
            await _context.Devis
            .Include(d => d.produitDevis)
            .Include(d => d.userDevis)
            .FirstOrDefaultAsync(d => d.Id == id);

        public async Task<Devis> AddAsync(DevisCreateRequest request)
        {
            var devis = new Devis
            {
                Nom = request.Nom,
                Prenom = request.Prenom,
                Email = request.Email,
                Entreprise = request.Entreprise,
                Message = request.Message,
                Quantite = request.Quantite,
                UserId = request.UserId,
                ProduitAvecDevisId = request.ProduitAvecDevisId
            };

            _context.Devis.Add(devis);
            await _context.SaveChangesAsync();

            return devis;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var devis = await _context.Devis.FindAsync(id);
            if (devis == null) return false;

            _context.Devis.Remove(devis);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(int id, DevisCreateRequest request)
        {
            var devis = await _context.Devis.FindAsync(id);
            if (devis == null) return false;

            devis.Nom = request.Nom;
            devis.Prenom = request.Prenom;
            devis.Email = request.Email;
            devis.Entreprise = request.Entreprise;
            devis.Message = request.Message;
            devis.Quantite = request.Quantite;
            devis.UserId = request.UserId;
            devis.ProduitAvecDevisId = request.ProduitAvecDevisId;

            await _context.SaveChangesAsync();
            return true;
        }
        
    }
    
}