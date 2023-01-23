using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal interface ICrud<T>
    {


        bool Add(T entity);
        bool Delete(int id);
        T Detail(int id);
        List<T> List();


    }
}
