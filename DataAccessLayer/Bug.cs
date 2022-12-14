using System.ComponentModel.DataAnnotations;

namespace DataAccessLayer
{
    public class Bug
    {
        public int Id { get; set; }
        [StringLength(50)] public string BugName { get; set; }
        public string Description { get; set; }
        public int CreatorId { get; set; }
        public int PriorityId { get; set; }
        public int SeverityId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public bool Solved { get; set; }
        public Person Creator { get; set; }
        public Priority Priority { get; set; }
        public Severity Severity { get; set; }

    }
}
