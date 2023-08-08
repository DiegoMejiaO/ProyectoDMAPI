using ProyectoDMAPI.Data.Models;

namespace ProyectoDMAPI.Services
{
    public interface IUserService
    {
        Task<User>? GetUserAsync(string username, string password);
    }
}
