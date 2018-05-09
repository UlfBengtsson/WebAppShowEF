using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAppShowEF.Models
{
    public class Driver
    {
        //[Key]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [ForeignKey("Drives")]
        public int Car_Id { get; set; }
        public Car Drives { get; set; }
    }
}