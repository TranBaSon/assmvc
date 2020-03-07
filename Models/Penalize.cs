using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PenalizeManagement.Models
{
    public class Penalize
    {
        public int Id { get; set; }
        [Required]
        public string RollNumber { get; set; }
        [Required]
        public Options PenaltyOption { get; set; }
        [Range(0, 1000000)]
        public double amount { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Deadline { get; set; }
    }
    public enum Options
    {
        payment,
        pushUp
    }
}