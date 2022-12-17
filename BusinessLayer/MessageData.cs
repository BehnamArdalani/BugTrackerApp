using DataAccessLayer;

namespace BusinessLayer
{
    public class MessageData
    {
        public int Id { get; set; }
        public int BugId { get; set; }
        public string BugName { get; set; }
        public int CreatorId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
    
        public MessageData(Message message)
        {
            Id = message.Id;
            BugId = message.BugId;
            BugName = message.Bug.BugName;
            CreatorId = message.CreatorId;
            Title = message.Title;
            Text = message.Text;
            Created = message.Created;

        }
        public MessageData()
        {

        }
    }
    
}
