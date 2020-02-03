using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneApplication.Models
{
    public class Phone
    {
        public Phone()
        {
            PhoneID = "";
            PhoneName = "";
            Manufacturer = "";
            MSRP = 0;
            ScreenSize = "";
            DateReleased = DateTime.Now;
        }

        public string PhoneID { get; set; }
        public string PhoneName { get; set; }
        public string Manufacturer { get; set; }
        public double MSRP { get; set; }
        public string ScreenSize { get; set; }
        public DateTime DateReleased { get; set; }

    }





}