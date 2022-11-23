using DataAccessLayer;
using GUILayer;
using System.Windows.Forms;

namespace FinalLab
{
    public partial class BugForm : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();
        public BugForm()
        {
            InitializeComponent();
            
            dgvAllBugs.ReadOnly = true;
            dgvMessages.ReadOnly = true;
            dgvAllBugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            btnNewMessage.Enabled = false;

            dgvAllBugs.DataSource = context.Bugs.Select(b => new BugView(b)).ToArray();
            dgvAllBugs.Columns["CreatorFullName"].DefaultCellStyle = HyperlinkCellStyle();
        }

        private DataGridViewCellStyle HyperlinkCellStyle()
        {
            DataGridViewCellStyle HyperlinkCellStyle = new DataGridViewCellStyle();
            HyperlinkCellStyle.ForeColor = Color.Blue;
            HyperlinkCellStyle.Font = new Font(Font,FontStyle.Underline);
            return HyperlinkCellStyle;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            formEditingToggle();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            formEditingToggle();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            formEditingToggle();
        }

        private void formEditingToggle()
        {
            dgvAllBugs.ReadOnly = !dgvAllBugs.ReadOnly;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnSave.Enabled = !btnSave.Enabled;
            btnCancel.Enabled = !btnCancel.Enabled;
        }

        private void dgvAllBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnNewMessage.Enabled = true;
            var selectedBugId = (int)dgvAllBugs.SelectedRows[0].Cells[0].Value;
            var messages = context.Messages.Where(m => m.BugId == selectedBugId).OrderByDescending(m => m.Id).Select(m => new MessageView(m)).ToArray();
            
            if(messages.Length > 0)
            {
                dgvMessages.DataSource = messages;
            }
            else
            {
                dgvMessages.DataSource = null;
            }

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
    }
}