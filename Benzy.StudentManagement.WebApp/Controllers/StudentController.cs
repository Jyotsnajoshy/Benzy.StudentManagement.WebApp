using Benzy.StudentManagement.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp.Service.Repository;

namespace Benzy.StudentManagement.WebApp.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentRepository studentRepository;
        public StudentController(StudentRepository repository)
        {
            studentRepository = repository;
        }
        public async Task<IActionResult> Index()
        {
            List<Student> studentList = new List<Student>();
            studentList = await studentRepository.GetAllAsync();
            return View(studentList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Student student)
        {

            await studentRepository.AddStudentAsync(student);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Update(int id)
        {
            var person = studentRepository.GetStudentByIdAsync(id);

            return View(person);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Student student)
        {
            await studentRepository.UpdateStudentAsync(student);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(int id)
        {
            var person = await studentRepository.GetStudentByIdAsync(id);
            return View(person);
        }
        public async Task<ActionResult> Delete(int id)
        {
            await studentRepository.DeleteStudentAsync(id);
            return RedirectToAction("Index");
        }

    }
}
