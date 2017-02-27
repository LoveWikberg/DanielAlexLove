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
            new Person {Id = 2, Name = "Ponny", Email = "häst@stall.nu"},
            new Person {Id = 3, Name = "Pekka", Email = "karhu@bastu.fin"},
        };

        internal static void AddPerson(Person person)
        {
            person.Id = persons.Max(c => c.Id) + 1;
            persons.Add(person);
        }

        public static void EditPerson(Person person)
        {
            persons[person.Id - 1].Name = person.Name;
            persons[person.Id - 1].Email = person.Email;
        }

        public static Person[] GetAllPersons()
        {
            return persons.ToArray();
        }
    }
}
