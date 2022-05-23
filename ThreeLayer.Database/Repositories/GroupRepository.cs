using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Database.DAL;
using ThreeLayer.Database.Mappers;
using DTO.Model;

namespace ThreeLayer.Database.Repositories
{
    public class GroupRepository
    {

        public static List<Group> GetGroups()
        {
            using (PersonContext context = new PersonContext())
            {
                List<Group> groups = new List<Group>();
                context.Groups.ToList().ForEach(group => groups.Add(GroupMapper.Map(group)));
                return groups;
            }
        }
        public static int getGroupRange()
        {
            using (PersonContext context = new PersonContext())
            {
                return context.Groups.Count();
            }
        }
        public static Group getGroup(int id)
        {
            using (PersonContext context = new PersonContext())
            {
                // overvej at throw exception, nullpointer inc
                return GroupMapper.Map(context.Groups.Find(id));
            }

        }

        public static void AddGroup(Group group)
        {
            using (PersonContext context = new PersonContext())
            {
                context.Groups.Add(GroupMapper.Map(group));
                context.SaveChanges();
            }
        }
    }
}
