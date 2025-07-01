using TunavBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace TunavBackend.Services
{
    public class BlogService
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BlogService(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IEnumerable<Blog>> GetAllAsync() =>
            await _context.Blogs
                         .Include(b => b.Tags)
                         .ToListAsync();

        public async Task<Blog?> GetByIdAsync(int id) =>
            await _context.Blogs
                         .Include(b => b.Tags)
                         .FirstOrDefaultAsync(b => b.Id == id);

        public async Task<Blog> AddAsync(BlogCreateRequest request)
        {
            string imagePath = string.Empty;

            if (request.Image != null)
                imagePath = await SaveImageAsync(request.Image);

            var blog = new Blog
            {
                Titre = request.Titre,
                Contenu = request.Contenu,
                UserId = request.UserId,
                ImagePath = imagePath,
                DatePublication = DateTime.UtcNow
            };

            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();

            // Ajout des tags
            foreach (var tagName in request.Tags)
            {
                _context.Tags.Add(new Tag { Nom = tagName, BlogId = blog.Id });
            }
            await _context.SaveChangesAsync();

            return blog;
        }

        public async Task<bool> UpdateAsync(int id, BlogUpdateRequest request)
        {
            var blog = await _context.Blogs.Include(b => b.Tags).FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null) return false;

            blog.Titre = request.Titre;
            blog.Contenu = request.Contenu;

            // Gestion de l'image
            if (request.NewImage != null)
            {
                if (!string.IsNullOrEmpty(blog.ImagePath))
                    DeleteImage(blog.ImagePath);

                blog.ImagePath = await SaveImageAsync(request.NewImage);
            }

            _context.Tags.RemoveRange(blog.Tags);

            foreach (var tagName in request.Tags)
            {
                _context.Tags.Add(new Tag { Nom = tagName, BlogId = blog.Id });
            }

            await _context.SaveChangesAsync();

            return true;
        }
        public async Task<bool> DeleteAsync(int id)
        {
            var blog = await _context.Blogs.Include(b => b.Tags).FirstOrDefaultAsync(b => b.Id == id);
            if (blog == null) return false;

            if (!string.IsNullOrEmpty(blog.ImagePath))
                DeleteImage(blog.ImagePath);

            _context.Tags.RemoveRange(blog.Tags);
            _context.Blogs.Remove(blog);

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

            return "/uploads/" + fileName;
        }

        private void DeleteImage(string imagePath)
        {
            var fullPath = Path.Combine(_env.WebRootPath, imagePath.TrimStart('/').Replace('/', Path.DirectorySeparatorChar));
            if (File.Exists(fullPath))
                File.Delete(fullPath);
        }
         public async Task<Blog?> IncrementLikeAsync(int id)
        {
            var blog = await _context.Blogs.FindAsync(id);
            if (blog == null) return null;

            blog.Likes++;
            await _context.SaveChangesAsync();

            return blog;
        }


    }


}
