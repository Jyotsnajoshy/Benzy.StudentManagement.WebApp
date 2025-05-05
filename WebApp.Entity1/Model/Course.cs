namespace Benzy.StudentManagement.WebApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int InstroctorId { get; set; }
        public Instructors Instructors { get; set; }
        public ICollection<Enrollments> Enrollments { get; set; }

    }
}
