using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Interfaces;
using DAL.Types;
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

        public void login(int ID, string name, string username, Status.tramStatus function)
        {
            User user = new User(ID, name, username, function);
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