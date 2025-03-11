using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet("GetStudents")]
        public IActionResult GetStudents()
        {
            return Ok();
        }

        [HttpGet("GetStudentById")]
        public IActionResult GetStudentById(int studentId)
        {
            //kontrollo nese ekziston ne db
            //return Ok();

            return NotFound();
        }

        [HttpPost("AddStudent")]
        public IActionResult AddStudent()
        {
            return Ok();
        }

        [HttpPut("UpdateStudent")]
        public IActionResult UpdateStudent()
        {
            return Ok();
        }

        [HttpDelete("DeleteStudent")]
        public IActionResult DeleteStudent()
        {
            return Ok();
        }

    }
}
