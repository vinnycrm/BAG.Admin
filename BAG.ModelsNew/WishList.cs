using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class WishList
    {
        public string WishListId
        {
            get { return _WishListId; }
            set { _WishListId = value; }
        }
        private string _WishListId;

        public string WishListName
        {
            get { return _WishListName; }
            set { _WishListName = value; }
        }
        private string _WishListName;

        public WishList() { }
        public WishList(
            string WishListId,
            string WishListName
            )
        {
            _WishListId = WishListId;
            _WishListName = WishListName;
        }
    }
}
