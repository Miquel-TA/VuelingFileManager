using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using VuelingFileManager.Transversal.Utilities.Models;

namespace VuelingFileManager.Infrastructure.DataManager
{
    public class DataManager
    {
        public string ExportTXT(List<Student> students)
        {
            string filePath = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + " Students.txt";
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Id},{student.Guid},{student.Birthday},{student.Age},{student.Name},{student.Surname}");
                }
            }
            OpenExportedFile(filePath);
            return filePath;
        }

        public string ExportXML(List<Student> students)
        {
            string filePath = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + " Students.xml";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                xmlSerializer.Serialize(sw, students);
            }
            OpenExportedFile(filePath);
            return filePath;
        }

        public string ExportJSON(List<Student> students)
        {
            string filePath = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss") + " Students.json";
            string jsonString = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, jsonString);
            OpenExportedFile(filePath);
            return filePath;
        }

        static void OpenExportedFile(string filePath)
        {
            System.Diagnostics.Process.Start(filePath);
        }
    }
}
