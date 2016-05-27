using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Admin_Members
    {
        private int _LoginUser_Id;
        private string _Member_Name;
        private string _EmailId;
        private string _Mobile;
        private string _Status;

        public int LoginUser_Id
        {
            get { return _LoginUser_Id; }
            set { _LoginUser_Id = value; }
        }

        public string Member_Name
        {
            get { return _Member_Name; }
            set { _Member_Name = value; }
        }

        public string EmailId
        {
            get { return _EmailId; }
            set { _EmailId = value; }
        }

        public string Mobile
        {
            get { return _Mobile; }
            set { _Mobile = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public Admin_Members() { }

        public Admin_Members(
            int LoginUser_Id,
            string Member_Name,
            string EmailId,
            string Mobile,
            string Status
            )
        {
            _LoginUser_Id = LoginUser_Id;
            _Member_Name = Member_Name;
            _EmailId = EmailId;
            _Status = Status;
        }

    }
}
