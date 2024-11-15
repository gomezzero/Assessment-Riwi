using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_Riwi.Models
{
    [Tags("appointments")]
    public class Appointment
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("status")]
        [Required]
        public string Status { get; set; }

        [Column("appointment_time")]
        [Required]
        public TimeOnly AppointmentTime { get; set; }

        [Column("appointment_day")]
        [Required]
        public DateOnly AppointmentDay { get; set; }

        // forein Key
        [Column("patient_id")]
        public int PatientId { get; set; }

        [Column("doctor_id")]
        public int DoctorId { get; set; }

        // conection forein key
        [ForeignKey("PatientId")]
        public Patient? Patient { get; set; }

        [ForeignKey("DoctorId")]
        public Doctor? Doctor { get; set; }

        public Appointment(string status, TimeOnly appointmentTime, DateOnly appointmentDay, int patientId, int doctorId) 
        {
            Status = status.ToLower().Trim();
            AppointmentTime = appointmentTime;
            AppointmentDay = appointmentDay;
            PatientId = patientId;
            DoctorId = doctorId;
        }
    }
}