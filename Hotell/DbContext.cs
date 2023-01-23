using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    class DbContext
    {

        public static List<Customer> CustomerList = new List<Customer>();
        public static List<User> UserList = new List<User>();
        public static List<Room> RoomList = new List<Room>();
        public static List<Rent> RentList = new List<Rent>();
       


        public DbContext()
        {
        }
       
    }

}
