using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib.Order
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DelieveryDate { get; set; }
        public int IdPickup { get; set; }
        public string Fio {  get; set; }
        public int Code { get; set; }
        public string Status { get; set; }
        public string UserLogin { get; set; }
    }
}
