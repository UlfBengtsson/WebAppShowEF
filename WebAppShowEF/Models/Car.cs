using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAppShowEF.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Brand { get; set; }
        [MaxLength(50)]
        [Required]
        public string Model { get; set; }
        public int Year { get; set; }
        [MaxLength(80)]
        public string Color { get; set; }

        public List<Driver> FameDrivers { get; set; }
    }
}