using System;
using System.Collections.Generic;

namespace lab33
{
    public class Student
    {
        public int StudentId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Group { get; set; }
        public List<int> Grades { get; set; } = new List<int>();

        public string FullName => $"{LastName} {FirstName} {Patronymic}";

        public int Age
        {
            get
            {
                var today = DateTime.Today;
                var age = today.Year - DateOfBirth.Year;
                if (DateOfBirth > today.AddYears(-age)) age--;
                return age;
            }
        }
    }
}