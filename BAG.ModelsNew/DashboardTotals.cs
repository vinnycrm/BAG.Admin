using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class DashboardTotals
    {
        public string TotalMembers
        {
            get { return _TotalMembers; }
            set { _TotalMembers = value; }
        }
        private string _TotalMembers;

        public string TotalEvents
        {
            get { return _TotalEvents; }
            set { _TotalEvents = value; }
        }
        private string _TotalEvents;

        public string TotalItems
        {
            get { return _TotalItems; }
            set { _TotalItems = value; }
        }
        private string _TotalItems;

        public string TotalVendors
        {
            get { return _TotalVendors; }
            set { _TotalVendors = value; }
        }
        private string _TotalVendors;

        public DashboardTotals() { }

        public DashboardTotals(
            string TotalMembers,
            string TotalEvents,
            string TotalItems,
            string TotalVendors
            )
        {
            this._TotalMembers = TotalMembers;
            this._TotalEvents = TotalEvents;
            this._TotalItems = TotalItems;
            this._TotalVendors = TotalVendors;
        }
    }
}
