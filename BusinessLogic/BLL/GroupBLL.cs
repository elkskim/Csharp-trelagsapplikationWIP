using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using ThreeLayer.Database.Repositories;

namespace BusinessLogic.BLL
{
    internal class GroupBLL
    {

        public Person getPerson(int id)
        {
            if (id <= 0) throw new IndexOutOfRangeException();
            return ThreeLayer.Database.Repositories.PersonRepository.getPerson(id);
        }

        public void AddPerson(Person person)
        {
            ThreeLayer.Database.Repositories.PersonRepository.AddPerson(person);
        }
    }
}

