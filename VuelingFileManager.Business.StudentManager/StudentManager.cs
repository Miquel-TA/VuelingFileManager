using System;
using System.Collections.Generic;
using VuelingFileManager.Infrastructure.DataManager;
using VuelingFileManager.Transversal.Utilities.Models;

namespace VuelingFileManager.Business.Logic
{
    public class StudentManager
    {
        private readonly DataManager DataManager = new DataManager();

        private readonly List<Student> students = new List<Student>();
        private int studentCount = 0;

        public int AddNewStudent(DateTime birthday, string name, string surname)
        {
            Student newStudent = new Student(students.Count, birthday, name, surname);
            students.Add(newStudent);
            studentCount++;
            return studentCount;
        }

        public string ExportStudents(string format)
        {
            switch (format)
            {
                case "TXT":
                    return DataManager.ExportTXT(students);

                case "XML":
                    return DataManager.ExportXML(students);

                case "JSON":
                    return DataManager.ExportJSON(students);

                default:
                    throw new FormatException(format);
            }
        }

        public int GetStudentCount()
        {
            return students.Count;
        }

        public int EmptyStudents()
        {
            int studentsCount = students.Count;
            students.Clear();
            return studentCount;
        }
    }
}
