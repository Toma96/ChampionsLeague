using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class frmViewGroupGames : Form, IViewGroupGames
    {
        private IGameController _gameController;
        private IGameRepository _gamesRepository;
        private ITeamRepository _teamRepository;
        private Game _selectedGame;

        private static readonly int TEAMHOME_COLUMN_INDEX = 0;
        private static readonly int TEAMHOME_SCORE_INDEX = 1;
        private static readonly int TEAMAWAY_SCORE_INDEX = 2;
        private static readonly int TEAMAWAY_COLUMN_INDEX = 3;
        private static readonly int GROUP_COLUMN_INDEX = 4;


        public frmViewGroupGames()
        {
            InitializeComponent();
        }

        private void UpdateList()
        {
            gameList.Rows.Clear();
            gameList.Refresh();

            foreach (Game g in _gamesRepository.GetAllGames())
            {
                DataGridViewRow row = (DataGridViewRow)gameList.Rows[0].Clone();
                row.Cells[0].Value = g.TeamHome.Name;
                row.Cells[1].Value = g.TeamHomeScore;
                row.Cells[2].Value = g.TeamAwayScore;
                row.Cells[3].Value = g.TeamAway.Name;
                row.Cells[4].Value = g.TeamAway.Group;
                gameList.Rows.Add(row);
            }
        }

        public void ShowAllGroupGames(IGameController gameController, IGameRepository gameRepository, ITeamRepository teamRepository)
        {
            _gameController = gameController;
            _gamesRepository = gameRepository;
            _teamRepository = teamRepository;

            UpdateList();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if(_selectedGame != null)
            {
                var newForm = new frmEditGame();
                newForm.UpdateGame(this, _gameController, _selectedGame);
                UpdateList();
            }
        }

        private void gameList_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (e.ColumnIndex == TEAMHOME_SCORE_INDEX || e.ColumnIndex == TEAMAWAY_SCORE_INDEX)
                {
                    string teamHome = gameList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    string teamAway = gameList.Rows[e.RowIndex].Cells[3].Value.ToString();

                    var gameListTmp = _gamesRepository.GetAllGames();
                    foreach (Game g in gameListTmp)
                    {
                        if (g.TeamHome.Name.Equals(teamHome) && g.TeamAway.Name.Equals(teamAway))
                        {
                            _selectedGame = g;
                            break;
                        }
                    }
                    var newForm = new frmEditGame();
                    newForm.UpdateGame(this, _gameController, _selectedGame);
                    UpdateList();
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var newForm = new frmAddNewGame();
            _gameController.ShowAddGame(newForm, this);
            UpdateList();
        }

        private void gameList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GROUP_COLUMN_INDEX && e.RowIndex >= 0)
            {
                Group targetGroup = (Group) gameList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                IList<Team> targetTeams = targetGroup.Teams;

                var newForm = new frmViewTeamsByGroup();
                newForm.ShowTeamsByGroup(targetGroup, targetTeams);
            }
            else if ((e.ColumnIndex == TEAMHOME_COLUMN_INDEX || e.ColumnIndex == TEAMAWAY_COLUMN_INDEX) && e.RowIndex >= 0)
            {
                Team targetTeam = _teamRepository.GetTeam(gameList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                IList<Player> targetPlayers = targetTeam.Players;

                var newForm = new frmViewPlayersByTeam();
                newForm.ShowPlayersByTeam(targetTeam, targetPlayers);
            }
        }
    }
}
