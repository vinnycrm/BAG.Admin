using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class U_ADMIN_Members
    {
        private string _UserId;
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private string _Gender;
        private int _LoginStatus;

        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        public int LoginStatus
        {
            get { return _LoginStatus; }
            set { _LoginStatus = value; }
        }

        public U_ADMIN_Members() { }
        public U_ADMIN_Members(string UserId, string FirstName, string LastName, string Email, string Gender, int LoginStatus)
        {
            _UserId = UserId;
            _FirstName = FirstName;
            _LastName = LastName;
            _Gender = Gender;
            _Email = Email;
            _LoginStatus = LoginStatus;
        }

    }

    public class A_USR_MASTER_V2
    {
        public string Uid
        {
            get { return _Uid; }
            set { _Uid = value; }
        }
        private string _Uid;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        private string _FirstName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
        private string _LastName;

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }
        private string _EmailId;

        public string Gender
        {
            get { return _Gender; }
            set { _Gender = value; }
        }
        private string _Gender;

        public DateTime Dob
        {
            get { return _Dob; }
            set { _Dob = value; }
        }
        private DateTime _Dob;

        public string MobileNumber
        {
            get { return _MobileNumber; }
            set { _MobileNumber = value; }
        }
        private string _MobileNumber;

        public Int16 IsMarried
        {
            get { return _IsMarried; }
            set { _IsMarried = value; }
        }
        private Int16 _IsMarried;

        public DateTime WedAnvrsry
        {
            get { return _WedAnvrsry; }
            set { _WedAnvrsry = value; }
        }
        private DateTime _WedAnvrsry;

        public string Address
        {
            get { return _Address; }
            set { _Address = value; }
        }
        private string _Address;

        public string PicUrl
        {
            get { return _PicUrl; }
            set { _PicUrl = value; }
        }
        private string _PicUrl;

        public string Ratings
        {
            get { return _Ratings; }
            set { _Ratings = value; }
        }
        private string _Ratings;

        public string Created_By
        {
            get { return _Created_By; }
            set { _Created_By = value; }
        }
        private string _Created_By;

        public string Updated_By
        {
            get { return _Updated_By; }
            set { _Updated_By = value; }
        }
        private string _Updated_By;

        public A_USR_MASTER_V2() { }
        public A_USR_MASTER_V2(
            string Uid,
            string FirstName,
            string LastName,
            string EmailId,
            string Gender,
            DateTime Dob,
            string MobileNumber,
            Int16 IsMarried,
            DateTime WedAnvrsry,
            string Address,
            string PicUrl,
            string Ratings,
            string Created_By,
            string Updated_By
            )
        {
            _Uid = Uid;
            _FirstName = FirstName;
            _LastName = LastName;
            _EmailId = EmailId;
            _Gender = Gender;
            _Dob = Dob;
            _MobileNumber = MobileNumber;
            _IsMarried = IsMarried;
            _WedAnvrsry = WedAnvrsry;
            _Address = Address;
            _PicUrl = PicUrl;
            _Ratings = Ratings;
            _Created_By = Created_By;
            _Updated_By = Updated_By;
        }
    }
}
