using DataAccessLayer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Message = DataAccessLayer.Message;

namespace GUILayer
{
    public partial class BugDetailsForm : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();

        System.Action<Bug> newBugCallBack;
        public static string[]? CreatorsFullName;
        public static string[]? Priorities;
        public static string[]? Severities;
        public BugDetailsForm(System.Action<Bug> newBugCallBack,int bugId = -1)
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
            if (newBugCallBack != null)
            {
                newBugCallBack(GetBugInfo());
            }
            Close();
        }
        private Bug GetBugInfo()
        {
            Bug bug = new Bug();
            bug.Id = txtId.Text.IsNullOrEmpty() ? 0 : Int32.Parse(txtId.Text);
            bug.BugName = txtBugName.Text;
            bug.CreatorId = cbCreatorFullName.SelectedIndex;
            bug.Creator = context.People.First(p => p.Id == cbCreatorFullName.SelectedIndex);
            bug.Description = rbDescription.Text;
            bug.PriorityId = cbPriority.SelectedIndex;
            bug.SeverityId = cbSeverity.SelectedIndex;
            bug.CreationDate = dpCreationDate.Value;
            bug.LastUpdate = dpLastUpdate.Value;
            bug.Solved = cbIsSolved.Checked;

            return bug;
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
            if(txtId.Text.IsNullOrEmpty())
            {
                MessageBox.Show("Please go back to the Bug list and select a bug!", "Error");
            }
            else
            {
                MessageForm messageForm = new MessageForm(AddMessageToDatabase,Convert.ToInt32(txtId.Text));
                messageForm.Show();
            }
        }

        private void AddMessageToDatabase(Message message)
        {
            context.Add(message);

            context.SaveChanges();

            Log log = new Log();
            log.BugId = message.BugId;
            log.Created = DateTime.Now;
            log.Message = "User #" + message.CreatorId + " added message #" + message.Id + " to bug #" + message.BugId;
            context.Add(log);

            context.SaveChanges();

            MessageAndLogUpdate();
        }
        private void MessageAndLogUpdate()
        {
            dgvMessages.DataSource = context.Messages.Where(m => m.BugId == Convert.ToInt32(txtId.Text)).Select(m => new MessageView(m)).ToArray();
            dgvMessages.Columns["Id"].Visible = false;
            rtxtLogs.Text = "";
            foreach (var log in context.Logs.Where(l => l.BugId == Convert.ToInt32(txtId.Text)))
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
            Bug bug = context.Bugs.First(bug => bug.Id == bugId);
            txtId.Text = bug.Id.ToString();
            txtBugName.Text = bug.BugName;
            cbCreatorFullName.SelectedIndex = bug.CreatorId;
            rbDescription.Text = bug.Description;
            cbPriority.SelectedIndex = bug.PriorityId;
            cbSeverity.SelectedIndex = bug.SeverityId;
            dpCreationDate.Value = bug.CreationDate;
            dpLastUpdate.Value = bug.LastUpdate;
            cbIsSolved.Checked = bug.Solved;

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
