using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class A_ModelGroupsList
    {
        public U_USR_MASTER MasterData { get; set; }
        public U_USR_Lgn LoginData { get; set; }
        public A_Media_Img_Video MediaData { get; set; }
        public A_Address AddressData { get; set; }
    }
}
