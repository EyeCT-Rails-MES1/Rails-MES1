using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositoryPattern.Interfaces;
using RepositoryPattern.Types;

namespace DAL.Repositories
{
    public class UserRepository
    {
        IUser context;
        List<User> userList = new List<User>();

        public UserRepository(IUser context)
        {
            this.context = context;
        }

        public void login(int ID, string name, string username, string function)
        {
            User user = new User(ID, name, username, function);
            userList.Add(user);
            context.create(user);
        }
        public void changeUsername(User user, string username)
        {
            user.changeUsername(username);
            context.update(user);
        }

        public void changePassword(User user, string password)
        {
            user.changePassword(password);
            context.update(user);
        }
    }
}