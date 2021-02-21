
namespace ChampionsLeague
{
    partial class frmViewTeamsByGroup
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
            this.teamStanding = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupStanding = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.teamStanding)).BeginInit();
            this.SuspendLayout();
            // 
            // teamStanding
            // 
            this.teamStanding.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamStanding.Location = new System.Drawing.Point(26, 55);
            this.teamStanding.Name = "teamStanding";
            this.teamStanding.ReadOnly = true;
            this.teamStanding.RowHeadersWidth = 51;
            this.teamStanding.RowTemplate.Height = 24;
            this.teamStanding.Size = new System.Drawing.Size(833, 372);
            this.teamStanding.TabIndex = 0;
            this.teamStanding.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.teamStanding_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 447);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupStanding
            // 
            this.groupStanding.AutoSize = true;
            this.groupStanding.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupStanding.Location = new System.Drawing.Point(339, 18);
            this.groupStanding.Name = "groupStanding";
            this.groupStanding.Size = new System.Drawing.Size(159, 25);
            this.groupStanding.TabIndex = 2;
            this.groupStanding.Text = "Group Standings";
            // 
            // frmViewTeamsByGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.groupStanding);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.teamStanding);
            this.Name = "frmViewTeamsByGroup";
            this.Text = "frmViewTeamsByGroup";
            this.Load += new System.EventHandler(this.frmViewTeamsByGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.teamStanding)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView teamStanding;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label groupStanding;
    }
}