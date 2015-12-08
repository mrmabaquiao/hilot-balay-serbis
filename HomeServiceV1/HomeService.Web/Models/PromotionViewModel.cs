using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeService.Web.Models
{
    public class PromotionViewModel
    {
        public int PromotionId { get; set; }
        public string Expertise { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<TagViewModel> Tags { get; set; }
    }

    public class TagViewModel
    {
        public int TagId { get; set; }
        public string Tag { get; set; }
    }
}