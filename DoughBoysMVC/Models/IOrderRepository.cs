using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoughBoysMVC.Models
{
    interface IOrderRepository
    {
        IEnumerable<Order> Orders{ get; }
    }
}
