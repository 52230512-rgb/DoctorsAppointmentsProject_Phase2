using DoctorsAppointmentsProject_Phase2.Data;
using DoctorsAppointmentsProject_Phase2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsAppointmentsProject_Phase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DoctorsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(_context.Doctors.ToList());
        }

        [HttpPost]
        public IActionResult AddDoctor([FromBody] Doctors doctor)
        {
            if (string.IsNullOrEmpty(doctor.Name))
            {
                return BadRequest("Doctor name is required");
            }

            _context.Doctors.Add(doctor);
            _context.SaveChanges();

            return Ok("Doctor Added Successfully");
        }
    }
}

