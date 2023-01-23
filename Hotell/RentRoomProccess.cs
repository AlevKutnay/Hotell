using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{

    class RentRoomProccess : ICrud<Rent>
    {




        public bool Add(Rent entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Rent Detail(int id)
        {
            throw new NotImplementedException();
        }

        public List<Rent> List()
        {
            return DbContext.RentList.ToList();
        }


    }
}
