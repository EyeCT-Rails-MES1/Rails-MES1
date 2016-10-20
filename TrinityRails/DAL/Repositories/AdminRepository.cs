using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void create(User user)
        {

        }
        public void delete(User user)
        {

        }
        public void changeUsername(User user, string username)
        {

        }
        public void changePassword(User user, string password)
        {

        }
        public List<User> getUsers()
        {
            return userList;
        }
    }
}
