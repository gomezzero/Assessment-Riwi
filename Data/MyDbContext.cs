using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;
using Assessment_Riwi.Seeders;
using Microsoft.EntityFrameworkCore;

namespace Assessment_Riwi.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DoctorsSeeder.Seed(modelBuilder);
            PatientSeeder.Seed(modelBuilder);
            AppointmentSeeder.Seed(modelBuilder);
        }
    }
}