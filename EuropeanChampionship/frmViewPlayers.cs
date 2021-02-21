using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague
{
    public partial class frmViewPlayers : Form, IViewPlayers
    {
        private IPlayerController _playerController;
        private IPlayerRepository _playerRepository;
        private ITeamRepository _teamRepository;

        private static readonly int TEAM_COLUMN_INDEX = 2;
        public frmViewPlayers()
        {
            InitializeComponent();
        }

        public void ShowAllPlayers(IPlayerController playerController, IPlayerRepository playerRepository, ITeamRepository teamRepository)
        {
            _playerController = playerController;
            _playerRepository = playerRepository;
            _teamRepository = teamRepository;

            UpdateList();

            this.Show();
        }

        private void UpdateList()
        {

            playerList.DataSource = _playerRepository.GetAllPlayers();

            playerList.Columns["NoGoals"].Visible = false;
            playerList.Columns["NoGames"].Visible = false;
            playerList.Columns["RedCards"].Visible = false;

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == TEAM_COLUMN_INDEX)
            {
                Team targetTeam = _teamRepository.GetTeam(playerList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                IList<Player> targetPlayers = targetTeam.Players;

                var newForm = new frmViewPlayersByTeam();
                newForm.ShowPlayersByTeam(targetTeam, targetPlayers);
            }

        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            var newForm = new frmAddNewPlayer();
            newForm.AddPlayer(this, _playerController, _teamRepository);
            UpdateList();
        }

        private void deletePlayerButton_Click(object sender, EventArgs e)
        {
            if (playerList.SelectedRows.Count < 1)
            {
                MessageBox.Show("Please select a row of the player you wish to delete.", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Player toDelete = (Player) playerList.SelectedRows[0].DataBoundItem;
            _playerController.DeletePlayer(toDelete, this);
        }
    }
}
