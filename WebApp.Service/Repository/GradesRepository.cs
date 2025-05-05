using Benzy.StudentManagement.WebApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApp.Entity1.Data;

namespace WebApp.Service.Repository
{
    public class GradesRepository: IGradesRepository
    {
        private readonly ApplicationDbContext _context;

        public GradesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Grades grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var grade = await _context.Grades.FindAsync(id);
            if (grade != null)
            {
                _context.Grades.Remove(grade);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Grades>> GetAllAsync()
        {
            return await _context.Grades.ToListAsync();
        }

        public async Task<Grades> GetByIdAsync(int id)
        {
            return await _context.Grades.FindAsync(id);
        }

        public async Task<List<Grades>> GetByStudentIdAsync(int studentId)
        {
            return await _context.Grades.ToListAsync();
        }

       
        public async Task UpdateAsync(Grades grade)
        {
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
        }
    }
}
