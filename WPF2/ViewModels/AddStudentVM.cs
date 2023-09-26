using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using WPF2.Models;

namespace WPF2.ViewModels
{
    public partial class AddStudentVM : ObservableObject 
    {
        [ObservableProperty]
        public int number;
        [ObservableProperty]
        public string firstname;
        [ObservableProperty]
        public string lastname;
        [ObservableProperty]
        public string dateofbirth;
        [ObservableProperty]
        public double gpa;
        [ObservableProperty]
        public string department;
        [ObservableProperty]
        public string title;

        public Student addStudent { get; private set; }
        public AddStudentVM(Student x)
        {
            addStudent = x;

            number = addStudent.Number;
            firstname = addStudent.FirstName;
            lastname = addStudent.LastName;
            dateofbirth = addStudent.DateOfBirth;
            gpa = addStudent.Gpa;
            department = addStudent.Department;
        }

        public AddStudentVM()
        {

        }

        public Action CloseAction { get; internal set; }

        [RelayCommand]
        public void SaveStudent()
        {

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show("GPA value must be between 0 and 4.");
                return;
            }
            if (addStudent == null)
            {

                addStudent = new Student()
                {
                    Number = number,
                    FirstName = firstname,
                    LastName = lastname,
                    DateOfBirth = dateofbirth,
                    Gpa = gpa,
                    Department = department
                };


            }
            else
            {

                addStudent.Number = number;
                addStudent.FirstName = firstname;
                addStudent.LastName = lastname;
                addStudent.DateOfBirth = dateofbirth;
                addStudent.Gpa = gpa; 
                addStudent.Department = department;

            }

            if (addStudent.FirstName != null)
            {

                CloseAction();
            }
            Application.Current.MainWindow.Show();
            return;


        }





    }
}


