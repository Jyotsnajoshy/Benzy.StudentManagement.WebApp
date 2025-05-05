using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Benzy.StudentManagement.WebApp.Models;

namespace WebApp.Service.Repository
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
        Task UpdateStudentAsync(Student student);
    }
}
