﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Types;

namespace DAL.Interfaces
{
    public interface IAdmin
    {
        void create();
        void delete();
        void changeUsername();
        void changePassword();
        void getUsers();
    }
}
