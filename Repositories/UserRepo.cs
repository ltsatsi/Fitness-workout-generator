using FitnessWG.Data;
using FitnessWG.Interfaces;
using FitnessWG.Models;
using Microsoft.EntityFrameworkCore;

namespace FitnessWG.Repositories
{
    public class UserRepo : IUserRepo
    {
        private SQLiteDBContext _context;
        public UserRepo(SQLiteDBContext context)
        {
            _context = context;
        }
        public async Task<User> CreateUserAsync(User user)
        {
            await _context.Users.AddAsync(user);
            _context.SaveChanges();

            return user;
        }

        public async Task<User> DeleteUserAsync(User user)  
        {
            if (await IsExistAsync(user.UserId))
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }

            return user;
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync() 
        {
            var users = await _context.Users
                .Include(u => u.Workout)
                .ToListAsync();

            return users;
        }

        public async Task<bool> IsExistAsync(int id)    
        {
            bool isExist = false;
            var user = await _context.Users.
                FirstOrDefaultAsync(u => u.UserId == id);
            if (user != null)
            {
                isExist = true;
            }

            return isExist;
        }

        public async Task<User> UpdateUserAsync(User user)
        {   
            if (await IsExistAsync(user.UserId))
            {
                _context.Users.Update(user);
                _context.SaveChanges();
            }

            return user;
        }

        public async Task<User> UserDetailsAsync(int id)
        {
            var user = await _context.Users
                .Include(u => u.Workout)
                .FirstOrDefaultAsync(u => u.UserId == id);

            return user;
        }
    }
}
