using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Admin_SubAdministrator
    {
        private int _Id;
        private string _UserName;
        private string _Password;
        private string _Gender;
        private DateTime _Dob;
        private string _Address;
        private string _City;
        private string _Country;
        private string _Role;
        private string _ProfileUrl;
        private string _Account_Status;
        private System.DateTime _Created_Date;
        private System.DateTime _Updated_Date;
        private string _Created_by;
        private string _Updated_by;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public DateTime Dob {
            get { return _Dob; }
            set { _Dob = value; }
        }
        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
        }
        public string Role
        {
            get { return _Role; }
            set { _Role = value; }
        }
        public string ProfileUrl
        {
            get { return _ProfileUrl; }
            set { _ProfileUrl = value; }
        }
        public string Account_Status
        {
            get { return _Account_Status; }
            set { _Account_Status = value; }
        }
        public System.DateTime Created_Date
        {
            get { return _Created_Date; }
            set { _Created_Date = value; }
        }
        public System.DateTime Updated_Date
        {
            get { return _Updated_Date; }
            set { _Updated_Date = value; }
        }
        public string Created_by
        {
            get { return _Created_by; }
            set { _Created_by = value; }
        }
        public string Updated_by
        {
            get { return _Updated_by; }
            set { _Updated_by = value; }
        }

        public Admin_SubAdministrator() { }
        public Admin_SubAdministrator(
            int Id,
            string UserName,
            string Password,
            string Gender,
            DateTime Dob,
            string Address,
            string City,
            string Country,
            string Role,
            string ProfileUrl)
        {
            _Id = Id;
            _UserName = UserName;
            _Password = Password;
            _Gender = Gender;
            _Dob = Dob;
            _Address = Address;
            _City = City;
            _Country = Country;
            _Role = Role;
            _ProfileUrl = ProfileUrl;
        }

    }
}
