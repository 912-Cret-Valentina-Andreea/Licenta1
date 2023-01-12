using elearning.Entities;

namespace elearning.Services
{
    public interface IUserService
    {
        public Task<List<Users>> GetAllUsers();

        public Task<Users> GetUserById(int id);
    }
}
