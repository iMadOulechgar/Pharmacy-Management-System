using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BusinessLayer
{
    public class clsBusinessNotification
    {
        enum Enmode { Add = 0, Update = 1 };
        Enmode Mode = Enmode.Add;

        public int AlertID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Alertime { get; set; }
        public string PicturePath { get; set; }
        public int DrugID { get; set; }



        public clsBusinessNotification()
        {
            this.Title = "";
            this.Description = "";
            this.Alertime = default(DateTime);
            this.PicturePath = "";
            this.DrugID = -1;

            Mode = Enmode.Add;
        }

        public clsBusinessNotification(string Title , string Description , DateTime AlerTime , string Picturepath , int DrugID)
        {
            this.Title = Title;
            this.Description = Description;
            this.Alertime = AlerTime;
            this.PicturePath = Picturepath;
            this.DrugID = DrugID;

            Mode = Enmode.Update;
        }

        private bool AddAlert()
        {
            if (clsDataAccessNotification.AddNewNotification(this.Title, this.Description, this.Alertime, this.PicturePath,this.DrugID) > 0)
                return true;
            else
                return false;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Enmode.Add:
                    if(AddAlert())
                        return true;
                    break;
            }

            return false;
        }



    }
}
