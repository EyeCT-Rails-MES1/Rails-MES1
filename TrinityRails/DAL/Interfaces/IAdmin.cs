using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IAdmin
    {
        void create(string username, string password);
        void delete(User user);
        void changeUsername(User user);
        void changePassword(User user, string password);
        List<User> getUsers();
    }
}
