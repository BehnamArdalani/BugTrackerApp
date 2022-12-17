using DataAccessLayer;

namespace BusinessLayer
{
    public class MessageView
    {
        public int Id { get; set; }
        public string CreatorFullName { get; set; }
        public string BugName { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }

        public MessageView(Message message)
        {
            Id = message.Id;
            CreatorFullName = message.Creator.FirstName + " " + message.Creator.LastName;
            Title = message.Title;
            Text = message.Text;
            Created = message.Created;
            BugName = message.Bug.BugName;
        }
    }
}
