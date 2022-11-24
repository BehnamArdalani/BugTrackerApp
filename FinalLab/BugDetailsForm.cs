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
using System.Xml.Linq;

namespace GUILayer
{
    public partial class BugDetailsForm : Form
    {
        System.Action<Bug> newBugCallBack;
        public static string[] CreatorsFullName;
        public static string[] Priorities;
        public static string[] Severities;
        public BugDetailsForm(System.Action<Bug> newBugCallBack)
        {
            InitializeComponent();
            this.newBugCallBack = newBugCallBack;
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
            bug.BugName = txtBugName.Text;
            bug.CreatorId = cbCreatorFullName.SelectedIndex + 1;
            bug.Description = rbDescription.Text;
            bug.PriorityId = cbPriority.SelectedIndex + 1;
            bug.SeverityId = cbSeverity.SelectedIndex + 1;
            bug.CreationDate = dpCreationDate.Value;
            bug.LastUpdate = dpLastUpdate.Value;
            bug.Solved = cbIsSolved.Checked;

            return bug;
        }
    }
}
