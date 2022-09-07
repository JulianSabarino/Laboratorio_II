using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase6.Classes
{
    public class User
    {
        private string _name;
        private string _password;

        public User(string name, string password)
        {
            this._name = name;
            this._password = password;
        }

        public string Name
        {
            get { return _name; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name}");
            return sb.ToString();
        }
    }
}
