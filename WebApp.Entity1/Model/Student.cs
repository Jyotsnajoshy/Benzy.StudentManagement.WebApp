using System.ComponentModel.DataAnnotations.Schema;

namespace Benzy.StudentManagement.WebApp.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public long StudentPhone { get; set; }
        public string StudentEmail { get; set; }
        public int EnrollmentId { get; set; }
       
        public ICollection<Enrollments> Enrollments { get; set; }
    }
}
