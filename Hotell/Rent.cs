using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class Rent:Abstract
    {
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }
        public int Day { get; set; }
        public double TotalPrice { get; set; }       
        public int RoomNumber { get; set; }
        public bool RoomIsStatus { get; set; }


    }
}
