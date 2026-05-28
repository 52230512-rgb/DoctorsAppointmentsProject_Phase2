using DoctorsAppointmentsProject_Phase2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DoctorsAppointmentsProject_Phase2.Data
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }

        public DbSet<Doctors> Doctors { get; set; }

        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Login> Logins { get; set; }
    }
}
