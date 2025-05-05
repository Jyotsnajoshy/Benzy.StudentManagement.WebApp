using Benzy.StudentManagement.WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Service.Repository
{
    public interface IInstructorRepository
    {
        Task<List<Instructors>> GetAllAsync();                   
        Task<Instructors> GetInstructorByIdAsync(int id);        
        Task AddInstructorAsync(Instructors instructor);         
        Task DeleteInstructorAsync(int id);                     
        Task UpdateInstructorAsync(Instructors instructor);
    }
}
