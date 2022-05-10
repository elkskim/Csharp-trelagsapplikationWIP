using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeLayer.Database.Model
{

    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }

        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }
        public Person(int personId, string name)
    {
            PersonId = personId;
            Name = name;
    }

    }

    
}
