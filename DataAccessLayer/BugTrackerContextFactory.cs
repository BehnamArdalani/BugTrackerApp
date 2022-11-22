using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class BugTrackerContextFactory
    {
        public static BugTrackerContext GetContext()
        {
            BugTrackerContext context = new BugTrackerContext();
            context.Bugs.Load();
            context.People.Load();
            context.Severities.Load();
            context.Priorities.Load();
            context.Logs.Load();
            context.Messages.Load();
            return context;
        }
    }
}
