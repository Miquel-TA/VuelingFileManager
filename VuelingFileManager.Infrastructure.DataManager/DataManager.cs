using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
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
            string filePath = CreateExportFileAndCombinePaths("txt");

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                foreach (var student in students)
                {
                    sw.WriteLine($"{student.Id},{student.Guid},{student.Birthday},{student.Age},{student.Name},{student.Surname}");
                }
            }
            SystemInteraction.OpenFile(filePath);
            return filePath;
        }

        public string ExportXML(List<Student> students)
        {
            string filePath = CreateExportFileAndCombinePaths("xml");

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
            string filePath = CreateExportFileAndCombinePaths("json");

            string jsonString = JsonConvert.SerializeObject(students);
            File.WriteAllText(filePath, jsonString);
            SystemInteraction.OpenFile(filePath);
            return filePath;
        }

        private string CreateExportFileAndCombinePaths(string format)
        {
            string date = DateTime.Now.ToString("yyyy-MM-dd HH.mm.ss");
            string fileName = $"{date} Students.{format}";

            Directory.CreateDirectory(exportDirectory);

            return Path.Combine(exportDirectory, fileName);
        }
    }
}
