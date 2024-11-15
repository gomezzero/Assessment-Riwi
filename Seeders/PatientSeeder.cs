using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;
using EventsAPI.Utils;
using Microsoft.EntityFrameworkCore;

namespace Assessment_Riwi.Seeders
{
public class PatientSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Patient>().HasData(
            new Patient("Alice Green", "alice.green@example.com", PasswordHasher.HashPassword("patientPass1"), "Patient")
            {
                Id = 1
            },
            new Patient("Bob Brown", "bob.brown@example.com", PasswordHasher.HashPassword("patientPass2"), "Patient")
            {
                Id = 2
            },
            new Patient("Charlie White", "charlie.white@example.com", PasswordHasher.HashPassword("patientPass3"), "Patient")
            {
                Id = 3
            },
            new Patient("Diana Black", "diana.black@example.com", PasswordHasher.HashPassword("patientPass4"), "Patient")
            {
                Id = 4
            },
            new Patient("Edward Harris", "edward.harris@example.com", PasswordHasher.HashPassword("patientPass5"), "Patient")
            {
                Id = 5
            },
            new Patient("Fiona Scott", "fiona.scott@example.com", PasswordHasher.HashPassword("patientPass6"), "Patient")
            {
                Id = 6
            },
            new Patient("George Clark", "george.clark@example.com", PasswordHasher.HashPassword("patientPass7"), "Patient")
            {
                Id = 7
            },
            new Patient("Hannah King", "hannah.king@example.com", PasswordHasher.HashPassword("patientPass8"), "Patient")
            {
                Id = 8
            },
            new Patient("Ian Wilson", "ian.wilson@example.com", PasswordHasher.HashPassword("patientPass9"), "Patient")
            {
                Id = 9
            },
            new Patient("Julia Turner", "julia.turner@example.com", PasswordHasher.HashPassword("patientPass10"), "Patient")
            {
                Id = 10
            }
        );
    }
}
}