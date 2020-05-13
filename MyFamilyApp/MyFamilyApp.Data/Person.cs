using System;

namespace MyFamilyApp.Data
{
    public class Person
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime DateOfBirth { get; set; }

        public Family Family { get; set; }

        public Person()
        {

        }

        public Person(string name, Family family, DateTime dateOfBirth)
        {
            Name = name;
            Family = family;
            DateOfBirth = dateOfBirth;
        }

        public override string ToString()
        {
            return $"{Name} {Family?.Name}, {DateOfBirth}";
        }
    }
}
