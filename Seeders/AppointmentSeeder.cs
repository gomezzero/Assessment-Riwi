using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_Riwi.Models;
using Microsoft.EntityFrameworkCore;

public class AppointmentSeeder
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>().HasData(
            new Appointment("Scheduled", TimeOnly.Parse("09:30"), DateOnly.FromDateTime(DateTime.Now.AddDays(3)), 1, 2) // Emily Davis, 09:30 - 17:00
            {
                Id = 1
            },
            new Appointment("Scheduled", TimeOnly.Parse("14:15"), DateOnly.FromDateTime(DateTime.Now.AddDays(5)), 2, 6) // Olivia Martinez, 13:00 - 21:00
            {
                Id = 2
            },
            new Appointment("Completed", TimeOnly.Parse("08:45"), DateOnly.FromDateTime(DateTime.Now.AddDays(-1)), 3, 1) // John Smith, 08:00 - 16:00
            {
                Id = 3
            },
            new Appointment("Canceled", TimeOnly.Parse("11:00"), DateOnly.FromDateTime(DateTime.Now.AddDays(7)), 4, 8) // Isabella Miller, 11:00 - 19:00
            {
                Id = 4
            },
            new Appointment("Scheduled", TimeOnly.Parse("15:00"), DateOnly.FromDateTime(DateTime.Now.AddDays(10)), 5, 9) // Elijah Garcia, 14:00 - 22:00
            {
                Id = 5
            },
            new Appointment("Rescheduled", TimeOnly.Parse("12:30"), DateOnly.FromDateTime(DateTime.Now.AddDays(15)), 6, 5) // James Williams, 06:00 - 14:00
            {
                Id = 6
            },
            new Appointment("Scheduled", TimeOnly.Parse("07:45"), DateOnly.FromDateTime(DateTime.Now.AddDays(12)), 7, 3) // Michael Johnson, 07:30 - 15:30
            {
                Id = 7
            },
            new Appointment("Completed", TimeOnly.Parse("13:45"), DateOnly.FromDateTime(DateTime.Now.AddDays(-5)), 8, 7) // Benjamin Wilson, 12:00 - 20:00
            {
                Id = 8
            },
            new Appointment("Scheduled", TimeOnly.Parse("10:30"), DateOnly.FromDateTime(DateTime.Now.AddDays(8)), 9, 4) // Sophia Brown, 10:00 - 18:00
            {
                Id = 9
            },
            new Appointment("Scheduled", TimeOnly.Parse("06:15"), DateOnly.FromDateTime(DateTime.Now.AddDays(2)), 10, 5) // James Williams, 06:00 - 14:00
            {
                Id = 10
            }
        );
    }
}