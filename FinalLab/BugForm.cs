using DataAccessLayer;
using GUILayer;
using System.Windows.Forms;
using Message = DataAccessLayer.Message;

namespace FinalLab
{
    public partial class BugForm : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();
        int selectedBugId;
        public BugForm()
        {
            InitializeComponent();

            Initialize();
        }

        private DataGridViewCellStyle HyperlinkCellStyle()
        {
            DataGridViewCellStyle HyperlinkCellStyle = new DataGridViewCellStyle();
            HyperlinkCellStyle.ForeColor = Color.Blue;
            HyperlinkCellStyle.Font = new Font(Font,FontStyle.Underline);
            return HyperlinkCellStyle;
        }
        private void Initialize()
        {
            dgvAllBugs.ReadOnly = true;
            dgvAllBugs.AllowUserToAddRows = false;
            dgvAllBugs.AllowUserToDeleteRows = false;

            dgvMessages.ReadOnly = true;
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;
            
            dgvAllBugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNewMessage.Enabled = false;

            UpdateBugGrid();

            MessageForm.CreatorsFullName = GetCreatorsFullName();
            BugDetailsForm.CreatorsFullName = GetCreatorsFullName();
            BugDetailsForm.Priorities = GetPriorities();
            BugDetailsForm.Severities = GetSeverities();


        }

        private string[] GetCreatorsFullName()
        {
            return context.People.Select(p => p.Id + ". " + p.FirstName + " " + p.LastName).ToArray();
        }
        private string[] GetPriorities()
        {
            return context.Priorities.Select(p => p.Id + ". " + p.Name).ToArray();
        }
        private string[] GetSeverities()
        {
            return context.Severities.Select(s => s.Id + ". " + s.Name).ToArray();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formEditingToggle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formEditingToggle();
            context.SaveChanges();
            UpdateBugGrid();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formEditingToggle();
        }
        private void UpdateBugGrid()
        {
            dgvAllBugs.DataSource = null;
            dgvAllBugs.DataSource = context.Bugs.Select(b => new BugView(b)).ToArray();
            dgvAllBugs.Columns["CreatorFullName"].DefaultCellStyle = HyperlinkCellStyle();
            dgvAllBugs.Columns["Id"].Visible = false;

        }
        private void UpdateMessageGrid()
        {
            var messages = context.Messages.Where(m => m.BugId == selectedBugId).OrderByDescending(m => m.Id).Select(m => new MessageView(m)).ToArray();
            if (messages.Length > 0)
            {
                dgvMessages.DataSource = messages;
                dgvMessages.Columns["Id"].Visible = false;
            }
            else
            {
                dgvMessages.DataSource = null;
            }

        }
        private void UpdateLogBox()
        {
            List<Log> logs = context.Logs.Where(l => l.BugId == selectedBugId).ToList();
            rtxtLogs.Clear();
            foreach (Log log in logs)
            {
                rtxtLogs.AppendText(log.ToString() + "\n");
            }
        }
        private void formEditingToggle()
        {
            dgvAllBugs.ReadOnly = !dgvAllBugs.ReadOnly;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;
            btnNewMessage.Enabled = !btnNewMessage.Enabled;
            btnAdd.Enabled = !btnAdd.Enabled;

        }

        private void dgvAllBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNewMessage.Enabled = true;
            selectedBugId = (int)dgvAllBugs.SelectedRows[0].Cells["Id"].Value;
            
            UpdateMessageGrid();

            UpdateLogBox();

            string column = dgvAllBugs.Columns[e.ColumnIndex].Name;

            if (column == "CreatorFullName")
            {
                int personId = context.Bugs.First(b => b.Id == selectedBugId).CreatorId;
                CallPersonForm(personId);
            }

        }

        private void CallPersonForm(int personId)
        {
            PersonForm personForm = new PersonForm(personId);

            personForm.ShowDialog();
        }

        private void btnNewMessage_Click(object sender, EventArgs e)
        {
            MessageForm messageForm = new MessageForm(AddMessageToDatabase,selectedBugId);
            messageForm.Show();
            
        }
        private void AddMessageToDatabase(Message message)
        {
            context.Add(message);
            
            Log log = new Log();
            log.BugId = selectedBugId;
            log.Created = DateTime.Now;
            log.Message = "User #" + message.CreatorId + " added a message to bug #" + selectedBugId + ".";
            context.Add(log);

            context.SaveChanges();
            
            UpdateMessageGrid();
            UpdateLogBox();
        }

        private void dgvAllBugs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            string column = dgvAllBugs.Columns[e.ColumnIndex].Name;
            
            if (column != "CreatorFullName")
            {
                dgvAllBugs.Cursor = Cursors.Default;
            }
            else
            {
                dgvAllBugs.Cursor = Cursors.Hand;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BugDetailsForm bugDetailsForm = new BugDetailsForm(AddBugToDatabase);
            bugDetailsForm.Show();
        }
        private void AddBugToDatabase(Bug bug)
        {
            context.Add(bug);
            context.SaveChanges();

            Log log = new Log();
            log.BugId = bug.Id;
            log.Created = DateTime.Now;
            log.Message = "User #" + bug.CreatorId + " added bug #" + bug.Id;
            context.Add(log);

            context.SaveChanges();

            UpdateBugGrid();
            UpdateLogBox();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }
    }
}