using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UserManagment.Data.Entities;

namespace UserManagment.Data.Repository
{
    public interface IUserRepository {
        Task<string> AddUserAsync(User user);
        Task<ActionResult<IEnumerable<User>>> GetUsers();
    }

    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<string> AddUserAsync(User user)
        {
            var checkUser = await _context.Users.AnyAsync(u => u.Username == user.Username);
            if (!checkUser)
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return "User successfully added!";
            }
            else
            {
                return "User already exists!";
            }
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUsers()
        {
            return await _context.Users.ToListAsync();
        }


    }
}
