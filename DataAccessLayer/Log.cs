
namespace DataAccessLayer
{
    public class Log
    {
        public int Id { get; set; }
        public int BugId { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public Bug Bug { get; set; }

        public override string ToString()
        {
            return Created.ToString() + " -> " + Message.ToString();
        }
    }

}
