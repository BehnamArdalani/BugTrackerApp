using DataAccessLayer;
using GUILayer;
using Microsoft.IdentityModel.Tokens;
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

            /*dgvMessages.ReadOnly = true;
            dgvMessages.AllowUserToAddRows = false;
            dgvMessages.AllowUserToDeleteRows = false;
            */
            dgvAllBugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //dgvMessages.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UpdateBugGrid();

            MessageForm.CreatorsFullName = GetCreatorsFullName();
            
            BugDetailsForm.CreatorsFullName = GetCreatorsFullName();
            BugDetailsForm.Priorities = GetPriorities();
            BugDetailsForm.Severities = GetSeverities();

            cbCreatorFullName.DataSource = GetCreatorsFullName();
            cbPriority.DataSource = GetPriorities();
            cbSeverity.DataSource = GetSeverities();
            cbCreatorFullName.SelectedIndex = -1;
            cbPriority.SelectedIndex = -1;
            cbSeverity.SelectedIndex = -1;

            dpCreationDateFrom.Value = DateTime.Today.AddDays(-365);
            dpLastUpdateFrom.Value = DateTime.Today.AddDays(-365);
            dpCreationDateFrom.Format = DateTimePickerFormat.Custom;
            dpCreationDateFrom.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dpCreationDateTo.Format = DateTimePickerFormat.Custom;
            dpCreationDateTo.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dpLastUpdateFrom.Format = DateTimePickerFormat.Custom;
            dpLastUpdateFrom.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            dpLastUpdateTo.Format = DateTimePickerFormat.Custom;
            dpLastUpdateTo.CustomFormat = "yyyy/MM/dd HH:mm:ss";

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
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateBugGrid();
            
            txtId.Text = "";
            dpCreationDateFrom.Value = DateTime.Today.AddDays(-365);
            dpCreationDateTo.Value = DateTime.Now;
            dpLastUpdateFrom.Value = DateTime.Today.AddDays(-365);
            dpLastUpdateTo.Value = DateTime.Now;
            txtContains.Text = "";
            cbCreatorFullName.SelectedIndex = -1;
            cbPriority.SelectedIndex = -1;
            cbSeverity.SelectedIndex = -1;
            cbSolved.Checked = false;

        }
        private void UpdateBugGrid(Array? filteredBugs = null)
        {
            dgvAllBugs.DataSource = null;
            if (filteredBugs == null)
            {
                dgvAllBugs.DataSource = context.Bugs.Select(b => new BugView(b)).ToArray();
            }
            else
            {
                dgvAllBugs.DataSource = filteredBugs;
            }
            dgvAllBugs.Columns["CreatorFullName"].DefaultCellStyle = HyperlinkCellStyle();
            dgvAllBugs.Columns["Id"].Visible = false;

        }

        private void dgvAllBugs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnOpen.Enabled = true;
            selectedBugId = (int)dgvAllBugs.SelectedRows[0].Cells["Id"].Value;

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

        private void dgvAllBugs_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
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
            catch (Exception)
            {

                throw;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BugDetailsForm bugDetailsForm = new BugDetailsForm(AddBugToDatabase);
            bugDetailsForm.Show();
        }
        private void AddBugToDatabase(Bug bug)
        {
            if(bug.Id <= 0)
            {
                context.Add(bug);
            }
            else
            {
                context.ChangeTracker.Clear();

                context.Bugs.Attach(bug);
                context.Entry(bug).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }

            context.SaveChanges();

            Log log = new Log();
            log.BugId = bug.Id;
            log.Created = DateTime.Now;
            log.Message = "User #" + bug.CreatorId + " added bug #" + bug.Id;
            context.Add(log);

            context.SaveChanges();

            UpdateBugGrid();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            UpdateBugGrid(GetFilteredBugs());

        }

        private Array GetFilteredBugs()
        {
            List<BugView> filteredBugs = context.Bugs.Select(b => new BugView(b)).ToList();
            if (!txtId.Text.IsNullOrEmpty())
            {
                filteredBugs = filteredBugs.Where(b => b.Id == Convert.ToInt32(txtId.Text)).ToList();
            }
            
            filteredBugs = filteredBugs.Where(b => b.CreationDate >= dpCreationDateFrom.Value && b.CreationDate <= dpCreationDateTo.Value).ToList();
            
            filteredBugs = filteredBugs.Where(b => b.LastUpdate >= dpLastUpdateFrom.Value && b.LastUpdate <= dpLastUpdateTo.Value).ToList();
            
            if (cbCreatorFullName.SelectedIndex > -1)
            {
                filteredBugs = filteredBugs.Where(b => cbCreatorFullName.SelectedItem.ToString()!.Contains(b.CreatorFullName)).ToList();
            }
            if (!txtContains.Text.IsNullOrEmpty())
            {
                filteredBugs = filteredBugs.Where(b => b.BugName.ToLower().Contains(txtContains.Text) || b.Description.ToLower().Contains(txtContains.Text)).ToList();
            }
            if (cbPriority.SelectedIndex > -1)
            {
                filteredBugs = filteredBugs.Where(b => cbPriority.SelectedItem.ToString()!.Contains(b.Priority)).ToList();
            }
            if (cbSeverity.SelectedIndex > -1)
            {
                filteredBugs = filteredBugs.Where(b => cbSeverity.SelectedItem.ToString()!.Contains(b.Severity)).ToList();
            }
            if (cbSolved.Checked)
            {
                filteredBugs = filteredBugs.Where(b => b.Solved == cbSolved.Checked).ToList();
            }

            return filteredBugs.ToArray();
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int selectedBugId = (int)dgvAllBugs.SelectedRows[0].Cells["Id"].Value;
            BugDetailsForm bugDetailsForm = new BugDetailsForm(AddBugToDatabase,selectedBugId);
            bugDetailsForm.Show();
        }
    }
}