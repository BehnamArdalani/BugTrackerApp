using BusinessLayer;

namespace GUILayer
{
    public partial class MessageForm : Form
    {
        App app = new App();
        System.Action newMessageCallBack;
        public static string[]? CreatorsFullName;
        public static string[]? BugNames;
        public int bugId;
        public int messageId;
        public MessageForm(System.Action newMessageCallBack, int bugId, int messageId = 0)
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
            cbBugName.DataSource = BugNames;
            dpCreatedDate.Format = DateTimePickerFormat.Custom;
            dpCreatedDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";


            if (this.messageId == 0)
            {
                cbBugName.SelectedIndex = this.bugId;
            } 
            else
            {
                MessageData messageData = app.GetMessageById(this.messageId);
                txtId.Text = messageData.Id.ToString();
                cbBugName.SelectedIndex = messageData.BugId;
                rbText.Text = messageData.Text;
                txtTitle.Text = messageData.Title;
                cbCreatorFullName.SelectedIndex = messageData.CreatorId;
                dpCreatedDate.Value = messageData.Created;

                FormToggle();
            }
            

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageData messageData = new MessageData();
            messageData.Title = txtTitle.Text;
            messageData.Text = rbText.Text;
            messageData.CreatorId = cbCreatorFullName.SelectedIndex;
            messageData.Created = dpCreatedDate.Value;
            messageData.BugId = cbBugName.SelectedIndex;

            app.SaveMessage(messageData);

            Close();
        }
        private void FormToggle()
        {
            rbText.Enabled = !rbText.Enabled;
            cbCreatorFullName.Enabled = !cbCreatorFullName.Enabled;
            //cbBugName.Enabled = !cbBugName.Enabled;
            txtTitle.Enabled = !txtTitle.Enabled;
            dpCreatedDate.Enabled = !dpCreatedDate.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
            
        }
    }
}
