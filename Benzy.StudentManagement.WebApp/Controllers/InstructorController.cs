using Benzy.StudentManagement.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp.Service.Repository;

namespace Benzy.StudentManagement.WebApp.Controllers
{
    public class InstructorController : Controller
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorController(IInstructorRepository repository)
        {
            _instructorRepository = repository;
        }

    
        public async Task<IActionResult> Index()
        {
            var instructors = await _instructorRepository.GetAllAsync();
            return View(instructors);
        }

       
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

     
        [HttpPost]
        public async Task<ActionResult> Create(Instructors instructor)
        {
            await _instructorRepository.AddInstructorAsync(instructor);
            return RedirectToAction("Index");
        }

     
        [HttpGet]
        public async Task<ActionResult> Update(int id)
        {
            var instructor = await _instructorRepository.GetInstructorByIdAsync(id);
            if (instructor == null)
                return NotFound();

            return View(instructor);
        }
        [HttpPost]
        public async Task<ActionResult> Update(Instructors instructor)
        {
            await _instructorRepository.UpdateInstructorAsync(instructor);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(int id)
        {
            var instructor = await _instructorRepository.GetInstructorByIdAsync(id);
            if (instructor == null)
                return NotFound();

            return View(instructor);
        }

       
        public async Task<ActionResult> Delete(int id)
        {
            await _instructorRepository.DeleteInstructorAsync(id);
            return RedirectToAction("Index");
        } 
    }
}

