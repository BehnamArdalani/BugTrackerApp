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
        public int messageId;
        public MessageForm(System.Action<Message> newMessageCallBack, int bugId, int messageId = 0)
        {
            InitializeComponent();
            
            this.newMessageCallBack = newMessageCallBack;
            this.bugId = bugId;
            this.messageId = messageId;

            Initialize();
        }
        private void Initialize()
        {
            cbCreatorFullName.DataSource = CreatorsFullName;
            dpCreatedDate.Format = DateTimePickerFormat.Custom;
            dpCreatedDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";


            if (this.messageId == 0)
            {
                txtBugName.Text = context.Bugs.First(b => b.Id == this.bugId).BugName.ToString();
            } 
            else
            {
                Message message = context.Messages.First(m => m.Id == this.messageId);
                txtId.Text = message.Id.ToString();
                txtBugName.Text = context.Bugs.First(b => b.Id == message.BugId).BugName.ToString();
                rbText.Text = message.Text;
                cbCreatorFullName.SelectedIndex = message.CreatorId;
                dpCreatedDate.Value = message.Created;
                FormToggle();
            }
            

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
            message.CreatorId = cbCreatorFullName.SelectedIndex;
            message.Created = dpCreatedDate.Value;
            return message;
        }

        private void MessageForm_Load(object sender, EventArgs e)
        {

        }
        private void FormToggle()
        {
            rbText.Enabled = !rbText.Enabled;
            cbCreatorFullName.Enabled = !cbCreatorFullName.Enabled;
            dpCreatedDate.Enabled = !dpCreatedDate.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
        }
    }
}
