namespace Benzy.StudentManagement.WebApp.Models
{
    public class Enrollments
    {
        public int EnrollmentId { get; set; }
        public int CourseId { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public Course Courses { get; set; }
        public Grades Grades { get; set; }

    }
}
