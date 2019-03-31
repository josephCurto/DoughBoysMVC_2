using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    public class Order
    {
        public int OrderNo { get; set; }
        public string PickUpDate { get; set; }
        public string OrderDate { get; set; }
        public double TotalCost { get; set; }   
        public string PhoneNo { get; set; }
        public string DoughnutType { get; set; }
        public int Quantity { get; set; }
    }
}
