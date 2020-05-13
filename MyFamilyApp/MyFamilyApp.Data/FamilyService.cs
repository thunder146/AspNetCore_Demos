using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyFamilyApp.Data
{
    public class FamilyService : IFamilyService
    {
        public void AddPerson(string name, string familyName, DateTime dateOfBirth)
        {
            using (var context = new FamilyContext())
            {
                var family = context.Families.FirstOrDefault(f => string.Equals(familyName.Trim().ToLower(), f.Name.Trim().ToLower()));
                if (family == null)
                    throw new EntityNotFoundException("Familyname not found");

                var person = new Person(name, family, dateOfBirth);
                context.People.Add(person);
                context.SaveChanges();
            }
        }

        public void AddFamily(string name)
        {
            var family = new Family(name);
            using (var context = new FamilyContext())
            {
                context.Families.Add(family);
                context.SaveChanges();
            }
        }

        public IEnumerable<Person> GetPeople()
        {
            using (var context = new FamilyContext())
            {
                return context.People
                    .Include(person => person.Family)
                    .ToList();
            }
        }

        public IEnumerable<Family> GetFamilies()
        {
            using (var context = new FamilyContext())
            {
                return context.Families.ToList();
            }
        }

        public Person GetPersonById(int personId)
        {
            using (var context = new FamilyContext())
            {
                return context.People
                    .Include(person => person.Family)
                    .Single(p => p.ID == personId);
            }

        }

        public Family GetFamilyById(int familyId)
        {
            using (var context = new FamilyContext())
            {
                return context.Families.Find(familyId);
            }
        }

        public List<Person> GetAllFamilyMembers(int familyId)
        {
            using (var context = new FamilyContext())
            {
                return context.People
                    .Include(p => p.Family)
                    .Where(p=>p.Family.ID == familyId)
                    .ToList();
            }
        }
    }
}
