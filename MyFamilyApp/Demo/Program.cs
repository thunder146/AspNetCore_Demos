using MyFamilyApp.Data;
using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new FamilyService();
            var people = service.GetPeople();

            foreach(var person in people)
            {
                Console.WriteLine(person.ToString());
            }

            Console.ReadLine();
        }
    }
}
