using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class frmAddNewTeam : Form, IAddNewTeamView
    {
        private ITeamController _teamController;
        private IGroupRepository _groupRepository;
        IViewTeams _form;

        public frmAddNewTeam()
        {
            InitializeComponent();
        }

        public void AddTeam(IViewTeams form, ITeamController teamController, IGroupRepository groupRepository)
        {
            _teamController = teamController;
            _groupRepository = groupRepository;
            _form = form;
            AddComboBoxItems();
            this.Show();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.teamName.Text;
            
            Group teamGroup = group.SelectedItem as Group;

            Team t = new Team(name, teamGroup);

            if (teamGroup == null || t == null)
            {
                MessageBox.Show("Please specify the name of the team and group!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Group g in _groupRepository.GetAllGroups())
            {
                foreach (Team team in g.Teams)
                {
                    if (team.Name.Equals(t.Name))
                    {
                        MessageBox.Show("Team with that name already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            _teamController.AddNewTeam(this, t, teamGroup, _form);

            Close();
        }

        private void AddComboBoxItems()
        {
            IList<Group> groupsFromDB = _groupRepository.GetAllGroups();

            foreach(Group g in groupsFromDB)
            {
                group.Items.Add(g);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void group_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
