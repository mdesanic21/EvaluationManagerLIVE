using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Resources.Models {
    public class Organization : Client {
        public string Name { get; set; }
        public string IBAN { get; set; }

    }
}
