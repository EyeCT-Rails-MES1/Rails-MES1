using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using DAL.Interfaces;
using DAL.Persistencies;
using Classes.Enumerations;

namespace DAL.Types
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public Function.userFunction function { get; set; }


        public User(int ID, string username)
        {
            this.ID = ID;   
            this.username = username;
        }

        public User(int ID, string name, string username, Function.userFunction function)
        {   
            this.ID = ID;
            this.name = name;
            this.username = username;
            this.function = function;
        }

        public void checkFunction()
        {

        }

        public override string ToString()
        {
            return username;
        }
    }
}
