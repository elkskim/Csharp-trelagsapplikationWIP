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

                //Fordi jeg itererer igennem mine personer igennem PersonBLL i PersonCreation-view, støder jeg ind i problemer når jeg fjerner et element.
                //Det kan omgåes ved at indsætte en dummy person når jeg så bruger den her funktion til at populerer mit table, men det skaber ragnarok i databasen.
                //Prøver at fikse det. 
             
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
                /*
                 if (!context.Persons.Local.Contains(personen)) 
                 { 
                     context.Persons.Attach(personen); 
                 }
                 context.Persons.Remove(personen);
                 context.SaveChanges();
                */


                /*
                context.Entry(PersonMapper.Map(person)).State = System.Data.Entity.EntityState.Deleted;
                try
                {
                    context.SaveChanges();
                }
                catch (OptimisticConcurrencyException)
                {
                    context.Refresh(RefreshMode.ClientWins, PersonMapper.Map(person));
                    context.SaveChanges();
                }

                */
            }
        }

    }
}
