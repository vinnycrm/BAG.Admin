using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class U_ADMIN_lOGIN_Ref
    {
        private string _UserId;
        private string _UserName;

        public string UserId
        {
            get { return _UserId; }
            set { _UserId = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string ProfilePic
        {
            get { return _ProfilePic; }
            set { _ProfilePic = value; }
        }
        private string _ProfilePic;

        public U_ADMIN_lOGIN_Ref() { }

        public U_ADMIN_lOGIN_Ref(string uid, string uname, string ProfilePic)
        {
            _UserId = uid;
            _UserName = uname;
            _ProfilePic = ProfilePic;
        }
    }
}
