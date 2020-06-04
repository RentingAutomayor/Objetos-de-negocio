using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class RiskInformationViewModel
    {
        public int id;
        public DateTime? dateSubmissionAnalysis;
        public DateTime? dateResponseAnalysis;
        public long ammountApproved;
        public StateViewModel riskState;
        public DateTime? datefiling;
        public UserViewModel user;
        public bool state;
    }
}
