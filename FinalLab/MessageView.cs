using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUILayer
{
    public class MessageView
    {
        public int Id { get; set; }
        public string CreatorFullName { get; set; }
        public string Text { get; set; }
        public DateTime Created { get; set; }

        public MessageView(DataAccessLayer.Message message)
        {
            Id = message.Id;
            CreatorFullName = message.Creator.FirstName + " " + message.Creator.LastName;
            Text = message.Text;
            Created = message.Created;
        }
    }
}
