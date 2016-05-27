using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Admin_Transactions
    {
        private int _Id;
        private int _TransactionId;
        private string _EventName;
        private string _WishList;
        private int _ItemId;
        private string _ItemName;
        private int _Amount;
        private string _ContributorName;
        private string _Status;

        public int Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public int TransactionId
        {
            get { return _TransactionId; }
            set { _TransactionId = value; }
        }

        public string EventName
        {
            get { return _EventName; }
            set { _EventName = value; }
        }

        public string WishList
        {
            get { return _WishList; }
            set { _WishList = value; }
        }

        public int ItemId
        {
            get { return _ItemId; }
            set { _ItemId = value; }
        }

        public string ItemName
        {
            get { return _ItemName; }
            set { _ItemName = value; }
        }
        
        public int Amount
        {
            get { return _Amount; }
            set { _Amount = value; }
        }

        public string ContributorName
        {
            get { return _ContributorName; }
            set { _ContributorName = value; }
        }

        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        public Admin_Transactions() { }

        public Admin_Transactions(
            int Id,
            int TransactionId,
            string EventName,
            string WishList,
            int ItemId,
            string ItemName,
            int Amount,
            string ContributorName,
            string Status
            )
        {
            _Id = Id;
            _TransactionId = TransactionId;
            _EventName = EventName;
            _WishList = WishList;
            _ItemId = ItemId;
            _ItemName = ItemName;
            _Amount = Amount;
            _ContributorName = ContributorName;
            _Status = Status;
        }
    }
}
