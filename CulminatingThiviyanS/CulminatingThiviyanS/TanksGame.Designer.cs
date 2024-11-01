namespace CulminatingThiviyanS
{
    partial class TanksGame
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
            this.components = new System.ComponentModel.Container();
            this.lblRound = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.lblCompScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.lblReminders = new System.Windows.Forms.Label();
            this.tmrObstacle = new System.Windows.Forms.Timer(this.components);
            this.tmrGame = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pcbDownArrow = new System.Windows.Forms.PictureBox();
            this.pcbUpArrow = new System.Windows.Forms.PictureBox();
            this.pcbProjectile1 = new System.Windows.Forms.PictureBox();
            this.pcbProjectile2 = new System.Windows.Forms.PictureBox();
            this.pcbPlayerTank = new System.Windows.Forms.PictureBox();
            this.pcbObstacle = new System.Windows.Forms.PictureBox();
            this.pcbCompTank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDownArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProjectile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProjectile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerTank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObstacle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompTank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblRound.Location = new System.Drawing.Point(14, 72);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(97, 26);
            this.lblRound.TabIndex = 31;
            this.lblRound.Text = "Round #1";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.BackColor = System.Drawing.Color.Black;
            this.lblTurn.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTurn.Location = new System.Drawing.Point(17, 39);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(125, 26);
            this.lblTurn.TabIndex = 28;
            this.lblTurn.Text = "Turn: PLAYER";
            // 
            // lblCompScore
            // 
            this.lblCompScore.AutoSize = true;
            this.lblCompScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblCompScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompScore.Location = new System.Drawing.Point(649, 304);
            this.lblCompScore.Name = "lblCompScore";
            this.lblCompScore.Size = new System.Drawing.Size(67, 22);
            this.lblCompScore.TabIndex = 27;
            this.lblCompScore.Text = "Score: 0";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPlayerScore.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(10, 304);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(67, 22);
            this.lblPlayerScore.TabIndex = 26;
            this.lblPlayerScore.Text = "Score: 0";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.BackColor = System.Drawing.Color.Red;
            this.lblComputer.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(649, 326);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(137, 27);
            this.lblComputer.TabIndex = 25;
            this.lblComputer.Text = "COMPUTER";
            // 
            // lblReminders
            // 
            this.lblReminders.AutoSize = true;
            this.lblReminders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblReminders.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReminders.Location = new System.Drawing.Point(503, 21);
            this.lblReminders.Name = "lblReminders";
            this.lblReminders.Size = new System.Drawing.Size(285, 75);
            this.lblReminders.TabIndex = 23;
            this.lblReminders.Text = "REMINDERS:\r\nPress UP and DOWN arrow keys to adjust power\r\nPress SPACE BAR to laun" +
    "ch shot\r\nPress R to display RECORD of shots\r\nPress E to END game";
            // 
            // tmrObstacle
            // 
            this.tmrObstacle.Interval = 40;
            this.tmrObstacle.Tick += new System.EventHandler(this.tmrObstacle_Tick);
            // 
            // tmrGame
            // 
            this.tmrGame.Interval = 40;
            this.tmrGame.Tick += new System.EventHandler(this.tmrGame_Tick);
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblPlayer.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(10, 326);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(96, 27);
            this.lblPlayer.TabIndex = 24;
            this.lblPlayer.Text = "PLAYER";
            // 
            // lblPower
            // 
            this.lblPower.AutoSize = true;
            this.lblPower.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lblPower.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(23, 191);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(119, 25);
            this.lblPower.TabIndex = 18;
            this.lblPower.Text = "Power: 20";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Purple;
            this.lblTitle.Font = new System.Drawing.Font("Sylfaen", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.LawnGreen;
            this.lblTitle.Location = new System.Drawing.Point(344, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 39);
            this.lblTitle.TabIndex = 17;
            this.lblTitle.Text = "TANKS!";
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWind.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWind.Location = new System.Drawing.Point(13, 98);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(120, 26);
            this.lblWind.TabIndex = 32;
            this.lblWind.Text = "Wind: None";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Gold;
            this.lblUser.Location = new System.Drawing.Point(19, 12);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 18);
            this.lblUser.TabIndex = 33;
            this.lblUser.Text = "User:";
            // 
            // pcbDownArrow
            // 
            this.pcbDownArrow.BackgroundImage = global::CulminatingThiviyanS.Images.DownArrow;
            this.pcbDownArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbDownArrow.Location = new System.Drawing.Point(86, 224);
            this.pcbDownArrow.Name = "pcbDownArrow";
            this.pcbDownArrow.Size = new System.Drawing.Size(49, 39);
            this.pcbDownArrow.TabIndex = 35;
            this.pcbDownArrow.TabStop = false;
            // 
            // pcbUpArrow
            // 
            this.pcbUpArrow.BackgroundImage = global::CulminatingThiviyanS.Images.UpArrow;
            this.pcbUpArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbUpArrow.Location = new System.Drawing.Point(31, 224);
            this.pcbUpArrow.Name = "pcbUpArrow";
            this.pcbUpArrow.Size = new System.Drawing.Size(49, 39);
            this.pcbUpArrow.TabIndex = 34;
            this.pcbUpArrow.TabStop = false;
            // 
            // pcbProjectile1
            // 
            this.pcbProjectile1.BackColor = System.Drawing.Color.Transparent;
            this.pcbProjectile1.BackgroundImage = global::CulminatingThiviyanS.Images.Projectile;
            this.pcbProjectile1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbProjectile1.Location = new System.Drawing.Point(38, 451);
            this.pcbProjectile1.Name = "pcbProjectile1";
            this.pcbProjectile1.Size = new System.Drawing.Size(18, 18);
            this.pcbProjectile1.TabIndex = 22;
            this.pcbProjectile1.TabStop = false;
            // 
            // pcbProjectile2
            // 
            this.pcbProjectile2.BackColor = System.Drawing.Color.Transparent;
            this.pcbProjectile2.BackgroundImage = global::CulminatingThiviyanS.Images.Projectile;
            this.pcbProjectile2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbProjectile2.Location = new System.Drawing.Point(746, 451);
            this.pcbProjectile2.Name = "pcbProjectile2";
            this.pcbProjectile2.Size = new System.Drawing.Size(18, 18);
            this.pcbProjectile2.TabIndex = 29;
            this.pcbProjectile2.TabStop = false;
            // 
            // pcbPlayerTank
            // 
            this.pcbPlayerTank.BackgroundImage = global::CulminatingThiviyanS.Images.PlayerTank;
            this.pcbPlayerTank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbPlayerTank.Location = new System.Drawing.Point(12, 395);
            this.pcbPlayerTank.Name = "pcbPlayerTank";
            this.pcbPlayerTank.Size = new System.Drawing.Size(70, 66);
            this.pcbPlayerTank.TabIndex = 16;
            this.pcbPlayerTank.TabStop = false;
            // 
            // pcbObstacle
            // 
            this.pcbObstacle.BackColor = System.Drawing.Color.Black;
            this.pcbObstacle.BackgroundImage = global::CulminatingThiviyanS.Images.Hazard;
            this.pcbObstacle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbObstacle.Location = new System.Drawing.Point(391, 338);
            this.pcbObstacle.Name = "pcbObstacle";
            this.pcbObstacle.Size = new System.Drawing.Size(28, 113);
            this.pcbObstacle.TabIndex = 21;
            this.pcbObstacle.TabStop = false;
            // 
            // pcbCompTank
            // 
            this.pcbCompTank.BackgroundImage = global::CulminatingThiviyanS.Images.ComputerTank;
            this.pcbCompTank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbCompTank.Location = new System.Drawing.Point(718, 399);
            this.pcbCompTank.Name = "pcbCompTank";
            this.pcbCompTank.Size = new System.Drawing.Size(70, 66);
            this.pcbCompTank.TabIndex = 20;
            this.pcbCompTank.TabStop = false;
            // 
            // TanksGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.pcbProjectile1);
            this.Controls.Add(this.pcbProjectile2);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.lblCompScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblReminders);
            this.Controls.Add(this.pcbPlayerTank);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.pcbObstacle);
            this.Controls.Add(this.lblPower);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pcbCompTank);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.pcbDownArrow);
            this.Controls.Add(this.pcbUpArrow);
            this.KeyPreview = true;
            this.Name = "TanksGame";
            this.Text = "TanksGame";
            this.Load += new System.EventHandler(this.TanksGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TanksGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pcbDownArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUpArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProjectile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProjectile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlayerTank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbObstacle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCompTank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.PictureBox pcbProjectile1;
        private System.Windows.Forms.PictureBox pcbProjectile2;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label lblCompScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label lblReminders;
        private System.Windows.Forms.Timer tmrObstacle;
        private System.Windows.Forms.PictureBox pcbPlayerTank;
        private System.Windows.Forms.Timer tmrGame;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.PictureBox pcbObstacle;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox pcbCompTank;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pcbUpArrow;
        private System.Windows.Forms.PictureBox pcbDownArrow;
    }
}