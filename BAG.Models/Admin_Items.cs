using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class Admin_Items
    {
        private int _Items_Id;
        private string _Item_Name;
        private string _Item_Tentative_Cost;
        private string _Media_Id_Img;
        private string _Item_Desc;
        private string _Items_Status;
        private System.DateTime _Created_Date;
        private System.DateTime _Updated_Date;
        private string _Created_by;
        private string _Updated_by;
       
        

        public int Items_Id
        {
            get { return _Items_Id; }
            set { _Items_Id = value; }
        }
        public string Item_Name
        {
            get { return _Item_Name; }
            set { _Item_Name = value; }
        }
        public string Item_Tentative_Cost
        {
            get { return _Item_Tentative_Cost; }
            set { _Item_Tentative_Cost = value; }
        }
        public string Media_Id_Img
        {
            get { return _Media_Id_Img; }
            set { _Media_Id_Img = value; }
        }
        public string Item_Desc
        {
            get { return _Item_Desc; }
            set { _Item_Desc = value; }
        }
        public string Items_Status
        {
            get { return _Items_Status; }
            set { _Items_Status = value; }
        }
        public System.DateTime Created_Date
        {
            get { return _Created_Date; }
            set { _Created_Date = value; }
        }
        public System.DateTime Updated_Date
        {
            get { return _Updated_Date; }
            set { _Updated_Date = value; }
        }
        public string Created_by
        {
            get { return _Created_by; }
            set { _Created_by = value; }
        }
        public string Updated_by
        {
            get { return _Updated_by; }
            set { _Updated_by = value; }
        }

        public Admin_Items() { }
        public Admin_Items(
            int Items_Id, 
            string Item_Name, 
            string Items_Price, 
            string Items_PictureUrl,
            string Item_Desc,
            string Items_Status,
            System.DateTime Created_Date,
            System.DateTime Updated_Date,
            string Created_by,
            string Updated_by
            )
        {
            _Items_Id = Items_Id;
            _Item_Name = Item_Name;
            _Item_Tentative_Cost = Item_Tentative_Cost;
            _Media_Id_Img = Media_Id_Img;
            _Item_Desc = Item_Desc;
            _Items_Status = Items_Status;
            _Created_Date = Created_Date;
            _Updated_Date = Updated_Date;
            _Created_by = Created_by;
            _Updated_by = Updated_by;

        }
    }
}
