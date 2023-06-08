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

        public void AddNewStudent(Student newStudent)
        {
            students.Add(newStudent);
        }

        public string ExportStudents(FileType format)
        {
            switch (format)
            {
                case FileType.TXT:
                    return DataManager.ExportTXT(students);

                case FileType.XML:
                    return DataManager.ExportXML(students);

                case FileType.JSON:
                    return DataManager.ExportJSON(students);

                default:
                    throw new FormatException($"Format exception in {format}");
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
