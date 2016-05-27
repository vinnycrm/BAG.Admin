using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class GroupsGroup
    {
        public A_USR_MASTER_V2 personalInfo { get; set; }
        public Groups[] HisGroups { get; set; }
        public Groups[] JoinedGroups { get; set; }
        public MemberContacts[] HisContacts { get; set; }
    }
}
