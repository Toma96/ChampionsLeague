using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;

namespace ChampionsLeague
{
    public partial class frmViewPlayersByTeam : Form, IViewPlayersByTeam
    {
        IList<Player> _players;
        Team _team;
        public frmViewPlayersByTeam()
        {
            InitializeComponent();
        }

        public void ShowPlayersByTeam(Team team, IList<Player> playerRepository)
        {
            _players = playerRepository;
            _team = team;

            UpdateList();
            this.Show();
        }

        private void UpdateList()
        {
            playersList.Rows.Clear();
            playersList.Refresh();

            playersList.DataSource = _players;
            titleLabel.Text = _team.Name + " squad";

            playersList.Columns["Team"].Visible = false;
            playersList.Columns["ID"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
