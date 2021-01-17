using System.Collections.Generic;
using System.Linq;

namespace StudentMgmt.Models
{
    public class StudentBusinessLayer
    {
        List<Student> Students;

        public StudentBusinessLayer()
        {
            Students = new List<Student>() {
                new Student()
                {
                    StudentId = 1,
                    FirstName = "Akhil",
                    LastName = "Birdi",
                    Email = "akhil@easyrewardz.com",
                    Password = "Akhil@123",
                    PhoneNumber = "9876543210",
                    Department = "CSE"
                },
                new Student()
                {
                    StudentId = 2,
                    FirstName = "Yamini",
                    LastName = "Tomar",
                    Email = "yamini@easyrewardz.com",
                    Password = "Yamini@123",
                    PhoneNumber = "9876543211",
                    Department = "ECE"
                }
                ,
                new Student()
                {
                    StudentId = 3,
                    FirstName = "Shashi",
                    LastName = "Kiran",
                    Email = "Shashi@easyrewardz.com",
                    Password = "Shashi@123",
                    PhoneNumber = "9876543212",
                    Department = "ECE"
                }
            };
        }

        public List<string> GetDepartment()
        {
            List<string> dept = new List<string>();
            dept = Students.Select(x => x.Department).Distinct().ToList();
            return dept;
        }
        public List<Student> GetStudent(string department)
        {
            return Students.Where(x=> x.Department == department).ToList();
        }

        public Student GetStudentById(int id)
        {
            return Students.Where(x=>x.StudentId == id).First();
        }
    }
}