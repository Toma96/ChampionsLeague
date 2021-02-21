using System.Collections.Generic;
using System.Linq;
using ChampionsLeague.Model.Repositories;
using ChampionsLeague.Model;
using NHibernate;
using NHibernate.Linq;

namespace ChampionsLeague.DataAccessLayer.Repository
{
    enum POINTS_BY_GAME { Draw = 1, Win = 3 }
    public class GameRepository : IGameRepository
    {
        private ISession _currSession = null;
        public GameRepository(ISession inSession)
        {
            _currSession = inSession;
        }

        public void AddGame(Game game)
        {
            int awayTeamScore = game.TeamAwayScore;
            int homeTeamScore = game.TeamHomeScore;

            Team homeTeam = game.TeamHome;
            Team awayTeam = game.TeamAway;

            UpdateTeams(homeTeam, awayTeam, homeTeamScore, awayTeamScore);

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Save(game);
                transaction.Commit();
            }
        }

        public void DeleteGame(Game game)
        {
            Game g = _currSession.Get<Game>(game.ID);
            if (g == null) { return; }

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Delete(g);
                transaction.Commit();
            }
        }

        public IList<Game> GetAllGames()
        {
            List<Game> games = _currSession.Query<Game>().ToList();
            return games;
        }

        public Game GetGameById(int gameId)
        {
            Game game = _currSession.Get<Game>(gameId);
            return game;
        }

        public IList<Game> GetGamesByGroup(string groupId)
        {
            List<Game> games = _currSession.Query<Game>().Where(x => x.Group.Name == groupId).ToList();
            return games;
        }

        public IList<Game> GetGamesByTeam(string teamId)
        {
            List<Game> games = _currSession.Query<Game>().ToList();
            List<Game> teamGames = new List<Game>();
            foreach(Game g in games)
            {
                if (g.TeamAway.Name == teamId || g.TeamHome.Name == teamId)
                {
                    teamGames.Add(g);
                }
            }

            return teamGames;
        }

        public void UndoGame(Game game)
        {
            Team homeTeam = game.TeamHome;
            Team awayTeam = game.TeamAway;
            int homeTeamScore = game.TeamHomeScore;
            int awayTeamScore = game.TeamAwayScore;
            UndoTeams(homeTeam, awayTeam, homeTeamScore, awayTeamScore);
        }

        public void UpdateGame(Game game)
        {
            Game g = _currSession.Get<Game>(game.ID);
            if(g == null) { return; }
            g = game;

            int awayTeamScore = game.TeamAwayScore;
            int homeTeamScore = game.TeamHomeScore;

            Team homeTeam = game.TeamHome;
            Team awayTeam = game.TeamAway;

            UpdateTeams(homeTeam, awayTeam, homeTeamScore, awayTeamScore);

            using (ITransaction transaction = _currSession.BeginTransaction())
            {
                _currSession.Update(g);
                transaction.Commit();
            }
        }

        private void UpdateTeams(Team homeTeam, Team awayTeam, int homeTeamScore, int awayTeamScore)
        {
            if (homeTeamScore == awayTeamScore)
            {
                homeTeam.Points += (short)POINTS_BY_GAME.Draw;
                awayTeam.Points += (short)POINTS_BY_GAME.Draw;
                homeTeam.NoDraws += 1;
                awayTeam.NoDraws += 1;
            }
            else
            {
                Team winningTeam = homeTeamScore > awayTeamScore ? homeTeam : awayTeam;
                Team losingTeam = winningTeam == homeTeam ? awayTeam : homeTeam;

                winningTeam.Points += (short)POINTS_BY_GAME.Win;
                winningTeam.NoWins += 1;
                losingTeam.NoLosses += 1;
            }

            homeTeam.NoPlayedGames += 1;
            awayTeam.NoPlayedGames += 1;

            homeTeam.GoalsScored += homeTeamScore;
            homeTeam.GoalsConceded += awayTeamScore;
            homeTeam.GoalDifference += (homeTeamScore - awayTeamScore);

            awayTeam.GoalsScored += awayTeamScore;
            awayTeam.GoalsConceded += homeTeamScore;
            awayTeam.GoalDifference += (awayTeamScore - homeTeamScore);
        }

        private void UndoTeams(Team homeTeam, Team awayTeam, int homeTeamScore, int awayTeamScore)
        {
            if (homeTeamScore == awayTeamScore)
            {
                homeTeam.Points -= (short)POINTS_BY_GAME.Draw;
                awayTeam.Points -= (short)POINTS_BY_GAME.Draw;
                homeTeam.NoDraws -= 1;
                awayTeam.NoDraws -= 1;
            }
            else
            {
                Team winningTeam = homeTeamScore > awayTeamScore ? homeTeam : awayTeam;
                Team losingTeam = winningTeam == homeTeam ? awayTeam : homeTeam;

                winningTeam.Points -= (short)POINTS_BY_GAME.Win;
                winningTeam.NoWins -= 1;
                losingTeam.NoLosses -= 1;
            }

            homeTeam.NoPlayedGames -= 1;
            awayTeam.NoPlayedGames -= 1;

            homeTeam.GoalsScored -= homeTeamScore;
            homeTeam.GoalsConceded -= awayTeamScore;
            homeTeam.GoalDifference -= (homeTeamScore - awayTeamScore);

            awayTeam.GoalsScored -= awayTeamScore;
            awayTeam.GoalsConceded -= homeTeamScore;
            awayTeam.GoalDifference -= (awayTeamScore - homeTeamScore);
        }

    }
}
