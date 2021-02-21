using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class frmViewTeams : Form, IViewTeams
    {
        private ITeamController _teamController;
        private IGroupRepository _groupRepository;
        IList<Team> _listTeams;

        private static readonly int TEAM_COLUMN_INDEX = 0;
        private static readonly int GROUP_COLUMN_INDEX = 1;
        public frmViewTeams()
        {
            InitializeComponent();
        }

        public void ShowAllTeams(ITeamController teamController, IGroupRepository groupRepository, List<Team> listTeam)
        {
            _teamController = teamController;
            _groupRepository = groupRepository;
            _listTeams = listTeam;

            UpdateList();

            this.Show();
        }

        private void UpdateList()
        {
            teamList.Rows.Clear();
            teamList.Refresh();
            foreach (Team t in _listTeams)
            {
                DataGridViewRow row = (DataGridViewRow)teamList.Rows[0].Clone();
                row.Cells[0].Value = t.Name;
                row.Cells[1].Value = t.Group;
                teamList.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new frmAddNewTeam();
            newForm.AddTeam(this, _teamController, _groupRepository);
            UpdateList();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        private void teamList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == GROUP_COLUMN_INDEX)
            {
                Group targetGroup = _groupRepository.GetGroup(teamList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
                IList<Team> targetTeams = targetGroup.Teams;

                var newForm = new frmViewTeamsByGroup();
                newForm.ShowTeamsByGroup(targetGroup, targetTeams);
            }
            else if (e.ColumnIndex == TEAM_COLUMN_INDEX)
            {
                string targetTeamStr = teamList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Team targetTeam = _listTeams[0];

                foreach (Team t in _listTeams)
                {
                    if (targetTeamStr.Equals(t.Name))
                    {
                        targetTeam = t;
                        break;
                    }
                }

                IList<Player> targetPlayers = targetTeam.Players;

                var newForm = new frmViewPlayersByTeam();
                newForm.ShowPlayersByTeam(targetTeam, targetPlayers);
            }
        }
    }
}
