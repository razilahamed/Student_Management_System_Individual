using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF2.Models;

namespace WPF2.ViewModels
{
    public partial class MainWindowVM : ObservableObject 
    {
        public ObservableCollection<Student> Students { get; set; } 
        [ObservableProperty]
        public Student selectedUser = null;

        public MainWindowVM()
        {
            //Students = new List<Student>()
            Students = new ObservableCollection<Student>()
            {
                new Student (1, "Razil", "Ahamed", "1999/08/04", 3.0 ,"COM"),
                new Student (2, "Aadhil", "Mohamed", "1999/05/18", 2.8, "MENA"),
                new Student (3, "Dhahlan", "Ahamed", "2000/08/18",3.7, "EIE"),
                new Student (3, "Akram", "MAAMS", "1995/08/18",3.3, "CEE"),
                
            };
        }

        [RelayCommand]
        public void AddStudent()
        {
            var addS = new AddStudentVM();
            addS.title = "ADD STUDENT";
            AddDataWin window = new AddDataWin(addS);
            window.ShowDialog();

            if (addS.addStudent.FirstName != null)
            {
                Students.Add(addS.addStudent);
            }
        }

        [RelayCommand]
        public void EditStudent()
        {
            if (selectedUser != null)
            {
                var addS = new AddStudentVM(selectedUser);
                addS.title = "EDIT STUDENT";
                var window = new AddDataWin(addS);

                window.ShowDialog();


                int index = Students.IndexOf(selectedUser);
                Students.RemoveAt(index);
                Students.Insert(index, addS.addStudent);



            }
            else
            {
                MessageBox.Show("Please Select the student", "Warning!");
            }
        }

        [RelayCommand]
        public void DeleteStudent()
        {
            if (selectedUser != null)
            {
                string name = selectedUser.FirstName;
                Students.Remove(selectedUser);
                MessageBox.Show($"{name} is Deleted successfuly.", "DELETED \a ");

            }
            else
            {
                MessageBox.Show("Please Select Student before Delete.", "Error");


            }
        }

    }
}


