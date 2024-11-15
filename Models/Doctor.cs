using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_Riwi.Models
{
    [Table("Doctors")]
    public class Doctor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        [Required]
        [MaxLength(20)]
        [MinLength(2)]
        public string Name { get; set; }

        [Column("password")]
        [Required]
        [MaxLength(60)]
        [MinLength(8)]
        public string Password { get; set; }

        [Column("entry_time")]
        [Required]
        public TimeOnly EntryTime { get; set; }

        [Column("departure_time")]
        [Required]
        public TimeOnly DepartureTime { get; set; }

        [Column("role")]
        [Required]
        public string Role { get; set; }

        public Doctor(string name, string password, TimeOnly entryTime, TimeOnly departureTime,string role)
        {
            Name = name.ToLower().Trim();
            Password = password;
            EntryTime = entryTime;
            DepartureTime = departureTime;
            Role = role.ToLower().Trim();
        }
    }
}