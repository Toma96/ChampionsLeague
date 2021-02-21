using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague
{
    public partial class frmAddNewGame : Form, IAddNewGameView
    {

        private IGameController _gameController;
        private ITeamRepository _teamRepository;
        private IGameRepository _gameRepository;
        private IPlayerRepository _playerRepository;
        IViewGroupGames _callingForm;

        private static readonly int PLAYER_ID_COLUMN_INDEX = 0;
        private static readonly int PLAYER_NAME_COLUMN_INDEX = 1;
        private static readonly int GOALS_COLUMN_INDEX = 2;
        private static readonly int RED_CARD_COLUMN_INDEX = 3;
        private static readonly int HAS_PLAYED_COLUMN_INDEX = 4;


        public frmAddNewGame()
        {
            InitializeComponent();
        }

        public void AddGame(IViewGroupGames callingForm, IGameController gameController, ITeamRepository teamRepository, IGameRepository gameRepository, IPlayerRepository playerRepository)
        {
            _gameController = gameController;
            _teamRepository = teamRepository;
            _gameRepository = gameRepository;
            _playerRepository = playerRepository;
            _callingForm = callingForm;
            AddComboBoxItems();
            this.Show();
        }

        private void AddComboBoxItems()
        {
            IList<Team> teamsFromDB = _teamRepository.GetAllTeams();

            foreach (Team t in teamsFromDB)
            {
                comboBox1.Items.Add(t.Name);
                comboBox2.Items.Add(t.Name);
            }
        }

        private void frmAddNewGame_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int homeTeamScore = Int32.Parse(this.HomeScore.Text);
                int awayTeamScore = Int32.Parse(this.AwayScore.Text);

                Team homeTeam = _teamRepository.GetTeam(comboBox1.SelectedItem.ToString());
                Team awayTeam = _teamRepository.GetTeam(comboBox2.SelectedItem.ToString());

                if (!homeTeam.Group.Equals(awayTeam.Group)) {
                    MessageBox.Show("Selected teams are not in the same group!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (homeTeam.Name.Equals(awayTeam.Name))
                {
                    MessageBox.Show("Team cannot play against itself!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Game game = new Game(homeTeam, awayTeam);
                game.TeamAwayScore = awayTeamScore;
                game.TeamHomeScore = homeTeamScore;

                if (CheckScore(homeTeamScore, homeEventsGrid) && CheckScore(awayTeamScore, awayEventsGrid))
                {
                    UpdatePlayers(homeEventsGrid);
                    UpdatePlayers(awayEventsGrid);
                    _gameRepository.AddGame(game);
                    _gameController.ShowAllGroupGames(_callingForm);
                    Close();
                }
                else
                {
                    MessageBox.Show("Scores must match the total number of goals scored by players!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Score inputs need to be integers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team homeTeam = _teamRepository.GetTeam(comboBox1.SelectedItem.ToString());
            homeEventsGrid.Rows.Clear();
            homeEventsGrid.Refresh();

            foreach (Player p in homeTeam.Players)
            {
                DataGridViewRow row = (DataGridViewRow)homeEventsGrid.Rows[0].Clone();
                row.Cells[PLAYER_ID_COLUMN_INDEX].Value = p.ID;
                row.Cells[PLAYER_NAME_COLUMN_INDEX].Value = p.Name;
                row.Cells[HAS_PLAYED_COLUMN_INDEX].Value = "True";
                row.Cells[GOALS_COLUMN_INDEX].Value = 0;
                row.Cells[RED_CARD_COLUMN_INDEX].Value = 0;

                homeEventsGrid.Rows.Add(row);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Team awayTeam = _teamRepository.GetTeam(comboBox2.SelectedItem.ToString());
            awayEventsGrid.Rows.Clear();
            awayEventsGrid.Refresh();

            foreach (Player p in awayTeam.Players)
            {
                DataGridViewRow row = (DataGridViewRow)awayEventsGrid.Rows[0].Clone();
                row.Cells[PLAYER_ID_COLUMN_INDEX].Value = p.ID;
                row.Cells[PLAYER_NAME_COLUMN_INDEX].Value = p.Name;
                row.Cells[HAS_PLAYED_COLUMN_INDEX].Value = "True";
                row.Cells[GOALS_COLUMN_INDEX].Value = 0;
                row.Cells[RED_CARD_COLUMN_INDEX].Value = 0;

                awayEventsGrid.Rows.Add(row);
            }
        }

        private bool CheckScore(int homeScore, DataGridView eventsGrid)
        {
            int totalGoals = 0;
            foreach (DataGridViewRow row in eventsGrid.Rows)
            {
                if (row.Cells[GOALS_COLUMN_INDEX].Value == null)
                {
                    continue;
                }
                if (row.Cells[HAS_PLAYED_COLUMN_INDEX].Value.Equals("True"))
                {
                    string goalStr = row.Cells[GOALS_COLUMN_INDEX].Value.ToString();
                    int goals = Int32.Parse(goalStr);
                    totalGoals += goals;
                }
            }

            return totalGoals == homeScore;
        }

        private void UpdatePlayers(DataGridView eventsGrid)
        {
            foreach (DataGridViewRow row in eventsGrid.Rows)
            {
                if (row.Cells[GOALS_COLUMN_INDEX].Value == null)
                {
                    continue;
                }

                int id = (int)row.Cells[PLAYER_ID_COLUMN_INDEX].Value;
                Player p = _playerRepository.GetPlayer(id);
                int goals = Int32.Parse(row.Cells[GOALS_COLUMN_INDEX].Value.ToString());
                if (!row.Cells[RED_CARD_COLUMN_INDEX].Value.ToString().Equals("0"))
                {
                    p.RedCards += 1;
                }

                if (row.Cells[HAS_PLAYED_COLUMN_INDEX].Value.Equals("True"))
                {
                    p.NoGames += 1;
                    p.NoGoals += goals;
                }

            }
        }

        private void awayEventsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
