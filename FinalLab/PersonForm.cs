using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUILayer
{
    public partial class PersonForm : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();
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
            jobTitles = context.People.Select(p => p.JobTitle).Distinct().ToList()!;
            foreach(string jobTitle in jobTitles)
            {
                cbJobTitle.Items.Add(jobTitle == null ? "" : jobTitle);
            }

        }

        private void FillPersonData(int personId)
        {
            Person person = context.People.First(p => p.Id == personId);
            txtId.Text = person.Id.ToString();
            txtFirstName.Text = person.FirstName.ToString();
            txtLastName.Text = person.LastName.ToString();
            cbJobTitle.Text = person.JobTitle == null ? "" : person.JobTitle.ToString();
            txtSalary.Text = person.Salary.ToString();
            txtExperience.Text = person.YearsOfExperience.ToString();
            dpHireDate.Value = (DateTime)person.HiredDate;
            txtAddress.Text = person.Address!.ToString();
            txtEmail.Text = person.Email == null ? "" : person.Email!.ToString();
            dpDateofBirth.Value = (DateTime)person.DateOfBirth!;
        }
    }
}
