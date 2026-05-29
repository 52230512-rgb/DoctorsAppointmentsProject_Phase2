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
        [HttpDelete("{id}")]
        public IActionResult DeleteDoctor(int id)
        {
            var doctor = _context.Doctors.Find(id);

            if (doctor == null)
                return NotFound("Doctor not found");

            _context.Doctors.Remove(doctor);
            _context.SaveChanges();

            return Ok("Doctor deleted successfully");
        }
        [HttpPut("{id}")]
        public IActionResult UpdateDoctor(int id, Doctors updatedDoctor)
        {
            var doctor = _context.Doctors.Find(id);

            if (doctor == null)
                return NotFound();

            doctor.Name = updatedDoctor.Name;
            doctor.Speciality = updatedDoctor.Speciality;
            doctor.Phone = updatedDoctor.Phone;
            doctor.Day = updatedDoctor.Day;

            _context.SaveChanges();

            return Ok();
        }
    }
}

