using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeService.Web.Models
{
    public class ProfileDetailsCreateModel
    {
      
        public string Name { get; set; }
        public string Profession { get; set; }
        public string ContactNumber { get; set; }
        public string Username { get; set; }
    }
}