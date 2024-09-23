using AutoMapper;
using innovation_task.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using StuForm.BLL.Interfaces;
using StuForm.Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace innovation_task.Controllers
{
    public class StudentController : Controller
    {
        private readonly IUnitOFWork _unitofwork;
        private readonly IMapper _map;

        public StudentController(IUnitOFWork unitofwork , IMapper map)
        {
            _unitofwork = unitofwork;
            _map = map;
        }
        public IActionResult Add()
        {
           
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Add(StudentViewModel stu )
        {
            if (ModelState.IsValid )
            { 
                var Mapstu = _map.Map<StudentViewModel, Student>(stu);
              await  _unitofwork.StuRep.Add(Mapstu);
              return RedirectToAction("Index","Home");
           
            }
            return View(stu);
        }
    }
}
