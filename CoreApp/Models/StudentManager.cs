using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApp.Models
{
    public class StudentManager
    {
        private static List<Student> _students;

        static StudentManager()
        {
            _students = new List<Student>
            {
                new Student{Id = 1, FirstName="John", LastName="Ini", Phone="403-201-908"},
                new Student{Id = 2, FirstName="Mark", LastName="Paul", Phone="403-201-908"},
                new Student{Id = 3, FirstName="Kerry", LastName="Stephanie", Phone="403-201-908"},
                new Student{Id = 4, FirstName="Jacob", LastName="Emmanuel", Phone="403-201-908"},
            };
        }
        public static List<Student> GetAll()
        {
            return _students;
        }

        public static void Add(Student student)
        {
            var id = _students.Max(s => s.Id);
            id++;
            student.Id = id;
            _students.Add(student);
        }
    }
}
