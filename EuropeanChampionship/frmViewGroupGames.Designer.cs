namespace ChampionsLeague
{
    partial class frmViewGroupGames
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gameList = new System.Windows.Forms.DataGridView();
            this.TeamHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamHomeScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamAwayScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameList)).BeginInit();
            this.SuspendLayout();
            // 
            // gameList
            // 
            this.gameList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamHome,
            this.TeamHomeScore,
            this.TeamAwayScore,
            this.TeamAway,
            this.Group});
            this.gameList.Location = new System.Drawing.Point(36, 57);
            this.gameList.Margin = new System.Windows.Forms.Padding(4);
            this.gameList.Name = "gameList";
            this.gameList.ReadOnly = true;
            this.gameList.RowHeadersWidth = 51;
            this.gameList.Size = new System.Drawing.Size(747, 270);
            this.gameList.TabIndex = 0;
            this.gameList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameList_CellEndEdit);
            this.gameList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameList_CellContentClick);
            this.gameList.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gameList_CellEndEdit);
            // 
            // TeamHome
            // 
            this.TeamHome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamHome.FillWeight = 154.4224F;
            this.TeamHome.HeaderText = "Team Home";
            this.TeamHome.MinimumWidth = 6;
            this.TeamHome.Name = "TeamHome";
            this.TeamHome.ReadOnly = true;
            // 
            // TeamHomeScore
            // 
            this.TeamHomeScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamHomeScore.FillWeight = 51.1558F;
            this.TeamHomeScore.HeaderText = "Home Score";
            this.TeamHomeScore.MinimumWidth = 6;
            this.TeamHomeScore.Name = "TeamHomeScore";
            this.TeamHomeScore.ReadOnly = true;
            // 
            // TeamAwayScore
            // 
            this.TeamAwayScore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamAwayScore.FillWeight = 50.76142F;
            this.TeamAwayScore.HeaderText = "Away Score";
            this.TeamAwayScore.MinimumWidth = 6;
            this.TeamAwayScore.Name = "TeamAwayScore";
            this.TeamAwayScore.ReadOnly = true;
            // 
            // TeamAway
            // 
            this.TeamAway.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamAway.FillWeight = 163.9903F;
            this.TeamAway.HeaderText = "Team Away";
            this.TeamAway.MinimumWidth = 6;
            this.TeamAway.Name = "TeamAway";
            this.TeamAway.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.MinimumWidth = 6;
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 390);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(211, 42);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(49, 391);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(225, 40);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add Game";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // frmViewGroupGames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 475);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gameList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewGroupGames";
            this.Text = "frmViewTeams";
            ((System.ComponentModel.ISupportInitialize)(this.gameList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gameList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamHomeScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAwayScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamAway;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
    }
}