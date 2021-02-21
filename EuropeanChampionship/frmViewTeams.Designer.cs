namespace ChampionsLeague
{
    partial class frmViewTeams
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
            this.teamList = new System.Windows.Forms.DataGridView();
            this.TeamCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupCollumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.teamList)).BeginInit();
            this.SuspendLayout();
            // 
            // teamList
            // 
            this.teamList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeamCollumn,
            this.GroupCollumn});
            this.teamList.Location = new System.Drawing.Point(44, 28);
            this.teamList.Margin = new System.Windows.Forms.Padding(4);
            this.teamList.Name = "teamList";
            this.teamList.ReadOnly = true;
            this.teamList.RowHeadersWidth = 51;
            this.teamList.Size = new System.Drawing.Size(492, 223);
            this.teamList.TabIndex = 0;
            this.teamList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamList_CellContentClick);
            // 
            // TeamCollumn
            // 
            this.TeamCollumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TeamCollumn.HeaderText = "Team";
            this.TeamCollumn.MinimumWidth = 6;
            this.TeamCollumn.Name = "TeamCollumn";
            this.TeamCollumn.ReadOnly = true;
            // 
            // GroupCollumn
            // 
            this.GroupCollumn.HeaderText = "Group";
            this.GroupCollumn.MinimumWidth = 6;
            this.GroupCollumn.Name = "GroupCollumn";
            this.GroupCollumn.ReadOnly = true;
            this.GroupCollumn.Width = 125;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add new Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(308, 278);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 65);
            this.button2.TabIndex = 2;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmViewTeams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 358);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmViewTeams";
            this.Text = "frmViewTeams";
            ((System.ComponentModel.ISupportInitialize)(this.teamList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView teamList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamCollumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GroupCollumn;
    }
}