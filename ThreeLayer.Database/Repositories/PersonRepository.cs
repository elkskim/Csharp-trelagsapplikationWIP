using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using ThreeLayer.Database.DAL;
using ThreeLayer.Database.Mappers;
using System.Data.Objects;
using System.Data;

namespace ThreeLayer.Database.Repositories
{
    public class PersonRepository
    {

        public static List<Person> GetPeople()
        {
            using (PersonContext context = new PersonContext())
            {
                List<Person> people = new List<Person>();
                context.Persons.ToList().ForEach(person => people.Add(PersonMapper.Map(person)));
                return people;
            }

        }
        public static int getPersonRange()
        {
            using (PersonContext context = new PersonContext())
            {
                return context.Persons.Count();
            }
        }

        public static Person getPerson(int id)
        {
            using (PersonContext context = new PersonContext())
            {
                
             
                    return PersonMapper.Map(context.Persons.Find(id));
               
                
            }

        }

        public static void AddPerson(Person person)
        {
            using (PersonContext context = new PersonContext())
            {
               
                context.Persons.Add(PersonMapper.Map(person));
                context.Persons.Attach(PersonMapper.Map(person));
                context.SaveChanges();
            }
        }

        public static void RemovePerson(int id)
        {
            using (PersonContext context = new PersonContext())
            {
                

                var personFind = context.Persons.Find(id);
                context.Persons.Attach(personFind);

                context.Persons.Remove(personFind);
                context.SaveChanges();
               
            }
        }

        public static Person EditPerson(Person person)
        {
            using (PersonContext ctx = new PersonContext())
            {
                ctx.Persons.Find(person.PersonId).Name = person.Name;
                ctx.SaveChanges();
                return person;
            }
        }

    }
}
