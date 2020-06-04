using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class StateViewModel
    {
        public int id;
        public string description;
        public int? parentState;
        public bool state;
    }
}
