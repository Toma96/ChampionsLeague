using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using ChampionsLeague.Model.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ChampionsLeague
{
    public partial class frmViewGroups : Form, IViewGroups
    {
        private IGroupController _groupController;
        private IList<Group> _listGroups;

        public frmViewGroups()
        {
            InitializeComponent();
        }

        public void ShowAllGroups(IGroupController groupController, List<Group> listGroups)
        {
            _groupController = groupController;
            _listGroups = listGroups;
            UpdateList();

            this.Show();
        }

        private void UpdateList()
        {
            groupList.Rows.Clear();
            groupList.Refresh();

            foreach(Group g in _listGroups)
            {
                DataGridViewRow row = (DataGridViewRow)groupList.Rows[0].Clone();
                row.Cells[0].Value = g.Name;
                groupList.Rows.Add(row);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var newForm = new frmAddNewGroup();
            newForm.AddGroup(this, _groupController, _listGroups);
            UpdateList();
        }

        private void groupList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MessageBox.Show(e.RowIndex.ToString() + e.ColumnIndex.ToString(), "Title", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                Group targetGroup = _listGroups[e.RowIndex];
                IList<Team> targetTeams = targetGroup.Teams;

                var newForm = new frmViewTeamsByGroup();
                newForm.ShowTeamsByGroup(targetGroup, targetTeams);
            }
        }
    }
}
