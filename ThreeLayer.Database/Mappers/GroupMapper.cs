using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThreeLayer.Database.Model;

namespace ThreeLayer.Database.Mappers
{
    internal class GroupMapper
    {
        public static DTO.Model.Group Map(Group group)
        {
            return new DTO.Model.Group(group.GroupId, group.Name);
        }

        public static Group Map(DTO.Model.Group group )
        {
            return new Group(group.GroupId, group.Name);
        }
    }
}
