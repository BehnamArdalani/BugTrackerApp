using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Message
    {
        int MessageId { get; set; }
        int BugId { get; set; }
        int CreatorId { get; set; }
        string Text { get; set; }
        DateTime Created { get; set; }
        Bug Bug { get; set; }
        Person Creator { get; set; }

    }
}
