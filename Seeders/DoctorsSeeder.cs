using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;
using EventsAPI.Utils;
using Microsoft.EntityFrameworkCore;

namespace Assessment_Riwi.Seeders
{
    public class DoctorsSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().HasData(
                new Doctor("John Smith", PasswordHasher.HashPassword("password123"), TimeOnly.Parse("08:00"), TimeOnly.Parse("16:00"), "Doctor")
                {
                    Id = 1
                },
                new Doctor("Emily Davis", PasswordHasher.HashPassword("securePass1"), TimeOnly.Parse("09:00"), TimeOnly.Parse("17:00"), "Doctor")
                {
                    Id = 2
                },
                new Doctor("Michael Johnson", PasswordHasher.HashPassword("strongPass2"), TimeOnly.Parse("07:30"), TimeOnly.Parse("15:30"), "Doctor")
                {
                    Id = 3
                },
                new Doctor("Sophia Brown", PasswordHasher.HashPassword("passWord#1"), TimeOnly.Parse("10:00"), TimeOnly.Parse("18:00"), "Doctor")
                {
                    Id = 4
                },
                new Doctor("James Williams", PasswordHasher.HashPassword("passw0rdSafe"), TimeOnly.Parse("06:00"), TimeOnly.Parse("14:00"), "Doctor")
                {
                    Id = 5
                },
                new Doctor("Olivia Martinez", PasswordHasher.HashPassword("medic@pass"), TimeOnly.Parse("13:00"), TimeOnly.Parse("21:00"), "Doctor")
                {
                    Id = 6
                },
                new Doctor("Benjamin Wilson", PasswordHasher.HashPassword("d0ctorPass"), TimeOnly.Parse("12:00"), TimeOnly.Parse("20:00"), "Doctor")
                {
                    Id = 7
                },
                new Doctor("Isabella Miller", PasswordHasher.HashPassword("securePass3"), TimeOnly.Parse("11:00"), TimeOnly.Parse("19:00"), "Doctor")
                {
                    Id = 8
                },
                new Doctor("Elijah Garcia", PasswordHasher.HashPassword("myPass4u!"), TimeOnly.Parse("14:00"), TimeOnly.Parse("22:00"), "Doctor")
                {
                    Id = 9
                },
                new Doctor("Amelia Clark", PasswordHasher.HashPassword("healthPass5"), TimeOnly.Parse("05:30"), TimeOnly.Parse("13:30"), "Doctor")
                {
                    Id = 10
                }
            );
        }
    }
}