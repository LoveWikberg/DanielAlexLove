using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlexLoveDaniel.Models
{
    public static class DataManager
    {
        public static List<Person> persons = new List<Person>
        {
            new Person {Id = 1, Name = "Ronny", Email = "ronkan@gangster.com"},
            new Person {Id = 2, Name = "Ponny", Email = "häst@acme.com"},
            new Person {Id = 3, Name = "Pekka", Email = "karhu@bastu.fin"},
        };

        internal static void AddPerson(PersonCreateVM viewModel)
        {
            Person person = new Person
            {
                Email = viewModel.Email,
                Name = viewModel.Name
            };

            persons.Add(person);
        }

        public static void EditPerson(Person person)
        {
            persons[person.Id - 1].Name = person.Name;
            persons[person.Id - 1].Email = person.Email;
        }

        public static PersonIndexVM[] GetIndexList()
        {
            return persons.Select(o => new PersonIndexVM
            {
                Email = o.Email,
                Name = o.Name,
                ShowAsHighlighted = o.Email.EndsWith("acme.com", StringComparison.OrdinalIgnoreCase)
            }).ToArray();
        }

        //public static Person[] GetAllPersons()
        //{
        //    return persons.ToArray();
        //}
    }
}
