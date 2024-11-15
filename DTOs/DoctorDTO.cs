using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_Riwi.DTOs
{
    public class DoctorDTO
    {
        [Required(ErrorMessage = "the Name is required")]
        [MaxLength(20, ErrorMessage = "Name must be 10 characters or less")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters")]
        public required string Name { get; set; }


        [Required(ErrorMessage = "the Password is required")]
        [MaxLength(30, ErrorMessage = "Password must be 30 characters or less")]
        [MinLength(8, ErrorMessage = "Password must be at least 8 characters")]
        public required string Password { get; set; }

        [Required(ErrorMessage = "the Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm")]
        public required string EntryTime { get; set; }


        [Required(ErrorMessage = "the Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm")]
        public required string DepartureTime { get; set; }


        public required string Role = "doctor";
    }
}