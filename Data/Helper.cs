using System;
using System.Collections.Generic;
using Registrar.Models;  

namespace Registrar.Data

{
    public class Helper
    {
        private static int _nextId = 1; // Static counter for generating unique IDs

        static Helper()
        {
            Courses = GetCourses();
            StudentTypes = GetStudentTypes();
            Students = GetStudents();
        }
        public static List<string> StudentTypes { get; private set; }
        public static List<Student> Students { get; private set; }
        public static List<Course> Courses { get; private set; }

        public static List<Course> GetCourses()
        {
            List<Course> courses = new List<Course>();

            Course course = new Course
            {
                Code = "CST8282",
                Title = "Introduction to Database Systems",
                WeeklyHours = 4
            };
            courses.Add(course);

            course = new Course
            {
                Code = "CST8253",
                Title = "Web Programming II",
                WeeklyHours = 2
            };
            courses.Add(course);

            course = new Course
            {
                Code = "CST8256",
                Title = "Web Programming Language I",
                WeeklyHours = 5
            };
            courses.Add(course);

            course = new Course
            {
                Code = "CST8255",
                Title = "Web Imaging and Animations",
                WeeklyHours = 2
            };
            courses.Add(course);

            course = new Course
            {
                Code = "CST8254",
                Title = "Network Operating System",
                WeeklyHours = 1
            };
            courses.Add(course);

            course = new Course
            {
                Code = "CST2200",
                Title = "Data Warehouse Design",
                WeeklyHours = 3
            };
            courses.Add(course);

            course = new Course
            {
                Code = "CST2240",
                Title = "Advance Database topics",
                WeeklyHours = 1
            };
            courses.Add(course);

            return courses;
        }

        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student
            {
                Id = 437374,
                FirstName = "Grace",
                LastName = "Desmond",
                Type = "Part Time",
                Action = "Register"
            });

            students.Add(new Student
            {
                Id = 457902,
                FirstName = "Gimmy",
                LastName = "Jones",
                Type = "Full Time",
                Action = "Register"
            });

            students.Add(new Student
            {
                Id = 877694,
                FirstName = "Mary",
                LastName = "Smail",
                Type = "Coop",
                Action = "Register"
            });

            students.Add(new Student
            {
                Id = 788945,
                FirstName = "Precious",
                LastName = "Dabere",
                Type = "Full Time",
                Action = "Register"
            });

            students.Add(new Student
            {
                Id = 434994,
                FirstName = "Nicole",
                LastName = "Kennedy",
                Type = "Coop",
                Action = "Register"
            });

            return students;
        }

        public static List<string> GetStudentTypes()
        {
            return new List<string> { "Full Time", "Part Time", "Coop" };
        }
        public static Student? GetStudentById(int id)
        {
            return GetStudents().FirstOrDefault(s => s.Id == id);
        }
        private static int GenerateId()
        {
            return _nextId++;
        }
    }
}
