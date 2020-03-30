using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using cw3_apbd.Services;
using cw3_apbd.Models;

namespace cw3_apbd.Controllers
{
    [Route("api/enrollments")]
    [ApiController]
    public class EnrollementsController : Controller
    {
        private readonly IStudentsDbService _dbStudentServices;

        public EnrollementsController(IStudentsDbService dbService) {
            _dbStudentServices = dbService;
        }

        [HttpPost]
        public IActionResult addStudentIntoSemester(Student student) {
            // Null verification 
            if( !(
                student.BirthDate.Equals("") &&
                student.FirstName.Equals("") &&
                student.LastName.Equals("") &&
                student.IdEnrollment.Equals("") &&
                student.IndexNumber.Equals("") 
                )
            ) return BadRequest("Nie wszystki dane są zapisane");
            return Ok();
        }


        /*
        public IActionResult Index(
        {
            return View();
        }
        */
    }
}