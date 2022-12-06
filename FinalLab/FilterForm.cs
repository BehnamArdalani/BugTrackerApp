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

namespace GUILayer
{
    public partial class FilterForm : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();

        System.Action<List<BugView>> bugListCallBack;
        public static string[]? CreatorsFullName;
        public static string[]? Priorities;
        public static string[]? Severities;

        public FilterForm(System.Action<List<BugView>> bugListCallBack)
        {
            InitializeComponent();
            this.bugListCallBack = bugListCallBack;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (bugListCallBack != null)
            {
                //bugListCallBack(GetFilteredBugs());
            }
            Close();

        }
        

        private void FilterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
