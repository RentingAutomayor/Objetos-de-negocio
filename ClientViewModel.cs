using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class ClientViewModel : PersonViewModel
    {
        public EconomicActivityViewModel economicActivity;
        public CanalViewModel canal;
        public List<ContactViewModel> lsContacts;
    }
}
