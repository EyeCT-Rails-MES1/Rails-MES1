using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Types
{
    public class User
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string function { get; set; } //TODO create enumeration

        public User(int ID, string name, string username, string function)
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
