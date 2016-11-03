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

        public void create(int ID, string name, string username, Status.tramStatus function)
        {
            User user = new User(ID, name, username, function);
            //context.create(user);
        }

        public void delete(User user)
        {
            //context.delete(user);
        }

        public void changeUsername(User user, string username)
        {
            //context.changeUsername(user, username);
        }

        public void changePassword(User user, string password)
        {
            //context.changePassword(user, password);
        }

        public List<User> getUsers()
        {
            return context.getUsers();
        }
    }
}
