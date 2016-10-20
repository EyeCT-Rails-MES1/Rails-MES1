using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IUser
    {
        void checkCredentials(string username, string password);
        int getID(string username, string password);
        string getFunction(User user);
        void changeUsername(User user);
        void changePassword(User user);
    }
}
