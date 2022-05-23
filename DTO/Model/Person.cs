using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Person
    {
        public Person()
        {

        }
        public Person(int personId, string name)
        {
            PersonId = personId;
            Name = name;
        }

        public int PersonId { get; set; }
        
        [Required]
        public string Name { get; set; }
    }
}
