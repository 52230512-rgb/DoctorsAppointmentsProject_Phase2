using DoctorsAppointmentsProject_Phase2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsAppointmentsProject_Phase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login(Login model)
        {
            if (string.IsNullOrEmpty(model.Username))
            {
                return BadRequest("Username required");
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                return BadRequest("Password required");
            }

            return Ok("Login Success");
        }
    }
}
