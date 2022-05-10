using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Database.Model;

namespace ThreeLayer.Database.DAL
{
    public class PersonContext : DbContext
    {
        public PersonContext() : base("Persons")
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Group> Groups { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
