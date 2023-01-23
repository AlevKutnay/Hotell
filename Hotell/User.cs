using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class User:Abstract
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Surname { get; set; }
        public string email { get; set; }
        public bool openClose { get; set; }
    }
}
