using DataAccessLayer;

namespace BusinessLayer
{
    public class App
    {
        BugTrackerContext context;

        public App()
        {
            context = BugTrackerContextFactory.GetContext();
        }
        public string[] GetCreatorsFullName()
        {
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.People.Select(p => p.Id + ". " + p.FirstName + " " + p.LastName).ToList());
            return result.ToArray();
        }
        public string[] GetBugNames()
        {
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.Bugs.Select(b => b.Id + ". " + b.BugName).ToList());
            return result.ToArray();
        }
        public string[] GetPriorities()
        {
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.Priorities.Select(p => p.Id + ". " + p.Name).ToList());
            return result.ToArray();
        }
        public string[] GetSeverities()
        {
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.Severities.Select(s => s.Id + ". " + s.Name).ToList());
            return result.ToArray();
        }
        public List<string> GetJobTitles()
        {
            return context.People.Select(p => p.JobTitle).Distinct().ToList()!;
        }
        public PersonView GetPersonById(int personId)
        {
            Person person = context.People.FirstOrDefault(p => p.Id == personId)!;
            PersonView personView = new PersonView(person);
            return personView;
        }
        public BugView[] GetAllBugViews()
        {
            return context.Bugs.Select(b => new BugView(b)).ToArray();
            /*
            List<Bug> bugs = context.Bugs.ToList();
            foreach (Bug bug in bugs)
            {
                bug.Creator = context.People.First(p => p.Id == bug.CreatorId);
                bug.Priority = context.Priorities.First(p => p.Id == bug.PriorityId);
                bug.Severity = context.Severities.First(s => s.Id == bug.SeverityId);
            }
            return bugs.Select(b => new BugView(b)).ToArray();
            */
        }
        public int GetPersonIdByBugId(int bugId) => context.Bugs.First(b => b.Id == bugId).CreatorId;

        public void SaveBug(BugData bugData)
        {
            if (bugData.Id <= 0)
            {
                Bug newBug = new Bug();

                newBug.BugName = bugData.BugName;
                newBug.Description = bugData.Description;
                newBug.CreatorId = bugData.CreatorId;
                newBug.Creator = context.People.First(p => p.Id == bugData.CreatorId);
                newBug.PriorityId = bugData.PriorityId;
                newBug.SeverityId = bugData.SeverityId;
                newBug.CreationDate = bugData.CreationDate;
                newBug.LastUpdate = bugData.LastUpdate;
                newBug.Solved = bugData.Solved;

                context.Bugs.Add(newBug);

                context.SaveChanges();

                Log log = new Log();
                log.BugId = newBug.Id;
                log.Created = DateTime.Now;
                log.Message = "User #" + newBug.CreatorId + " added bug #" + newBug.Id;
                context.Logs.Add(log);

                context.SaveChanges();

            }
            else
            {
                Bug? currentBug = context.Bugs.SingleOrDefault(b => b.Id == bugData.Id);

                if (currentBug != null)
                {

                    if (!isEqualTwoObjects(currentBug.BugName, bugData.BugName))
                        currentBug.BugName = bugData.BugName;

                    if (!isEqualTwoObjects(currentBug.Description, bugData.Description))
                        currentBug.Description = bugData.Description;

                    if (!isEqualTwoObjects(currentBug.CreatorId, bugData.CreatorId))
                        currentBug.CreatorId = bugData.CreatorId;

                    if (!isEqualTwoObjects(currentBug.PriorityId, bugData.PriorityId))
                        currentBug.PriorityId = bugData.PriorityId;

                    if (!isEqualTwoObjects(currentBug.SeverityId, bugData.SeverityId))
                        currentBug.SeverityId = bugData.SeverityId;

                    if (!isEqualTwoObjects(currentBug.CreationDate, bugData.CreationDate))
                        currentBug.CreationDate = bugData.CreationDate;

                    if (!isEqualTwoObjects(currentBug.LastUpdate, bugData.LastUpdate))
                        currentBug.LastUpdate = bugData.LastUpdate;

                    if (!isEqualTwoObjects(currentBug.Solved, bugData.Solved))
                        currentBug.Solved = bugData.Solved;

                    context.SaveChanges();

                    Log log = new Log();
                    log.BugId = currentBug.Id;
                    log.Created = DateTime.Now;
                    log.Message = "User #" + currentBug.CreatorId + " edited bug #" + currentBug.Id;
                    context.Logs.Add(log);

                    context.SaveChanges();

                }
            }
        }
        private bool isEqualTwoObjects(Object ob1, Object ob2)
        {
            if (ob1 is int && ob2 is int)
            {
                return Convert.ToInt32(ob1) == Convert.ToInt32(ob2);
            }
            else if (ob1 is string && ob2 is string)
            {
                string st1 = (string)ob1;
                string st2 = (string)ob2;
                return st1.Equals(st2);
            }
            else if (ob1 is DateTime && ob2 is DateTime)
            {
                DateTime dt1 = (DateTime)ob1;
                DateTime dt2 = (DateTime)ob2;
                return dt1.Equals(dt2);

            }
            else if (ob1 is bool && ob2 is bool)
            {
                return ((bool)ob1) == ((bool)ob2);
            }
            return false;
        }
        public void SaveLog(Log log)
        {
            context.Logs.Add(log);
            context.SaveChanges();
        }

        public BugData GetBugById(int bugId)
        {
            Bug bug = context.Bugs.FirstOrDefault(b => b.Id == bugId)!;
            BugData bugData = new BugData(bug);
            return bugData;
        }
        public void SaveMessage(MessageData messageData)
        {
            Message message = new Message();
            message.Title = messageData.Title;
            message.Text = messageData.Text;
            message.Created = messageData.Created;
            message.CreatorId = messageData.CreatorId;
            message.Creator = context.People.FirstOrDefault(p => p.Id == messageData.CreatorId)!;
            message.BugId = messageData.BugId;
            message.Bug = context.Bugs.FirstOrDefault(b => b.Id == messageData.BugId)!;
            
            context.Add(message);

            context.SaveChanges();

            Log log = new Log();
            log.BugId = message.BugId;
            log.Created = DateTime.Now;
            log.Message = "User #" + message.CreatorId + " added message #" + message.Id + " to bug #" + message.BugId;
            context.Add(log);

            context.SaveChanges();
        }
        public MessageView[] GetAllBugMessageViews(int bugId)
        {
            return context.Messages.Where(m => m.BugId == bugId).Select(m => new MessageView(m)).ToArray();
        }
        public Log[] GetAllBugLogs(int bugId)
        {
            return context.Logs.Where(l => l.BugId == bugId).ToArray();
        }
        public MessageData GetMessageById(int messageId)
        {
            Message message = context.Messages.First(m => m.Id == messageId);
            MessageData messageData = new MessageData(message);
            return messageData;
        }

    }
}
