
namespace ChampionsLeague
{
    partial class frmViewPlayersByTeam
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
            this.playersList = new System.Windows.Forms.DataGridView();
            this.titleLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.playersList)).BeginInit();
            this.SuspendLayout();
            // 
            // playersList
            // 
            this.playersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersList.Location = new System.Drawing.Point(33, 41);
            this.playersList.Name = "playersList";
            this.playersList.RowHeadersWidth = 51;
            this.playersList.RowTemplate.Height = 24;
            this.playersList.Size = new System.Drawing.Size(729, 334);
            this.playersList.TabIndex = 0;
            this.playersList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(356, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 17);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "label1";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(323, 392);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(119, 46);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // frmViewPlayersByTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.playersList);
            this.Name = "frmViewPlayersByTeam";
            this.Text = "frmViewPlayersByTeam";
            ((System.ComponentModel.ISupportInitialize)(this.playersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView playersList;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button backButton;
    }
}