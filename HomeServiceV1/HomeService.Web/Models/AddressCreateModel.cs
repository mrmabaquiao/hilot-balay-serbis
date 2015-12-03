using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeService.Web.Models
{
    public class AddressCreateModel
    {

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string City { get; set; }
        public List<SelectListItem> Cities{get;set;}
        public string State { get; set; }
        public List<SelectListItem> States { get; set; }
        public string Country { get; set; }
        public List<SelectListItem> Countries { get; set; }
        public int PostalCode { get; set; }
    }
}