using DoctorsAppointmentsProject_Phase2.Data;
using DoctorsAppointmentsProject_Phase2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DoctorsAppointmentsProject_Phase2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AppointmentsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetAppointments()
        {
            return Ok(_context.Appointments.ToList());
        }
        [HttpPost]
        public IActionResult AddAppointment(Appointments appointment)
        {
            if (string.IsNullOrEmpty(appointment.PatientName))
            {
                return BadRequest("Patient name required");
            }

            _context.Appointments.Add(appointment);

            _context.SaveChanges();

            return Ok("Appointment Booked Successfully");
        }
       
    }
}
