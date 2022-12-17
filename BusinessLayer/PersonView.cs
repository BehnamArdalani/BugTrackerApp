﻿using DataAccessLayer;

namespace BusinessLayer
{
    public class PersonView
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? JobTitle { get; set; }
        public Double? Salary { get; set; }
        public int? YearsOfExperience { get; set; }
        public DateTime HiredDate { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public PersonView(Person person)
        {
            Id = person.Id;
            FirstName = person.FirstName;
            LastName = person.LastName;
            JobTitle = person.JobTitle;
            Salary = person.Salary;
            YearsOfExperience = person.YearsOfExperience;
            HiredDate = person.HiredDate;
            Address = person.Address;
            Email = person.Email;
            DateOfBirth = person.DateOfBirth;

        }
    }
}
