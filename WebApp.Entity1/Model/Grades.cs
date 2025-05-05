using System.ComponentModel.DataAnnotations;

namespace Benzy.StudentManagement.WebApp.Models
{
    public class Grades
    {
        [Key]
        public int GradeId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public char Grade { get; set; }
        public int EnrollmentId { get; set; }
        public Enrollments Enrollments { get; set; }

    }
}
