using DataAccessLayer;

namespace FinalLab
{
    public partial class Bug : Form
    {
        BugTrackerContext context = BugTrackerContextFactory.GetContext();
        public Bug()
        {
            InitializeComponent();
            dgvAllBugs.DataSource = context.Bugs.Select(b => new BugView(b)).ToArray();
        }
    }
}