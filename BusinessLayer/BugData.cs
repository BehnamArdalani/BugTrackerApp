using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class BugData
    {
        public int Id { get; set; }
        public string BugName { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public int PriorityId { get; set; }
        public int SeverityId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Solved { get; set; }

        public BugData(Bug bug)
        {
            Id = bug.Id;
            BugName = bug.BugName;
            Description = bug.Description;
            CreatorId = bug.CreatorId;
            PriorityId = bug.PriorityId;
            SeverityId = bug.SeverityId;
            CreationDate = bug.CreationDate;
            LastUpdate = bug.LastUpdate;
            Solved = bug.Solved;

        }
        public BugData()
        {

        }
    }
}
