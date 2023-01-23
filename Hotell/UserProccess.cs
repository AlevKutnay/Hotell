using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotell
{
    internal class UserProccess : ICrud<User>
    {
        public bool Add(User entity)
        {
            try
            {
                DbContext.UserList.Add(entity);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            bool result = false;
            foreach (var user in DbContext.UserList.ToList())
            {
                if (user.Id == id)
                {
                    DbContext.UserList.Remove(user);
                    result = true;
                }
            }
            return result;
        }

        public User Detail(int id)
        {
            User newUser = new User();
            foreach (var user in DbContext.UserList.ToList())
            {
                if (user.Id == id)
                {
                    newUser = user;
                }
            }
            return newUser;
        }

        public List<User> List()
        {
            return DbContext.UserList.ToList();
        }
    }
}
