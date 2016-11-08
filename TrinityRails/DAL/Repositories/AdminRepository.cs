using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.Enumerations;
using DAL.Interfaces;
using DAL.Types;

namespace DAL.Repositories
{
    public class AdminRepository
    {
        IAdmin context;
        List<User> userList = new List<User>();

        public AdminRepository(IAdmin context)
        {
            this.context = context;
        }

        public void create(int ID, string name, string username, string password, Function.userFunction function)
        {
            User user = new User(ID, name, username, function);
            context.create(user.username, password);
        }

        public void delete(User user)
        {
            foreach(User u in userList)
            {
                if (u == user)
                {
                    userList.Remove(user);
                }
            }
            context.delete(user);
        }

        public void changeUsername(User user, string username)
        {
            user.username = username;
            context.changeUsername(user, username);
        }

        public void changePassword(User user, string password)
        {
            context.changePassword(user, password);
        }

        public List<User> getUsers()
        {
            return context.getUsers();
        }
    }
}
