using elearning.Entities;

namespace elearning.Services
{
    public interface IClassService
    {
        public Task<List<Classes>> GetAllClasses();
        public Task<bool> CreateClass(Classes newClass);
    }
}
