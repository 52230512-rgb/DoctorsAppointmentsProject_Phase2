using DoctorsAppointmentsProject_Phase2.Models;
using Microsoft.EntityFrameworkCore;

namespace DoctorsAppointmentsProject_Phase2.Data
{
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