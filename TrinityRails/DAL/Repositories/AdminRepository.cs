﻿using System;
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
            throw new NotImplementedException();
        }
        public void delete(User user)
        {
            throw new NotImplementedException();
        }
        public void changeUsername(User user, string username)
        {
            throw new NotImplementedException();
        }
        public void changePassword(User user, string password)
        {
            throw new NotImplementedException();
        }
        public List<User> getUsers()
        {
            return userList;
        }
    }
}
