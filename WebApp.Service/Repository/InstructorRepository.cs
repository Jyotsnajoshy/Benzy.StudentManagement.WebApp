using Benzy.StudentManagement.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using WebApp.Entity1.Data;

namespace WebApp.Service.Repository
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly ApplicationDbContext _context;

        public InstructorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddInstructorAsync(Instructors instructor)
        {
            _context.Instructors.Add(instructor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteInstructorAsync(int id)
        {
            var instructor = await _context.Instructors.FindAsync(id);
            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                await _context.SaveChangesAsync(); 
            }
        }

        public async Task<List<Instructors>> GetAllAsync()
        {
            return await _context.Instructors.ToListAsync();
        }

        public async Task<Instructors> GetInstructorByIdAsync(int id)
        {
            return await _context.Instructors.FindAsync(id);
                              
                               
        }

        public async Task UpdateInstructorAsync(Instructors instructor)
        {
            _context.Instructors.Update(instructor);
            await _context.SaveChangesAsync();
        }

    }
}
