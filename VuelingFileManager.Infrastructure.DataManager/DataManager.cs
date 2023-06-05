using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using VuelingFileManager.Transversal.Utilities;
using VuelingFileManager.Transversal.Utilities.Models;

namespace VuelingFileManager.Infrastructure.DataManager
{
    public class DataManager
    {
        private readonly string exportDirectory = "export";

        public string ExportTXT(List<Student> students)
        {
            string filePath = CreateFilepathForExport("txt");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Id};{student.Guid};{student.Birthday};{student.Age};{student.Name};{student.Surname}");
                }
            }
            SystemInteraction.OpenFile(filePath);
            return filePath;
        }

        public string ExportXML(List<Student> students)
        {
            string filePath = CreateFilepathForExport("xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(sw, students);
            }
            SystemInteraction.OpenFile(filePath);
            return filePath;
        }

        public string ExportJSON(List<Student> students)
        {
            string filePath = CreateFilepathForExport("json");

            string jsonString = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, jsonString);
            SystemInteraction.OpenFile(filePath);
            return filePath;
        }

        public List<Student> ImportTXT(string filePath)
        {
            List<Student> students = new List<Student>();
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');

                    int id = int.Parse(parts[0]);
                    Guid guid = Guid.Parse(parts[1]);
                    DateTime birthday = DateTime.Parse(parts[2]);
                    int age = int.Parse(parts[3]);
                    string name = parts[4];
                    string surname = parts[5];

                    Student student = new Student(id, birthday, name, surname)
                    {
                        Guid = guid,
                        Age = age
                    };
                    students.Add(student);
                }
            }
            return students;
        }

        public List<Student> ImportXML(string filePath)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using (StreamReader sr = new StreamReader(filePath))
            {
                List<Student> newStudentList = (List<Student>)xmlSerializer.Deserialize(sr);
                if (newStudentList != null)
                {
                    return newStudentList;
                }
                else
                {
                    return new List<Student>();
                }
            }
        }

        public List<Student> ImportJSON(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            List<Student> newStudentList = JsonConvert.DeserializeObject<List<Student>>(jsonString);
            if (newStudentList != null )
            {
                return newStudentList;
            }
            else
            {
                return new List<Student>();
            }
        }

        private string CreateFilepathForExport(string format)
        {
            //Multiple file creation based on datetime
            //string date = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            //string fileName = $"{date} Students.{format}";

            string fileName = $"Students.{format}";

            Directory.CreateDirectory(exportDirectory);

            return Path.Combine(exportDirectory, fileName);
        }
    }
}
