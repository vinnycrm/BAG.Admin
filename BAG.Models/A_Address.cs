using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class A_Address
    {
        public string Address_Id
        {
            get { return _Address_Id; }
            set { _Address_Id = value; }
        }
        private string _Address_Id;

        public string Address_Type
        {
            get { return _Address_Type; }
            set { _Address_Type = value; }
        }
        private string _Address_Type;

        public string Address_Line1
        {
            get { return _Address_Line1; }
            set { _Address_Line1 = value; }
        }
        private string _Address_Line1;

        public string Address_Line2
        {
            get { return _Address_Line2; }
            set { _Address_Line2 = value; }
        }
        private string _Address_Line2;

        public string Address_Line3
        {
            get { return _Address_Line3; }
            set { _Address_Line3 = value; }
        }
        private string _Address_Line3;

        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        private string _City;

        public string StateName
        {
            get { return _StateName; }
            set { _StateName = value; }
        }
        private string _StateName;

        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        private string _Country;

        public string ZipCode
        {
            get { return _ZipCode; }
            set { _ZipCode = value; }
        }
        private string _ZipCode;

        public A_Address() { }

        public A_Address(
            string Address_Id,
            string Address_Type,
            string Address_Line1,
            string Address_Line2,
            string Address_Line3,
            string City,
            string StateName,
            string Country,
            string ZipCode
            )
        {
            this._Address_Id = Address_Id;
            this._Address_Type = Address_Type;
            this._Address_Line1 = Address_Line1;
            this._Address_Line2 = Address_Line2;
            this._Address_Line3 = Address_Line3;
            this._City = City;
            this._StateName = StateName;
            this._Country = Country;
            this._ZipCode = ZipCode;
        }
    }
}
