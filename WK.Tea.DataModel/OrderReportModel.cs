using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WK.Tea.DataModel
{
    public class OrderReportModel
    {
        public int? ShopID { get; set; }
        public string ShopName { get; set; }
        public string Date { get; set; }
        public int? TotalOrderCount { get; set; }
        public int? TotalDuration { get; set; }
        public decimal? TotalMoney { get; set; }
    }
}
