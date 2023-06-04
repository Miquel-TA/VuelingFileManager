using System;

namespace VuelingFileManager.Transversal.Utilities.Models
{
    public class Student
    {
        public int Id { get; }
        public Guid Guid { get; }
        public DateTime Birthday { get; }
        public int Age { get; }
        public string Name { get; }
        public string Surname { get; }

        public Student() { }
        public Student(int id, DateTime birthday, string name, string surname)
        {
            Id = id;
            Guid = Guid.NewGuid();
            Birthday = birthday;
            Age = Converters.GetAgeFromBirthday(birthday);
            Name = name;
            Surname = surname;
        }

    }
}
