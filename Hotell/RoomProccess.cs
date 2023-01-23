using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotell
{

    internal class RoomProccess : ICrud<Room>
    {
        public int[] singleRoomNumbers = new int[30];
        public bool Add(Room entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Room Detail(int id)
        {
            throw new NotImplementedException();
        }

        public List<Room> List()
        {
            return DbContext.RoomList.ToList();
        }
    }
}
