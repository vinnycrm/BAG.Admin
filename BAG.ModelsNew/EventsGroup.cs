using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class EventsGroup
    {
        public Events eventDetails { get; set; }
        public EventsWishList[] eventWishList { get; set; }
    }
}
