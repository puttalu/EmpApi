using System;
using System.ComponentModel.DataAnnotations;

namespace EmployeeApi.Models
{
    public class Employee
    {
        [Key]
        public int emp_id { get; set; }

        [Required]
        public required string emp_firstname { get; set; }

        [Required]
        public required string emp_lastname { get; set; }

        [Required]
        public required string emp_dept { get; set; }

        [Required]
        public decimal emp_compensation { get; set; }

        [Required]
        public DateTime emp_startdate { get; set; }
    }
}
