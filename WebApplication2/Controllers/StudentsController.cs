using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    //https:localhost:port/api/
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetAllStudents() {
            string[] studentNames = new string[] { "Pepe", "Carlos", "Luna" };
            return Ok(studentNames);

        }

        [HttpGet]
        [Route("GetSelectedStudent")]       
        public IActionResult GetSelectedStudent()
        {
            return Ok("the student is ");
        }
    }
}
