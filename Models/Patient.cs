using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_Riwi.Models
{
    [Table("patient")]
    public class Patient
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

        [Column("address")]
        [Required]
        [EmailAddress]
        [MaxLength(30)]
        public string Address { get; set; }

        [Column("password")]
        [Required]
        [MaxLength(60)]
        [MinLength(8)]
        public string Password { get; set; }

        [Column("role")]
        [MaxLength(10)]
        public string Role { get; set; }

        public Patient(string name, string address, string password, string role)
        {
            Name = name.ToLower().Trim();
            Address = address.ToLower().Trim();
            Password = password;
            Role = role;
        }
    }
}