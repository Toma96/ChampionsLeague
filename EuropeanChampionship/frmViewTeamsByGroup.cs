using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;

namespace ChampionsLeague
{
    public partial class frmViewTeamsByGroup : Form, IViewTeamsByGroup
    {
        IList<Team> _teams;
        Group _group;
        public frmViewTeamsByGroup()
        {
            InitializeComponent();
        }

        public void ShowTeamsByGroup(Group group, IList<Team> teams)
        {
            _teams = teams;
            _group = group;

            UpdateList();
            this.Show();
        }

        private void UpdateList()
        {
            teamStanding.Rows.Clear();
            teamStanding.Refresh();

            IList<Team> teams = _teams;
            IEnumerable<Team> sortedEnum = teams.OrderByDescending(f => f.Points).ThenBy(f => f.NoLosses).ThenByDescending(f => f.GoalDifference);
            IList<Team> sortedTeams = sortedEnum.ToList();

            teamStanding.DataSource = sortedTeams;
            groupStanding.Text = "Group " + _group.Name + " standings";

            teamStanding.Columns["Group"].Visible = false;
            teamStanding.Columns["Games"].Visible = false;

        }

        private void frmViewTeamsByGroup_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _teams = null;
            Close();
        }

        private void teamStanding_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                string targetTeamStr = teamStanding.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                Team targetTeam = _teams[0];
                foreach (Team t in _teams)
                {
                    if (t.Name.Equals(targetTeamStr))
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
