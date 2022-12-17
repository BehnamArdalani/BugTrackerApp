//using DataAccessLayer;
using GUILayer;
using Microsoft.IdentityModel.Tokens;
using BusinessLayer;

namespace FinalLab
{
    public partial class BugForm : Form
    {
        BusinessLayer.App app = new App();

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

            dgvAllBugs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            UpdateBugGrid();

            MessageForm.CreatorsFullName = app.GetCreatorsFullName();
            MessageForm.BugNames = app.GetBugNames();
            
            BugDetailsForm.CreatorsFullName = app.GetCreatorsFullName();
            BugDetailsForm.Priorities = app.GetPriorities();
            BugDetailsForm.Severities = app.GetSeverities();

            cbCreatorFullName.DataSource = app.GetCreatorsFullName();
            cbPriority.DataSource = app.GetPriorities();
            cbSeverity.DataSource = app.GetSeverities();
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
                dgvAllBugs.DataSource = app.GetAllBugViews();
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
                int personId = app.GetPersonIdByBugId(selectedBugId);
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
        private void AddBugToDatabase()
        {

            UpdateBugGrid();
        }

        

        private void btnFilter_Click(object sender, EventArgs e)
        {
            UpdateBugGrid(GetFilteredBugs());

        }

        private Array GetFilteredBugs()
        {
            List<BugView> filteredBugs = app.GetAllBugViews().ToList();
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int selectedBugId = (int)dgvAllBugs.SelectedRows[0].Cells["Id"].Value;
            BugDetailsForm bugDetailsForm = new BugDetailsForm(AddBugToDatabase,selectedBugId);
            bugDetailsForm.Show();
        }
    }
}