using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer
{
    public class BugTrackerContextFactory
    {
        public static BugTrackerContext GetContext()
        {
            BugTrackerContext context = new BugTrackerContext();

            context.Severities.Load();
            context.Priorities.Load();
            context.Messages.Load();
            context.People.Load();
            context.Logs.Load();
            context.Bugs.Load();

            return context;
        }
    }
}
