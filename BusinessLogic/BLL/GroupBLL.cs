using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO.Model;
using ThreeLayer.Database.Repositories;

namespace BusinessLogic.BLL
{
    public class GroupBLL
    {


        public int getGroupRange()
        {
            return ThreeLayer.Database.Repositories.GroupRepository.getGroupRange();
        }
        public Group getGroup(int id)
        {
            if (id <= 0) throw new IndexOutOfRangeException();
            return ThreeLayer.Database.Repositories.GroupRepository.getGroup(id);
        }

        public void AddGroup(Group group)
        {
            ThreeLayer.Database.Repositories.GroupRepository.AddGroup(group);
        }
    }
}

