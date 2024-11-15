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
                new Doctor("John Smith", PasswordHasher.HashPassword("password123"), "Smith.gomez@email.com", TimeOnly.Parse("08:00"), TimeOnly.Parse("16:00"), "Doctor")
                {
                    Id = 1
                },
                new Doctor("Emily Davis", PasswordHasher.HashPassword("securePass1"), "Davis.gomez@email.com", TimeOnly.Parse("09:00"), TimeOnly.Parse("17:00"), "Doctor")
                {
                    Id = 2
                },
                new Doctor("Michael Johnson", PasswordHasher.HashPassword("strongPass2"), "Johnson.gomez@email.com", TimeOnly.Parse("07:30"), TimeOnly.Parse("15:30"), "Doctor")
                {
                    Id = 3
                },
                new Doctor("Sophia Brown", PasswordHasher.HashPassword("passWord#1"), "Brown.gomez@email.com", TimeOnly.Parse("10:00"), TimeOnly.Parse("18:00"), "Doctor")
                {
                    Id = 4
                },
                new Doctor("James Williams", PasswordHasher.HashPassword("passw0rdSafe"), "James.gomez@email.com", TimeOnly.Parse("06:00"), TimeOnly.Parse("14:00"), "Doctor")
                {
                    Id = 5
                },
                new Doctor("Olivia Martinez", PasswordHasher.HashPassword("medic@pass"), "Olivia.gomez@email.com", TimeOnly.Parse("13:00"), TimeOnly.Parse("21:00"), "Doctor")
                {
                    Id = 6
                },
                new Doctor("Benjamin Wilson", PasswordHasher.HashPassword("d0ctorPass"), "Benjamin.gomez@email.com", TimeOnly.Parse("12:00"), TimeOnly.Parse("20:00"), "Doctor")
                {
                    Id = 7
                },
                new Doctor("Isabella Miller", PasswordHasher.HashPassword("securePass3"), "Miller.gomez@email.com", TimeOnly.Parse("11:00"), TimeOnly.Parse("19:00"), "Doctor")
                {
                    Id = 8
                },
                new Doctor("Elijah Garcia", PasswordHasher.HashPassword("myPass4u!"), "Clark.gomez@email.com", TimeOnly.Parse("14:00"), TimeOnly.Parse("22:00"), "Doctor")
                {
                    Id = 9
                },
                new Doctor("Amelia Clark", PasswordHasher.HashPassword("healthPass5"), "Garcia.gomez@email.com", TimeOnly.Parse("05:30"), TimeOnly.Parse("13:30"), "Doctor")
                {
                    Id = 10
                }
            );
        }
    }
}