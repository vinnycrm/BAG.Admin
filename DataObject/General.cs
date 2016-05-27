using System;


namespace Prayogis.DataObject
{
    public class UserDetails
    {
        public string _Firstname;
        public string _Email;


        public string FirstName
        {
            get
            {
                return _Firstname;
            }

            set
            {
                _Firstname = value;
            }
        }

        public string EmailId
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }


    }

    public class UserProfile
    {
        public string _Id;
        public string _Name;
        public string _ProfileUrl;
        public string _Emailid;
        public string _Dob;
        public string _Mobile;
        public string _Profession;
        public string _IsMarried;
        public string _City;
        public string _Wedding;

        public string Id
        {
            get
            {
                return _Id;
            }

            set
            {
                _Id = value;
            }
        }

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public string ProfileUrl
        {
            get
            {
                return _ProfileUrl;
            }

            set
            {
                _ProfileUrl = value;
            }
        }

        public string Emailid
        {
            get
            {
                return _Emailid;
            }

            set
            {
                _Emailid = value;
            }
        }

        public string Dob
        {
            get
            {
                return _Dob;
            }

            set
            {
                _Dob = value;
            }
        }

        public string Mobile
        {
            get
            {
                return _Mobile;
            }

            set
            {
                _Mobile = value;
            }
        }

        public string Profession
        {
            get
            {
                return _Profession;
            }

            set
            {
                _Profession = value;
            }
        }

        public string IsMarried
        {
            get
            {
                return _IsMarried;
            }

            set
            {
                _IsMarried = value;
            }
        }

        public string City
        {
            get
            {
                return _City;
            }

            set
            {
                _City = value;
            }
        }

        public string Wedding
        {
            get
            {
                return _Wedding;
            }

            set
            {
                _Wedding = value;
            }
        }
    }
}
