using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class DashboardGroup
    {
        public DashboardTotals Totals { get; set; }
        public DashboardMember[] Members { get; set; }
        public DashboardEvents[] Events { get; set; }
        public DashboardItems[] Items { get; set; } 
        public DashboardVendors[] Vendors { get; set; }
    }
}
