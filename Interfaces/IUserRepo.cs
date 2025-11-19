using FitnessWG.Data;
using FitnessWG.Models;

namespace FitnessWG.Interfaces
{
    public interface IUserRepo
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> UserDetailsAsync(int id);
        Task<User> CreateUserAsync(User user);  
        Task<User> UpdateUserAsync(User user);
        Task<User> DeleteUserAsync(User user);
        Task<bool> IsExistAsync(int id);    
    }
}
