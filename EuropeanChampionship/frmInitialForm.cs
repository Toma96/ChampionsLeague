using ChampionsLeague.BaseLib;
using System;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class frmInitialForm : Form
    {
        private IInitialFormController _initialFormController;

        public frmInitialForm(IInitialFormController inInitialFormController)
        {
            _initialFormController = inInitialFormController;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _initialFormController.ShowAllGroups();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _initialFormController.ShowAllTeams();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _initialFormController.ShowGroupGames();
        }

        private void playersButton_Click(object sender, EventArgs e)
        {
            _initialFormController.ShowAllPlayers();
        }
    }
}
