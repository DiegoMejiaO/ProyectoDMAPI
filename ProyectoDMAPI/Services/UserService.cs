using ProyectoDMAPI.Data.Models;
using ProyectoDMAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace ProyectoDMAPI.Services
{
    public class UserService : IUserService
    {
        private readonly ProyectoDMAPIDbContext _context;


        public UserService(ProyectoDMAPIDbContext context)
        {
            _context = context;
        }

        public async Task<User>? GetUserAsync(string username, string password)
        {
            if (_context.Users == null)
            {
                return null;
            }
            var user = await _context.Users.Include(u => u.Role).FirstOrDefaultAsync(user => user.UserName == username && user.Password == password);

            return user;
        }
    }
}
