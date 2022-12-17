using BusinessLayer;

namespace GUILayer
{
    public partial class PersonForm : Form
    {
        App app = new App();
        public PersonForm(int personId = -1)
        {
            InitializeComponent();

            FillJobTitle();

            FillPersonData(personId);
            
        }

        private void FillJobTitle()
        {
            cbJobTitle.Items.Clear();
            List<string> jobTitles = new List<string>();
            jobTitles = app.GetJobTitles();
            foreach(string jobTitle in jobTitles)
            {
                cbJobTitle.Items.Add(jobTitle == null ? "" : jobTitle);
            }
        }

        private void FillPersonData(int personId)
        {
            PersonView personView = app.GetPersonById(personId);

            txtId.Text = personView.Id.ToString();
            txtFirstName.Text = personView.FirstName.ToString();
            txtLastName.Text = personView.LastName.ToString();
            cbJobTitle.Text = personView.JobTitle == null ? "" : personView.JobTitle.ToString();
            txtSalary.Text = personView.Salary.ToString();
            txtExperience.Text = personView.YearsOfExperience.ToString();
            dpHireDate.Value = (DateTime)personView.HiredDate;
            txtAddress.Text = personView.Address!.ToString();
            txtEmail.Text = personView.Email == null ? "" : personView.Email!.ToString();
            dpDateofBirth.Value = (DateTime)personView.DateOfBirth!;
        
        }
    }
}
