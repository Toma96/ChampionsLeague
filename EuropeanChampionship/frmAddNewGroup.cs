using ChampionsLeague.BaseLib;
using ChampionsLeague.Model;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ChampionsLeague
{
    public partial class frmAddNewGroup : Form, IAddNewGroupView
    {
        IList<Group> _groupList;
        IGroupController _groupController;
        IViewGroups _form;

        public frmAddNewGroup()
        {
            InitializeComponent();
        }

        public void AddGroup(IViewGroups form, IGroupController groupController, IList<Group> groupList)
        {
            _groupList = groupList;
            _groupController = groupController;
            _form = form;
            this.Show();
        }

        public bool ShowModal()
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = this.textBox1.Text;
            Group g = new Group(name);

            if (g.Name == "")
            {
                MessageBox.Show("Please specify the name of the group!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (Group group in _groupList)
            {
                if (group.Name.Equals(g.Name))
                {
                    MessageBox.Show("Group with that name already exists!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            _groupController.AddNewGroup(this, g, _form);
            this.Close();
        }
    }
}
