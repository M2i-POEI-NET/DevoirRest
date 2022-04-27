using DevoirRest.BussinessLogic.IServices;
using DevoirRest.BussinessLogic.Services;
using DevoirRest.DTO.ViewModel;
using DevoirRest.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevoirRest.Controller
{
    [Route("api/[controller]")]
    public class ScratchStudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public ScratchStudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public ActionResult Get (int Id)
        {
            var result = _studentService.GetById(Id);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult Post(StudentVM model)
        {
            var result = _studentService.Create(model);
            return Ok(result);
        }
    }
}
