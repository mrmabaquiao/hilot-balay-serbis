using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeService.Web.Models
{
    public class ProfileDetailsViewModel
    {
        public int ProfileId { get; set; }
        public string Name { get; set; }
        [Display(Name = "Expertise")]
        public string Profession { get; set; }
        [Display(Name ="Contact Number")]
        public string ContactNumber { get; set; }
        public string Username { get; set; }
    }
}