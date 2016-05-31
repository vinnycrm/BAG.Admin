using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class DashboardItems
    {
        public string Item_Id
        {
            get { return _Item_Id; }
            set { _Item_Id = value; }
        }
        private string _Item_Id;

        public string Item_Name
        {
            get { return _Item_Name; }
            set { _Item_Name = value; }
        }
        private string _Item_Name;

        public string Item_VendorShop
        {
            get { return _Item_VendorShop; }
            set { _Item_VendorShop = value; }
        }
        private string _Item_VendorShop;

        public DateTime Item_CreateDate
        {
            get { return _Item_CreateDate; }
            set { _Item_CreateDate = value; }
        }
        private DateTime _Item_CreateDate;

        public DashboardItems() { }

        public DashboardItems(
            string Item_Id,
            string Item_Name,
            string Item_VendorShop,
            DateTime Item_CreateDate
            )
        {
            this._Item_Id = Item_Id;
            this._Item_Name = Item_Name;
            this._Item_VendorShop = Item_VendorShop;
            this._Item_CreateDate = Item_CreateDate;
        }

    }
}
