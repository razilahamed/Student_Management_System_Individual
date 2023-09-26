using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF2.Models
{
    public class Student
    {

        [Key]
        public int Number { get; set; }
        public string Image { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public double Gpa { get; set; }
        public string Department { get; set; }

        public Student(int number, string firstName, string lastName, string dateOfBirth, double gpa, string department)
        {
            Number = number;
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gpa = gpa;
            Department = department;
        }

        public Student()
        {

        }
    }
}
