using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
using DAL.Persistencies;
using Classes.Enumerations;
using Classes;

namespace DAL.Repositories
{
    public class UserRepository
    {
        IUser context;
        
        public UserRepository(IUser context)
        {
            this.context = context;
        }

        public User login(string username, string password)
        {
            switch (context.checkCredentials(username, password))
            {
                case true:
                    User user = new User(context.getID(username, password), username);
                    user.function = (Function.userFunction)context.getFunction(user);
                    return user;
                case false:
                    user = null;
                    return user;
                default:
                    return null;
            }
        }

        public void changeUsername(User user, string username)
        {
            user.username = username;
            context.changeUsername(user);
        }

        public void changePassword(User user, string password)
        {
            context.changePassword(user, password);
        }
    }
}