using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Database.Model;

namespace ThreeLayer.Database.Mappers
{
    internal class PersonMapper
    {
        public static DTO.Model.Person Map(Person person)
        {
            return new DTO.Model.Person(person.PersonId, person.Name);
        }

        public static Person Map(DTO.Model.Person person)
        {
            return new Person(person.PersonId, person.Name);
        }
    }
}
