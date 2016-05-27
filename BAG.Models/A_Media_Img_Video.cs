using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAG.Models
{
    public class A_Media_Img_Video
    {
        public string Media_Id
        {
            get { return _Media_Id; }
            set { _Media_Id = value; }
        }
        private string _Media_Id;

        public string Media_Type
        {
            get { return _Media_Type; }
            set { _Media_Type = value; }
        }
        private string _Media_Type;

        public string Media_File_Location
        {
            get { return _Media_File_Location; }
            set { _Media_File_Location = value; }
        }
        private string _Media_File_Location;

        public string Media_Source
        {
            get { return _Media_Source; }
            set { _Media_Source = value; }
        }
        private string _Media_Source;

        public string Media_Oth_Dtl
        {
            get { return _Media_Oth_Dtl; }
            set { _Media_Oth_Dtl = value; }
        }
        private string _Media_Oth_Dtl;

        public A_Media_Img_Video() { }

        public A_Media_Img_Video(
            string Media_Id,
            string Media_Type,
            string Media_File_Location,
            string Media_Source,
            string Media_Oth_Dtl
            )
        {
            this._Media_Id = Media_Id;
            this._Media_Type = Media_Type;
            this._Media_File_Location = Media_File_Location;
            this.Media_Source = Media_Source;
            this._Media_Oth_Dtl = Media_Oth_Dtl;

        }

    }
}
