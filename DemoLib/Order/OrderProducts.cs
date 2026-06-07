using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Order
{
    public class OrderProducts
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public string Articul { get; set; }
        public int Count { get; set; }
    }
}
