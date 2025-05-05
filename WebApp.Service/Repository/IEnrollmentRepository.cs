using Benzy.StudentManagement.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Repository
{
    public interface IEnrollmentRepository
    {
        Task<List<Enrollments>> GetAllAsync();                        
        Task<Enrollments> GetByIdAsync(int id);                      
        Task AddAsync(Enrollments enrollment);                        
        Task UpdateAsync(Enrollments enrollment);                     
        Task DeleteAsync(int id);                                  

        Task<List<Enrollments>> GetByStudentIdAsync(int studentId);  
        Task<List<Enrollments>> GetByCourseIdAsync(int courseId);
    }
}
