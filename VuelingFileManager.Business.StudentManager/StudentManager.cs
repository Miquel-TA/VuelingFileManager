using System;
using System.Collections.Generic;
using System.IO;
using VuelingFileManager.Infrastructure.DataManager;
using VuelingFileManager.Transversal.Utilities.Models;

namespace VuelingFileManager.Business.Logic
{
    public class StudentManager
    {
        private readonly DataManager DataManager = new DataManager();

        private List<Student> students = new List<Student>();

        public int AddNewStudent(DateTime birthday, string name, string surname)
        {
            Student newStudent = new Student(students.Count, birthday, name, surname);
            students.Add(newStudent);
            return students.Count;
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

        public void ImportStudents(string filePath)
        {
            string format = Path.GetExtension(filePath);

            switch (format.ToLower())
            {
                case ".xml":
                    students = DataManager.ImportXML(filePath);
                    break;

                case ".json":
                    students = DataManager.ImportJSON(filePath);
                    break;

                case ".txt":
                    students = DataManager.ImportTXT(filePath);
                    break;

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
            int removedStudents = GetStudentCount();
            students.Clear();
            return removedStudents;
        }
    }
}
