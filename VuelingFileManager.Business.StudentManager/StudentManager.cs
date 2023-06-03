using System;
using System.Collections.Generic;
using VuelingFileManager.Infrastructure;
using VuelingFileManager.Transversal.Utilities;
using VuelingFileManager.Transversal.Utilities.Models;

namespace VuelingFileManager.Business.Logic
{
    public class StudentManager
    {
        private readonly List<Student> students = new List<Student>();
        private int studentCount = 0;

        public int AddNewStudent(DateTime birthday, string name, string surname)
        {
            Student newStudent = new Student(students.Count, birthday, name, surname);
            students.Add(newStudent);
            studentCount++;
            return studentCount;
        }
    }
}
