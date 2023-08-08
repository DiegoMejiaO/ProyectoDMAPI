using ProyectoDMAPI.Data.Models;

namespace ProyectoDMAPI.Services
{
    public interface IAccountService
    {
        string GenerateJwtToken(User user);
    }
}
