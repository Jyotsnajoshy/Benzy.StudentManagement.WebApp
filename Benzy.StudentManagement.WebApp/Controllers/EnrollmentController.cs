using Benzy.StudentManagement.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp.Service.Repository;

namespace Benzy.StudentManagement.WebApp.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly IEnrollmentRepository _enrollmentRepository;

        public EnrollmentController(IEnrollmentRepository repository)
        {
            _enrollmentRepository = repository;
        }

        public async Task<IActionResult> Index()
        {
            var enrollments = await _enrollmentRepository.GetAllAsync();
            return View(enrollments);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Enrollments enrollment)
        {
            await _enrollmentRepository.AddAsync(enrollment);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Update(int id)
        {
            var enrollment = await _enrollmentRepository.GetByIdAsync(id);
   
            return View(enrollment);
        }

        [HttpPost]
        public async Task<ActionResult> Update(Enrollments enrollment)
        {
            await _enrollmentRepository.UpdateAsync(enrollment);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(int id)
        {
            var enrollment = await _enrollmentRepository.GetByIdAsync(id);

            return View(enrollment);
        }

        public async Task<ActionResult> Delete(int id)
        {
            await _enrollmentRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
