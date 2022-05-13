using DevoirRest.BussinessLogic.IServices;
using DevoirRest.BussinessLogic.Services;
using DevoirRest.DTO.ViewBindingModel;
using DevoirRest.DTO.ViewModel;
using DevoirRest.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        [HttpGet("Get_from_urlAsync")]
        public async Task<IActionResult> Get_from_urlAsync ()
        {
            StudentVBM student = new StudentVBM();
            string result = "";
            using (var httpClient = new HttpClient())
            {
                using var response = await httpClient.GetAsync("http://localhost:5000/api/ScratchStudent?Id=1");
                string apiResponse = await response.Content.ReadAsStringAsync();
                student = JsonConvert.DeserializeObject<StudentVBM>(apiResponse);
                result = apiResponse;
            }
            return Ok(student);
        }
    }
}
