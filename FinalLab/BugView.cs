using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BugView
    {
        public int Id { get; set; }
        public string BugName { get; set; }
        public string Description { get; set; }
        public string CreatorFullName { get; set; }
        public string Priority { get; set; }
        public string Severity { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Solved { get; set; }

        public BugView(Bug bug)
        {
            Id = bug.Id;
            BugName = bug.BugName;
            Description = bug.Description;
            CreatorFullName = bug.Creator.FirstName + " " + bug.Creator.LastName;
            Priority = bug.Priority.Name;
            Severity = bug.Severity.Name;
            CreationDate = bug.CreationDate;
            LastUpdate = bug.LastUpdate;
            Solved = bug.Solved;

        }
    }
}
