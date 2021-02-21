using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;

namespace ChampionsLeague.Controller
{
    public class InitialFormController : IInitialFormController
    {
        private readonly IWindowsFormsFactory _formFactory;
        private IGroupRepository _groupRepository;
        private ITeamRepository _teamRepository;
        private IGameRepository _gameRepository;
        private IPlayerRepository _playerRepository;
        private bool _defaultModelLoaded = false;

        public InitialFormController(IWindowsFormsFactory inFactory, ITeamRepository teamRepo, IGameRepository gameRepo, IPlayerRepository playerRepo, IGroupRepository groupRepo)
        {
            _teamRepository = teamRepo;
            _gameRepository = gameRepo;
            _playerRepository = playerRepo;
            _groupRepository = groupRepo;
            _formFactory = inFactory;
        }

        public void LoadDefaultModel()
        {
            if(_defaultModelLoaded == false)
            {
                Group groupA = new Group("A");
                Group groupB = new Group("B");
                _groupRepository.AddGroup(groupA);
                _groupRepository.AddGroup(groupB);

                Team real = new Team("Real Madrid", groupA);
                Team manUtd = new Team("Manchester United", groupA);
                Game GameA = new Game(real, manUtd, groupA);
                Team Barca = new Team("Barcelona", groupB);
                Team bayern = new Team("Bayern", groupB);
                Game GameB = new Game(Barca, bayern, groupB);

                Player modric = new Player("Modrić", real, Position.MID);
                Player pogba = new Player("Pogba", manUtd, Position.MID);
                Player messi = new Player("Messi", Barca, Position.FW);
                Player neuer = new Player("Neuer", bayern, Position.GK);
                _teamRepository.AddTeam(real);
                groupA.Teams.Add(real);
                _teamRepository.AddTeam(manUtd);
                groupA.Teams.Add(manUtd);
                _teamRepository.AddTeam(Barca);
                groupB.Teams.Add(Barca);
                _teamRepository.AddTeam(bayern);
                groupB.Teams.Add(bayern);
                _gameRepository.AddGame(GameA);
                _gameRepository.AddGame(GameB);

                _playerRepository.AddPlayer(modric);
                _playerRepository.AddPlayer(pogba);
                _playerRepository.AddPlayer(neuer);
                _playerRepository.AddPlayer(messi);


                _defaultModelLoaded = true;
            }
        }

        public void ShowAllGroups()
        {
            var newForm = _formFactory.CreateViewGroups();
            IGroupController groupController = new GroupController(_groupRepository);

            groupController.ShowAllGroups(newForm);
        }

        public void ShowAllTeams()
        {
            var newForm = _formFactory.CreateViewTeams();
            ITeamController teamController = new TeamController(_teamRepository, _groupRepository);

            teamController.ShowAllTeams(newForm);
        }

        public void ShowGroupGames()
        {
            var newForm = _formFactory.CreateViewGroupGames();
            IGameController gameController = new GameController(_gameRepository, _teamRepository, _playerRepository);

            gameController.ShowAllGroupGames(newForm);
        }

        public void ShowAllPlayers()
        {
            var newForm = _formFactory.CreateViewPlayers();
            IPlayerController playerController = new PlayerController(_playerRepository, _teamRepository);

            playerController.ShowAllPlayers(newForm);
        }
    }
}
