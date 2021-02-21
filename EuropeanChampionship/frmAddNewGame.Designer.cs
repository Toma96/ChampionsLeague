namespace ChampionsLeague
{
    partial class frmAddNewGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.HomeScore = new System.Windows.Forms.TextBox();
            this.AwayScore = new System.Windows.Forms.TextBox();
            this.awayEventsGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.homeEventsGrid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.IDHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoalsAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedCardHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HasPlayedAway = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.awayEventsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeEventsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home Team: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Home Team Score: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Away Team Score: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Away Team: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(123, 501);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 41);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(475, 501);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 41);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(314, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(274, 24);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(314, 209);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(278, 24);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // HomeScore
            // 
            this.HomeScore.Location = new System.Drawing.Point(314, 100);
            this.HomeScore.Name = "HomeScore";
            this.HomeScore.Size = new System.Drawing.Size(65, 22);
            this.HomeScore.TabIndex = 8;
            // 
            // AwayScore
            // 
            this.AwayScore.Location = new System.Drawing.Point(314, 156);
            this.AwayScore.Name = "AwayScore";
            this.AwayScore.Size = new System.Drawing.Size(65, 22);
            this.AwayScore.TabIndex = 9;
            // 
            // awayEventsGrid
            // 
            this.awayEventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.awayEventsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDAway,
            this.Player,
            this.Goals,
            this.RedCard,
            this.HasPlayedAway});
            this.awayEventsGrid.Location = new System.Drawing.Point(429, 292);
            this.awayEventsGrid.Name = "awayEventsGrid";
            this.awayEventsGrid.RowHeadersWidth = 51;
            this.awayEventsGrid.RowTemplate.Height = 24;
            this.awayEventsGrid.Size = new System.Drawing.Size(353, 176);
            this.awayEventsGrid.TabIndex = 10;
            this.awayEventsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.awayEventsGrid_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Away Events:";
            // 
            // homeEventsGrid
            // 
            this.homeEventsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.homeEventsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHome,
            this.PlayerHome,
            this.GoalsAway,
            this.RedCardHome,
            this.HasPlayed});
            this.homeEventsGrid.Location = new System.Drawing.Point(33, 292);
            this.homeEventsGrid.Name = "homeEventsGrid";
            this.homeEventsGrid.RowHeadersWidth = 51;
            this.homeEventsGrid.RowTemplate.Height = 24;
            this.homeEventsGrid.Size = new System.Drawing.Size(354, 176);
            this.homeEventsGrid.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(165, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Home Events:";
            // 
            // IDHome
            // 
            this.IDHome.HeaderText = "ID";
            this.IDHome.MinimumWidth = 6;
            this.IDHome.Name = "IDHome";
            this.IDHome.ReadOnly = true;
            this.IDHome.Width = 40;
            // 
            // PlayerHome
            // 
            this.PlayerHome.HeaderText = "Player";
            this.PlayerHome.MinimumWidth = 6;
            this.PlayerHome.Name = "PlayerHome";
            this.PlayerHome.ReadOnly = true;
            this.PlayerHome.Width = 150;
            // 
            // GoalsAway
            // 
            this.GoalsAway.HeaderText = "Goals";
            this.GoalsAway.MaxInputLength = 3;
            this.GoalsAway.MinimumWidth = 6;
            this.GoalsAway.Name = "GoalsAway";
            this.GoalsAway.Width = 80;
            // 
            // RedCardHome
            // 
            this.RedCardHome.HeaderText = "RedCard";
            this.RedCardHome.MaxInputLength = 1;
            this.RedCardHome.MinimumWidth = 6;
            this.RedCardHome.Name = "RedCardHome";
            this.RedCardHome.Width = 75;
            // 
            // HasPlayed
            // 
            this.HasPlayed.HeaderText = "InSquad";
            this.HasPlayed.MinimumWidth = 6;
            this.HasPlayed.Name = "HasPlayed";
            this.HasPlayed.Width = 125;
            // 
            // IDAway
            // 
            this.IDAway.HeaderText = "ID";
            this.IDAway.MinimumWidth = 6;
            this.IDAway.Name = "IDAway";
            this.IDAway.ReadOnly = true;
            this.IDAway.Width = 40;
            // 
            // Player
            // 
            this.Player.HeaderText = "Player";
            this.Player.MinimumWidth = 6;
            this.Player.Name = "Player";
            this.Player.ReadOnly = true;
            this.Player.Width = 150;
            // 
            // Goals
            // 
            this.Goals.HeaderText = "Goals";
            this.Goals.MaxInputLength = 3;
            this.Goals.MinimumWidth = 6;
            this.Goals.Name = "Goals";
            this.Goals.Width = 80;
            // 
            // RedCard
            // 
            this.RedCard.HeaderText = "RedCard";
            this.RedCard.MaxInputLength = 1;
            this.RedCard.MinimumWidth = 6;
            this.RedCard.Name = "RedCard";
            this.RedCard.Width = 75;
            // 
            // HasPlayedAway
            // 
            this.HasPlayedAway.HeaderText = "InSquad";
            this.HasPlayedAway.MinimumWidth = 6;
            this.HasPlayedAway.Name = "HasPlayedAway";
            this.HasPlayedAway.Width = 125;
            // 
            // frmAddNewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 568);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.homeEventsGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.awayEventsGrid);
            this.Controls.Add(this.AwayScore);
            this.Controls.Add(this.HomeScore);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddNewGame";
            this.Text = "frmAddNewGame";
            this.Load += new System.EventHandler(this.frmAddNewGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.awayEventsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeEventsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox HomeScore;
        private System.Windows.Forms.TextBox AwayScore;
        private System.Windows.Forms.DataGridView awayEventsGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView homeEventsGrid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAway;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goals;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasPlayedAway;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoalsAway;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedCardHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasPlayed;
    }
}