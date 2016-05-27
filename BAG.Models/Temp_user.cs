using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Temp_user
    {
        private string _Id;
        private string _Name;

        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public Temp_user() { }
        public Temp_user(
            string Id,
            string Name)
        {
            _Id = Id;
            _Name = Name;
        }
    }
}
