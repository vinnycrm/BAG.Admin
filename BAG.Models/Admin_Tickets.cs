using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Admin_Tickets
    {
        //Private Variable for security purpose
        private string _Ticket_Id;
        private string _Ticket_Priority;
        private string _ContactPerson_name;
        private string _ContactEmaiId;
        private string _ContactMobileNumber;
        private string _Issue_Description;
        private string _Issue_PicutureUrl;

        //Getter and Setter for Private Variables
        public string Ticket_Id
        {
            get { return _Ticket_Id; }
            set { _Ticket_Id = value; }
        }
        public string Ticket_Priority
        {
            get { return _Ticket_Priority; }
            set { _Ticket_Priority = value; }
        }
        public string ContactPerson_name
        {
            get { return _ContactPerson_name; }
            set { _ContactPerson_name = value; }
        }
        public string ContactEmaiId
        {
            get { return _ContactEmaiId; }
            set { _ContactEmaiId = value; }
        }
        public string ContactMobileNumber
        {
            get { return _ContactMobileNumber; }
            set { _ContactMobileNumber = value; }
        }
        public string Issue_Description
        {
            get { return _Issue_Description; }
            set { _Issue_Description = value; }
        }
        public string Issue_PicutureUrl
        {
            get { return _Issue_PicutureUrl; }
            set { _Issue_PicutureUrl = value; }
        }

        // Constructors
        public Admin_Tickets() { }
        public Admin_Tickets(string Ticket_Id, string Ticket_Priority, string ContactPerson_name, string ContactEmaiId, string ContactMobileNumber, string Issue_Description, string Issue_PicutureUrl )
        {
            _Ticket_Id = Ticket_Id;
            _Ticket_Priority = Ticket_Priority;
            _ContactPerson_name = ContactPerson_name;
            _ContactEmaiId = ContactEmaiId;
            _ContactMobileNumber = ContactMobileNumber;
            _Issue_Description = Issue_Description;
            _Issue_PicutureUrl = Issue_PicutureUrl;
        }
    }
}
