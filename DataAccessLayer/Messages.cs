using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Messages
    {
        int MessageId { get; set; }
        int BugId { get; set; }
        int CreatorId { get; set; }
        string Text { get; set; }
        DateTime Created { get; set; }
        Bugs Bug { get; set; }
        People Creator { get; set; }

    }
}
