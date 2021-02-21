using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System;
using System.Windows.Forms;

namespace ChampionsLeague
{ 
    public partial class frmEditGame : Form, IUpdateGame
    {
        private IGameController _gameController;
        private Game _selectedGame;
        private IViewGroupGames _form;

        public frmEditGame()
        {
            InitializeComponent();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        public void UpdateGame(IViewGroupGames form, IGameController gameController, Game selectedGame)
        {
            _gameController = gameController;
            _selectedGame = selectedGame;
            _form = form;

            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int homeTeamScore = Int32.Parse(this.teamHomeScore.Text);
                int awayTeamScore = Int32.Parse(this.teamAwayScore.Text);

                _gameController.UndoGame(_selectedGame);

                _selectedGame.TeamHomeScore = homeTeamScore;
                _selectedGame.TeamAwayScore = awayTeamScore;

                _gameController.UpdateGameScore(this, _selectedGame, _form);
                Close();
            } catch (Exception)
            {
                MessageBox.Show("Inputs have to be integers!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void teamAwayScore_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
