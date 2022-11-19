using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Person
    {
        public int Id { get; set; }
        [StringLength(50)] public string FirstName { get; set; }
        [StringLength(50)] public string LastName { get; set; }
        [StringLength(50)] public string? JobTitle { get; set; }
        public Double? Salary { get; set; }
        public int? YearsOfExperience { get; set; }
        public DateTime HiredDate { get; set; }
        [StringLength(200)] public string? Address { get; set; }
        [StringLength(100)] public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

    }
}
