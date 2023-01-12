using elearning.Entities;

namespace elearning.Services
{
    public class ClassService : IClassService
    {
        private readonly DataContext _context;

        public ClassService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Classes>> GetAllClasses()
        {
            return await _context.Classes.ToListAsync();
        }

        public async Task<bool> CreateClass(Classes newClass)
        {
            _context.Classes.Add(newClass);

            await (_context.SaveChangesAsync());
            return true;
        }

    }
}
