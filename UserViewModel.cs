using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class UserViewModel
    {

        public int? kindOfDocument;
        public string id;
        public string name;
        public string lastName;
        public string cellPhone;
        public string email;
        public LoginViewModel login;
        public RolViewModel rol;
    }
}
