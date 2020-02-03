using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PhoneApplication.Models;


namespace PhoneApplication.Controllers
{
    public class PhoneController : Controller
    {
        // GET: Phone
        public ActionResult Index()
        {
            var phoneList = new List<Phone>
            {
                new Phone { PhoneID = "1", PhoneName = "P30 Pro", Manufacturer = "Huawei", MSRP = 1060.00, ScreenSize = "6", DateReleased = DateTime.Parse("01-08-2018") },
                new Phone { PhoneID = "2", PhoneName = "Iphone 11", Manufacturer = "Apple", MSRP = 900, ScreenSize = "5.2", DateReleased = DateTime.Parse("06.02.2019") },
                new Phone { PhoneID = "3", PhoneName = "S10", Manufacturer = "Samsung", MSRP = 1090.00, ScreenSize = "6.2", DateReleased = DateTime.Parse("10-06-2017") }
            };

            return View(phoneList);
        }
    }
}