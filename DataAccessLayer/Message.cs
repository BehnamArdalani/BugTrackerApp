
namespace DataAccessLayer
{
    public class Message
    {
        public int Id { get; set; }
        public int BugId { get; set; }
        public int CreatorId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }
        public virtual Bug Bug { get; set; }
        public virtual Person Creator { get; set; }

    }
}
