using BusinessLayer;
//using DataAccessLayer;
using Microsoft.IdentityModel.Tokens;
using Message = DataAccessLayer.Message;

namespace GUILayer
{
    public partial class BugDetailsForm : Form
    {
        App app = new App();

        System.Action newBugCallBack;
        public static string[]? CreatorsFullName;
        public static string[]? Priorities;
        public static string[]? Severities;
        public BugDetailsForm(System.Action newBugCallBack,int bugId = -1)
        {
            InitializeComponent();

            Initialize();

            this.newBugCallBack = newBugCallBack;
            if(bugId > 0)
            {
                FillAllData(bugId);
            }
        }

        private void Initialize()
        {
            cbCreatorFullName.DataSource = CreatorsFullName;
            cbPriority.DataSource = Priorities;
            cbSeverity.DataSource = Severities;

            dpCreationDate.Format = DateTimePickerFormat.Custom;
            dpCreationDate.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dpLastUpdate.Format = DateTimePickerFormat.Custom;
            dpLastUpdate.CustomFormat = "yyyy/MM/dd HH:mm:ss";

        }

        private void FormToggle()
        {
            txtBugName.Enabled = !txtBugName.Enabled;
            cbCreatorFullName.Enabled = !cbCreatorFullName.Enabled;
            rbDescription.Enabled = !rbDescription.Enabled;
            cbPriority.Enabled = !cbPriority.Enabled;
            cbSeverity.Enabled = !cbSeverity.Enabled;
            dpCreationDate.Enabled = !dpCreationDate.Enabled;
            dpLastUpdate.Enabled = !dpLastUpdate.Enabled;
            cbIsSolved.Enabled = !cbIsSolved.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            if (!txtId.Text.IsNullOrEmpty())
            {
                btnAdd.Enabled = !btnAdd.Enabled;
                btnNewMessage.Enabled = !btnNewMessage.Enabled;
            }
            else
            {
                btnAdd.Enabled = false;
                btnNewMessage.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            BugData bugData = new BugData();
            bugData.Id = txtId.Text.IsNullOrEmpty() ? 0 : Int32.Parse(txtId.Text);
            bugData.BugName = txtBugName.Text;
            bugData.CreatorId = cbCreatorFullName.SelectedIndex;
            bugData.Description = rbDescription.Text;
            bugData.PriorityId = cbPriority.SelectedIndex;
            bugData.SeverityId = cbSeverity.SelectedIndex;
            bugData.CreationDate = dpCreationDate.Value;
            bugData.LastUpdate = dpLastUpdate.Value;
            bugData.Solved = cbIsSolved.Checked;

            app.SaveBug(bugData);

            Close();
        }

        private void BugDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!txtBugName.Enabled)
            {
                FormToggle();
            }

            txtId.Clear();
            txtBugName.Clear();
            rbDescription.Clear();
            cbCreatorFullName.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            cbSeverity.SelectedIndex = 0;
            dpCreationDate.Value = DateTime.Now;
            dpLastUpdate.Value = DateTime.Now;
            cbIsSolved.Checked = false;

            dgvMessages.DataSource = null;
            rtxtLogs.Clear();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormToggle();

        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm(AddMessageToDatabase,Convert.ToInt32(txtId.Text));
            messageForm.Show();
            
        }

        private void AddMessageToDatabase()
        {
            MessageAndLogUpdate();
        }
        private void MessageAndLogUpdate()
        {
            dgvMessages.DataSource = app.GetAllBugMessageViews(Convert.ToInt32(txtId.Text));
            dgvMessages.Columns["Id"].Visible = false;
            
            rtxtLogs.Text = "";
            foreach (var log in app.GetAllBugLogs(Convert.ToInt32(txtId.Text)))
            {
                rtxtLogs.Text += log.ToString() + "\n";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtId.Text.IsNullOrEmpty())
            {
                Close();
            }
            else
            {
                FillAllData(Convert.ToInt32(txtId.Text));
            }
        }
        private void FillAllData(int bugId)
        {
            BugData bugData = app.GetBugById(bugId);
            txtId.Text = bugData.Id.ToString();
            txtBugName.Text = bugData.BugName;
            cbCreatorFullName.SelectedIndex = bugData.CreatorId;
            rbDescription.Text = bugData.Description;
            cbPriority.SelectedIndex = bugData.PriorityId;
            cbSeverity.SelectedIndex = bugData.SeverityId;
            dpCreationDate.Value = bugData.CreationDate;
            dpLastUpdate.Value = bugData.LastUpdate;
            cbIsSolved.Checked = bugData.Solved;

            MessageAndLogUpdate();

            FormToggle();
        }

        private void dgvMessages_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedMessageId = (int)dgvMessages.SelectedRows[0].Cells["Id"].Value;
            MessageForm messageForm = new MessageForm(null, 0, selectedMessageId);
            messageForm.Show();
        }
    }
}
