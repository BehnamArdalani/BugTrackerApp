using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class People
    {
        int PersonId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string JobTitle { get; set; }
        Double Salary { get; set; }
        int YearsOfExperience { get; set; }
        DateTime HiredDate { get; set; }
        string Address { get; set; }
        string Email { get; set; }
        DateTime DateOfBirth { get; set; }

    }
}
