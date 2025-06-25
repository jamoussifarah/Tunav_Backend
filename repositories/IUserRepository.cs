using TunavBackend.Models;

namespace TunavBackend.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User?> GetById(int id);
        Task<User> Add(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}