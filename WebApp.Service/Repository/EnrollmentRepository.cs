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
    public class EnrollmentRepository:IEnrollmentRepository
    {
        private readonly ApplicationDbContext _context;

        public EnrollmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Enrollments enrollment)
        {
            _context.Enrollments.Add(enrollment);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment != null)
            {
                _context.Enrollments.Remove(enrollment);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Enrollments>> GetAllAsync()
        {
            return await _context.Enrollments.ToListAsync();
        }

        public async Task<Enrollments> GetByIdAsync(int id)
        {
            return await _context.Enrollments.FindAsync(id);
        }

        public async Task<List<Enrollments>> GetByStudentIdAsync(int studentId)
        {
            return await _context.Enrollments.ToListAsync();
        }

        public async Task<List<Enrollments>> GetByCourseIdAsync(int courseId)
        {
            return await _context.Enrollments.ToListAsync();
        }

        public async Task UpdateAsync(Enrollments enrollment)
        {
            _context.Enrollments.Update(enrollment);
            await _context.SaveChangesAsync();
        }
    }
}
