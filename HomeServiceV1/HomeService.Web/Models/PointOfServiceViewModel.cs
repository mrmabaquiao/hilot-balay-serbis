using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeService.Web.Models
{
    public class PointOfServiceViewModel
    {
        public string City { get; set; }
        public string State { get; set; }
        public List<SelectListItem> CityList {  get; set;   }
    }
}