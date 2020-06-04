using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class PersonViewModel
    {

        public string id;
        public KindOfDocumentViewModel kindOfDocument;
        public string name;
        public string lastName;
        public string cellPhone;
        public string email;
        public CityViewModel city;
    }
}
