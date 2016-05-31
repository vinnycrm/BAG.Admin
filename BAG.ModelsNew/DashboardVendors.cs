using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class DashboardVendors
    {
        public string Vendor_Id
        {
            get { return _Vendor_Id; }
            set { _Vendor_Id = value; }
        }
        private string _Vendor_Id;

        public string Vendor_ShopName
        {
            get { return _Vendor_ShopName; }
            set { _Vendor_ShopName = value; }
        }
        private string _Vendor_ShopName;

        public string Vendor_Name
        {
            get { return _Vendor_Name; }
            set { _Vendor_Name = value; }
        }
        private string _Vendor_Name;

        public DateTime Vender_CreateDate
        {
            get { return _Vender_CreateDate; }
            set { _Vender_CreateDate = value; }
        }
        private DateTime _Vender_CreateDate;

        public DashboardVendors() { }

        public DashboardVendors(
            string Vendor_Id,
            string Vendor_ShopName,
            string Vendor_Name,
            DateTime Vender_CreateDate
            )
        {
            this._Vendor_Id = Vendor_Id;
            this._Vendor_ShopName = Vendor_ShopName;
            this._Vendor_Name = Vendor_Name;
            this._Vender_CreateDate = Vender_CreateDate;
        }
    }
}
