using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prayogis.DataObject
{
    public class Temp_Transactions
    {
        public int ID { get; set; }
        public int TransactionId { get; set; }
        public string EventName { get; set; }
        public string WishList { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int Amount { get; set; }
        public string ContributorName { get; set; }
        public string Status { get; set; }
    }
}
