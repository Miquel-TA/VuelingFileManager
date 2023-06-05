using System;

namespace VuelingFileManager.Transversal.Utilities.Models
{
    public class Student
    {
        // Setters required for XML serialization.

        public int Id { get; set; }
        public Guid Guid { get; set;}
        public DateTime Birthday { get; set;}
        public int Age { get; set;}
        public string Name { get; set;}
        public string Surname { get; set;}

        public Student() { }

        public Student(int id, DateTime birthday, string name, string surname)
        {
            Id = id;
            Guid = Guid.NewGuid();
            Birthday = birthday.Date;
            Age = Converters.GetAgeFromBirthday(birthday);
            Name = name;
            Surname = surname;
        }

    }
}
