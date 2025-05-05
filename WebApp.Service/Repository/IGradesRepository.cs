using Benzy.StudentManagement.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Repository
{
    public interface IGradesRepository
    {
        Task<Grades> GetByIdAsync(int id);                
        Task AddAsync(Grades grade);                       
        Task UpdateAsync(Grades grade);                    
        Task DeleteAsync(int id);
        Task<List<Grades>> GetByStudentIdAsync(int studentId);
        Task<List<Grades>> GetAllAsync();
    }
}
