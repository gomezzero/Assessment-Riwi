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

        [Required(ErrorMessage = "the Address is required")]
        [EmailAddress(ErrorMessage = "the Address isn't valid")]
        [MaxLength(30, ErrorMessage = "Address must be 30 characters or less")]
        public required string Address { get; set; }


        [Required(ErrorMessage = "the Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm 3")]
        public required TimeOnly EntryTime { get; set; }


        [Required(ErrorMessage = "the Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm 4")]
        public required TimeOnly DepartureTime { get; set; }


        [Required(ErrorMessage = "the Role is required")]
        [MaxLength(7, ErrorMessage = "Role must be 10 characters or less")]
        public required string Role { get; set; }
    }
}