using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.Database.DAL
{
    internal class PersonInitializer : CreateDatabaseIfNotExists<PersonContext>
    {
        protected override void Seed(PersonContext context)
        {
            context.Persons.Add(new Model.Person("Lars"));
            context.Persons.Add(new Model.Person("Paul"));
            context.Persons.Add(new Model.Person("Skrrrrt"));

            Model.Group group = new Model.Group("The Groupz");
            group.Persons.Add(context.Persons.Find(3));
            context.Groups.Add(group);


            context.SaveChanges();
        }

        private void dummy()
        {
            string result = System.Data.Entity.SqlServer.SqlFunctions.Char(65);
        }
    }
}
