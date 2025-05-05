using Benzy.StudentManagement.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Repository
{
    public interface ICourseRepository
    {
        Task<List<Course>> GetAllAsync();              
        Task<Course> GetByIdAsync(int id);               
        Task AddAsync(Course course);                  
        Task UpdateAsync(Course course);                 
        Task DeleteAsync(int id);
    }
}
