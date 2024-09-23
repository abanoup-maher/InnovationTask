using InnovationTask.Bll.Interface;
using InnovationTask.Bll.Repository;
using InnovationTask.DAL.Context;
using InnovationTask.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InnovationTask1.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOfWork _unitofwork;

        public StudentController(StudentInfoDbContext context , IUnitOfWork unitofwork)
        {
            _unitofwork = unitofwork;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AddStudent()
        {
            var subjects = await _unitofwork.SubjectRepo.GetAll();

            ViewBag.subjects = subjects;
            return View();

            
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddStudent(Student stu, int[] selectedsubj)
        {
          
            if (ModelState.IsValid)
            {
                stu.SelectedSubjectIds = selectedsubj != null ? string.Join(",", selectedsubj) : string.Empty;
                await _unitofwork.StuRepo.Add(stu);
                await _unitofwork.save();
                TempData["SuccessMessage"] = "Student added successfully!"; // message for add student successfully
                return RedirectToAction("Index", "Home");
            }   
            return View(stu);
        }
    }
}
