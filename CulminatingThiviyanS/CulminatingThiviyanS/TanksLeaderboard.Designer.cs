namespace CulminatingThiviyanS
{
    partial class TanksLeaderboard
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
            this.lblLeaderboard = new System.Windows.Forms.Label();
            this.lblTopPlayersEasy = new System.Windows.Forms.Label();
            this.lblTopPlayersHard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLeaderboard
            // 
            this.lblLeaderboard.AutoSize = true;
            this.lblLeaderboard.BackColor = System.Drawing.Color.Transparent;
            this.lblLeaderboard.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaderboard.Location = new System.Drawing.Point(284, 26);
            this.lblLeaderboard.Name = "lblLeaderboard";
            this.lblLeaderboard.Size = new System.Drawing.Size(260, 41);
            this.lblLeaderboard.TabIndex = 0;
            this.lblLeaderboard.Text = "LEADERBOARD";
            // 
            // lblTopPlayersEasy
            // 
            this.lblTopPlayersEasy.AutoSize = true;
            this.lblTopPlayersEasy.BackColor = System.Drawing.Color.Transparent;
            this.lblTopPlayersEasy.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPlayersEasy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTopPlayersEasy.Location = new System.Drawing.Point(170, 153);
            this.lblTopPlayersEasy.Name = "lblTopPlayersEasy";
            this.lblTopPlayersEasy.Size = new System.Drawing.Size(192, 19);
            this.lblTopPlayersEasy.TabIndex = 1;
            this.lblTopPlayersEasy.Text = "Top 10 Players (Easy Mode):";
            // 
            // lblTopPlayersHard
            // 
            this.lblTopPlayersHard.AutoSize = true;
            this.lblTopPlayersHard.BackColor = System.Drawing.Color.Transparent;
            this.lblTopPlayersHard.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopPlayersHard.ForeColor = System.Drawing.Color.Maroon;
            this.lblTopPlayersHard.Location = new System.Drawing.Point(461, 153);
            this.lblTopPlayersHard.Name = "lblTopPlayersHard";
            this.lblTopPlayersHard.Size = new System.Drawing.Size(193, 19);
            this.lblTopPlayersHard.TabIndex = 2;
            this.lblTopPlayersHard.Text = "Top 10 Players (Hard Mode):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(293, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 72);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player Score vs. Computer Score\r\nHIGH SCORES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Teal;
            this.btnBack.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 30);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // TanksLeaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImage = global::CulminatingThiviyanS.Images.GreenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTopPlayersHard);
            this.Controls.Add(this.lblTopPlayersEasy);
            this.Controls.Add(this.lblLeaderboard);
            this.Name = "TanksLeaderboard";
            this.Text = "Leaderboard";
            this.Load += new System.EventHandler(this.TanksLeaderboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLeaderboard;
        private System.Windows.Forms.Label lblTopPlayersEasy;
        private System.Windows.Forms.Label lblTopPlayersHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}