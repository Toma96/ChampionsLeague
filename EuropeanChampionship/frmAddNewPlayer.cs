using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague
{
    public partial class frmAddNewPlayer : Form, IAddNewPlayerView
    {
        private IPlayerController _playerController;
        private ITeamRepository _teamRepository;
        private IViewPlayers _form;
        public frmAddNewPlayer()
        {
            InitializeComponent();
        }

        public void AddPlayer(IViewPlayers form, IPlayerController playerController, ITeamRepository teamRepository)
        {
            _playerController = playerController;
            _teamRepository = teamRepository;
            _form = form;
            AddComboBoxItems();
            this.Show();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddComboBoxItems()
        {
            IList<Team> teamsFromDB = _teamRepository.GetAllTeams();

            foreach (Team t in teamsFromDB)
            {
                teamsComboBox.Items.Add(t);
            }

            foreach (Position p in Enum.GetValues(typeof(Position)).Cast<Position>().ToList())
            {
                positionsComboBox.Items.Add(p);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string name = this.playerName.Text;

            Team team = teamsComboBox.SelectedItem as Team;

            if (name == null || name.Equals("") || team == null || positionsComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please input all player fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Position pos = (Position) positionsComboBox.SelectedItem;

            Player newPlayer = new Player(name, team, pos);

            _playerController.AddNewPlayer(this, newPlayer, _form);

            Close();
        }
    }
}
