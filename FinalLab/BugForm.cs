using DataAccessLayer;
using GUILayer;
using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;
using BusinessLayer;
using System.Reflection;

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
            cbCreatorFullName.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            cbSeverity.SelectedIndex = 0;

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
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.People.Select(p => p.Id + ". " + p.FirstName + " " + p.LastName).ToList());
            return result.ToArray();
        }
        private string[] GetPriorities()
        {
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.Priorities.Select(p => p.Id + ". " + p.Name).ToList());
            return result.ToArray();
        }
        private string[] GetSeverities()
        {
            List<string> result = new List<string>();
            result.Add("Any");
            result.AddRange(context.Severities.Select(s => s.Id + ". " + s.Name).ToList());
            return result.ToArray();
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
            cbCreatorFullName.SelectedIndex = 0;
            cbPriority.SelectedIndex = 0;
            cbSeverity.SelectedIndex = 0;
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
                Bug newBug = new Bug();

                newBug.BugName = bug.BugName;
                newBug.Description = bug.Description;
                newBug.CreatorId = bug.CreatorId;
                newBug.PriorityId = bug.PriorityId;
                newBug.SeverityId = bug.SeverityId;
                newBug.CreationDate = bug.CreationDate;
                newBug.LastUpdate = bug.LastUpdate;

                context.Bugs.Add(newBug);
                
                context.SaveChanges();

                Log log = new Log();
                log.BugId = newBug.Id;
                log.Created = DateTime.Now;
                log.Message = "User #" + newBug.CreatorId + " added bug #" + newBug.Id;
                context.Logs.Add(log);

                context.SaveChanges();

            }
            else
            {
                Bug? currentBug = context.Bugs.SingleOrDefault(b => b.Id == bug.Id);

                if(currentBug != null)
                {

                    if (!isEqualTwoObjects(currentBug.BugName, bug.BugName))
                        currentBug.BugName = bug.BugName;

                    if (!isEqualTwoObjects(currentBug.Description, bug.Description))
                        currentBug.Description = bug.Description;

                    if (!isEqualTwoObjects(currentBug.CreatorId, bug.CreatorId))
                        currentBug.CreatorId = bug.CreatorId;

                    if (!isEqualTwoObjects(currentBug.PriorityId, bug.PriorityId))
                        currentBug.PriorityId = bug.PriorityId;

                    if (!isEqualTwoObjects(currentBug.SeverityId, bug.SeverityId))
                        currentBug.SeverityId = bug.SeverityId;

                    if (!isEqualTwoObjects(currentBug.CreationDate, bug.CreationDate))
                        currentBug.CreationDate = bug.CreationDate;

                    if (!isEqualTwoObjects(currentBug.LastUpdate, bug.LastUpdate))
                        currentBug.LastUpdate = bug.LastUpdate;

                    if (!isEqualTwoObjects(currentBug.Solved, bug.Solved))
                        currentBug.Solved = bug.Solved;

                    //context.SaveChanges();

                    Log log = new Log();
                    log.BugId = currentBug.Id;
                    log.Created = DateTime.Now;
                    log.Message = "User #" + currentBug.CreatorId + " edited bug #" + currentBug.Id;
                    context.Logs.Add(log);

                    context.SaveChanges();

                }
                
            }

            UpdateBugGrid();
        }

        private bool isEqualTwoObjects(Object ob1, Object ob2)
        {
            if (ob1 is int && ob2 is int)
            {
                return Convert.ToInt32(ob1) == Convert.ToInt32(ob2);
            }
            else if (ob1 is string && ob2 is string)
            {
                string st1 = (string)ob1;
                string st2 = (string)ob2;
                return st1.Equals(st2);
            }
            else if (ob1 is DateTime && ob2 is DateTime)
            {
                DateTime dt1 = (DateTime)ob1;
                DateTime dt2 = (DateTime)ob2;
                return dt1.Equals(dt2);

            }
            else if (ob1 is bool && ob2 is bool) {
                return ((bool)ob1) == ((bool)ob2);
            }
            return false;
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
            
            if (cbCreatorFullName.SelectedIndex > 0)
            {
                filteredBugs = filteredBugs.Where(b => cbCreatorFullName.SelectedItem.ToString()!.Contains(b.CreatorFullName)).ToList();
            }
            if (!txtContains.Text.IsNullOrEmpty())
            {
                filteredBugs = filteredBugs.Where(b => b.BugName.ToLower().Contains(txtContains.Text) || b.Description.ToLower().Contains(txtContains.Text)).ToList();
            }
            if (cbPriority.SelectedIndex > 0)
            {
                filteredBugs = filteredBugs.Where(b => cbPriority.SelectedItem.ToString()!.Contains(b.Priority)).ToList();
            }
            if (cbSeverity.SelectedIndex > 0)
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