using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class RolViewModel
    {
        public int id;
        public string name;
        public string description;
        public List<PermissionByModuleViewModel> permissionByModule;

    }
}
