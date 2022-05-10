using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using ThreeLayer.Database.DAL;
using ThreeLayer.Database.Mappers;

namespace ThreeLayer.Database.Repositories
{
    public class PersonRepository
    {

        
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
                // overvej at throw exception, nullpointer inc
                return PersonMapper.Map(context.Persons.Find(id));
            }

        }

        public static void AddPerson(Person person)
        {
            using (PersonContext context = new PersonContext())
            {
                context.Persons.Add(PersonMapper.Map(person));
                context.SaveChanges();
            }
        }

        public static void RemovePerson(Person person)
        {
            using (PersonContext context = new PersonContext())
            {
                context.Persons.Remove(PersonMapper.Map(person));
                context.SaveChanges();
            }
        }

    }
}
