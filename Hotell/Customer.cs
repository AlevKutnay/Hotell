using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class Customer:Abstract
    {
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Gander { get; set; }
        public double Balance { get; set; }
    }
}
