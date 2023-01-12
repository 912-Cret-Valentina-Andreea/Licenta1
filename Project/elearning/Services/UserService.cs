using elearning.Entities;

namespace elearning.Services
{
    public class UserService : IUserService
    {
        private readonly DataContext _context;

        public UserService (DataContext context)
        {
            _context = context;
        }
        public async Task<List<Users>> GetAllUsers()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<Users> GetUserById(int id)
        {
            return await _context.Users.FirstAsync(user => user.Id == id);
        }
    }
}
