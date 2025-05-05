namespace Benzy.StudentManagement.WebApp.Models
{
    public class Instructors
    {
        public int InstructorsId { get; set; }
        public string InstructorsName { get; set; }
        public long InstructorsPhone { get; set; }
        public string InstructorsEmail { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
