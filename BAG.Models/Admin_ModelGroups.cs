using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Admin_ModelGroups
    {
        public Admin_Items Admin_Items { get; set; }
        public Admin_Login Admin_Login { get; set; }
        public Admin_Members Admin_Members { get; set; }
        public Admin_Transactions Admin_Transactions { get; set; }
    }
}
