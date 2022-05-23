using DTO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.BLL
{
    public class PersonBLL
    {
        public List<Person> GetPeople()
        {
            return ThreeLayer.Database.Repositories.PersonRepository.GetPeople();
        }
        public Person getPerson(int id)
        {
            if (id <= 0) throw new IndexOutOfRangeException();
            return ThreeLayer.Database.Repositories.PersonRepository.getPerson(id);
        }

        public void AddPerson(Person person)
        {

            ThreeLayer.Database.Repositories.PersonRepository.AddPerson(person);
        }

        public int getPersonRange()
        {
            return ThreeLayer.Database.Repositories.PersonRepository.getPersonRange();
        }

        public void RemovePerson(int id)
        {
            ThreeLayer.Database.Repositories.PersonRepository.RemovePerson(id);
        }
    }
}
