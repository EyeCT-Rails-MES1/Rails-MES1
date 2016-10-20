﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IUser
    {
        void checkCredentials();
        void getID();
        void getFunction();
        void changeUsername();
        void changePassword();
    }
}