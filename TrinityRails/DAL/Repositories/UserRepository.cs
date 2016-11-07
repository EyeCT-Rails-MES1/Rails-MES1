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

        public void login(string username, string password)
        {
            User user = new User(context.getID(username, password), username);
            //context.create(user);
        }

        public void changeUsername(User user, string username)
        {
            //context.update(user);
        }

        public void changePassword(User user, string password)
        {
            //context.update(user);
        }
    }
}