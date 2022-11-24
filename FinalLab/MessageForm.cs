using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using Message = DataAccessLayer.Message;

namespace GUILayer
{
    public partial class MessageForm : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();

        System.Action<Message> newMessageCallBack;
        public static string[]? CreatorsFullName;
        public int bugId;
        public MessageForm(System.Action<Message> newMessageCallBack, int bugId)
        {
            InitializeComponent();
            this.newMessageCallBack = newMessageCallBack;
            this.bugId = bugId;
            txtBugName.Text = context.Bugs.First(b => b.Id == bugId).BugName.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(newMessageCallBack != null)
            {
                newMessageCallBack(GetMessageInfo());
            }
            Close();
        }
        private Message GetMessageInfo()
        {
            Message message = new Message();
            message.BugId = bugId;
            message.Text = rbText.Text;
            message.CreatorId = cbCreatorFullName.SelectedIndex + 1;
            message.Created = dpCreatedDate.Value;
            return message;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
    }
}
