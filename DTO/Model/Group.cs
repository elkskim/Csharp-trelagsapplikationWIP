using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Model
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public List<Person> Persons { get; set; } = new List<Person>();

        public Group(int groupId, string name)
        {
            GroupId = groupId;
            Name = name;
        }

        public Group()
        {

        }


    }
}
