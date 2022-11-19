using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Message
    {
        public int Id { get; set; }
        public int BugId { get; set; }
        public int CreatorId { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public Bug Bug { get; set; }
        public Person Creator { get; set; }

    }
}
