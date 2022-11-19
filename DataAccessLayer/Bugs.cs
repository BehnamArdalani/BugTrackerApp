using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Bugs
    {
        int BugId { get; set; }
        string BugName { get; set; }
        string Description { get; set; }
        int CreatorId { get; set; }
        int PriorityId { get; set; }
        int SeverityId { get; set; }
        DateTime CreationDate { get; set; }
        DateTime LastUpdate { get; set; }
        bool Solved { get; set; }

    }
}
