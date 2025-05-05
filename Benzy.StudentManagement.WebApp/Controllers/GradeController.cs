using Benzy.StudentManagement.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using WebApp.Service.Repository;

namespace Benzy.StudentManagement.WebApp.Controllers
{
    public class GradeController : Controller
    {
        private readonly IGradesRepository _gradeRepository;

        public GradeController(IGradesRepository gradeRepository)
        {
            _gradeRepository = gradeRepository;
        }

        public async Task<IActionResult> Index()
        {
            var grades = await _gradeRepository.GetAllAsync();
            return View(grades);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Grades grade)
        {
            if (ModelState.IsValid)
            {
                await _gradeRepository.AddAsync(grade);
                return RedirectToAction("Index");
            }
            return View(grade);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var grade = await _gradeRepository.GetByIdAsync(id);
            return View(grade);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Grades grade)
        {
            if (ModelState.IsValid)
            {
                await _gradeRepository.UpdateAsync(grade);
                return RedirectToAction("Index");
            }
            return View(grade);
        }

        public async Task<IActionResult> Details(int id)
        {
            var grade = await _gradeRepository.GetByIdAsync(id);
            return View(grade);
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _gradeRepository.DeleteAsync(id);
            return RedirectToAction("Index");
        }
    }
}
