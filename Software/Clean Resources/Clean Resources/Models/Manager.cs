using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Resources.Models {
    public class Manager : Person
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool CheckPassword(string password) {
            return Password == password;
        }

    }
}
