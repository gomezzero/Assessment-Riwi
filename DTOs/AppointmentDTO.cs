using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_Riwi.DTOs
{
    public class AppointmentDTO
    {
        [Required(ErrorMessage = "the Status is required")]
        public required string Status { get; set; }

        [Required(ErrorMessage = "the Status is required")]
        [MaxLength(300, ErrorMessage = "Description must be 300 characters or less")]
        public required string Description { get; set; }


        [Required(ErrorMessage = "the Time is required")]
        [RegularExpression(@"^([01]?[0-9]|2[0-3]):([0-5][0-9])$", ErrorMessage = "Invalid time format. Please use HH:mm")]
        public required string AppointmentTime { get; set; }


        [Required(ErrorMessage = "the Date is required")]
        public required DateOnly AppointmentDay { get; set; }

        [Required(ErrorMessage = "the user Id is required")]
        public required int PatientId { get; set; }


        [Required(ErrorMessage = "the Event Id is required")]
        public required int Patient { get; set; }
    }
}