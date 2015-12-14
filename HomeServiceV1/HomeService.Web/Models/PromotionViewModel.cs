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
        public Nullable<decimal> Price { get; set; }
        public string Description { get; set; }
        public Nullable<DateTime> StartDate { get; set; }
        public Nullable<DateTime> EndDate { get; set; }
        public List<TagViewModel> Tags { get; set; }
    }

    public class TagViewModel
    {
        public long TagId { get; set; }
        public string Tag { get; set; }
    }
}