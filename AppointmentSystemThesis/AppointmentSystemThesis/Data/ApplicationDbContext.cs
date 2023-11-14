using AppointmentSystemThesis.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace AppointmentSystemThesis.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        // Existing DbSet for HealthProfile
        public DbSet<PatientModel> HealthProfiles { get; set; }
    }


}
