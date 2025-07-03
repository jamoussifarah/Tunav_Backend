using TunavBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TunavBackend.Services
{
    public class ProduitAvecDevisService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProduitAvecDevisService(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IEnumerable<ProduitAvecDevis>> GetAllAsync() =>
            await _context.ProduitsAvecDevis
                          .Include(p => p.Caracteristiques)
                          .Include(p => p.Devis)
                          .ToListAsync();

        public async Task<ProduitAvecDevis?> GetByIdAsync(int id) =>
            await _context.ProduitsAvecDevis
                          .Include(p => p.Caracteristiques)
                          .Include(p => p.Devis)
                          .FirstOrDefaultAsync(p => p.Id == id);

        public async Task<ProduitAvecDevis> AddAsync(ProduitAvecDevisCreateRequest request)
        {
            string imagePath = string.Empty;

            if (request.Image != null)
                imagePath = await SaveImageAsync(request.Image);

            var produit = new ProduitAvecDevis
            {
                Titre = request.Titre,
                Description = request.Description,
                Categorie = request.Categorie,
                ImagePath = imagePath
            };

            _context.ProduitsAvecDevis.Add(produit);
            await _context.SaveChangesAsync();

            foreach (var carac in request.Caracteristiques)
            {
                _context.CaracteristiquesProduitAvecDevis.Add(new CaracteristiqueProduitAvecDevis
                {
                    Texte = carac,
                    ProduitAvecDevisId = produit.Id
                });
            }

            await _context.SaveChangesAsync();
            return produit;
        }

        public async Task<bool> UpdateAsync(int id, ProduitAvecDevisUpdateRequest request)
        {
            var produit = await _context.ProduitsAvecDevis
                                        .Include(p => p.Caracteristiques)
                                        .FirstOrDefaultAsync(p => p.Id == id);
            if (produit == null) return false;

            produit.Titre = request.Titre;
            produit.Description = request.Description;
            produit.Categorie = request.Categorie;

            if (request.NewImage != null)
            {
                if (!string.IsNullOrEmpty(produit.ImagePath))
                    DeleteImage(produit.ImagePath);

                produit.ImagePath = await SaveImageAsync(request.NewImage);
            }

            _context.CaracteristiquesProduitAvecDevis.RemoveRange(produit.Caracteristiques);

            foreach (var carac in request.Caracteristiques)
            {
                _context.CaracteristiquesProduitAvecDevis.Add(new CaracteristiqueProduitAvecDevis
                {
                    Texte = carac,
                    ProduitAvecDevisId = produit.Id
                });
            }

            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var produit = await _context.ProduitsAvecDevis
                                        .Include(p => p.Caracteristiques)
                                        .Include(p => p.Devis)
                                        .FirstOrDefaultAsync(p => p.Id == id);
            if (produit == null) return false;

            if (!string.IsNullOrEmpty(produit.ImagePath))
                DeleteImage(produit.ImagePath);

            _context.CaracteristiquesProduitAvecDevis.RemoveRange(produit.Caracteristiques);
            _context.Devis.RemoveRange(produit.Devis ?? new List<Devis>());
            _context.ProduitsAvecDevis.Remove(produit);
            await _context.SaveChangesAsync();

            return true;
        }

        private async Task<string> SaveImageAsync(IFormFile image)
        {
            var uploads = Path.Combine(_env.WebRootPath, "uploads");
            Directory.CreateDirectory(uploads);

            var fileName = Guid.NewGuid() + Path.GetExtension(image.FileName);
            var filePath = Path.Combine(uploads, fileName);

            using var stream = new FileStream(filePath, FileMode.Create);
            await image.CopyToAsync(stream);

            return $"/uploads/{fileName}";
        }

        private void DeleteImage(string imagePath)
        {
            var fullPath = Path.Combine(_env.WebRootPath, imagePath.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
            if (File.Exists(fullPath))
                File.Delete(fullPath);
        }
    }
}
