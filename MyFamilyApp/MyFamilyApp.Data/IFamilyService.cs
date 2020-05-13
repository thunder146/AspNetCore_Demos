using System;
using System.Collections.Generic;

namespace MyFamilyApp.Data
{
    public interface IFamilyService
    {
        void AddPerson(string name, string familyName, DateTime dateOfBirth);
        void AddFamily(string name);
        IEnumerable<Person> GetPeople();
        IEnumerable<Family> GetFamilies();
        Person GetPersonById(int personId);
        Family GetFamilyById(int familyId);
        List<Person> GetAllFamilyMembers(int familyId);
    }
}