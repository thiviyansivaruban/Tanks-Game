//Name: Thiviyan Sivaruban
//Date: June 17, 2024
//Title: Culminating (Tanks Game)
//Purpose: To create a one player game where the user chooses the power of the shot they are going to make each round to try to hit the computer tank.
//         There are 10 rounds, though player can end game before that. 
//         There is an easy mode and hard mode (with wind and smarter ai)

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulminatingThiviyanS
{
    public partial class TanksGame : Form
    {
        public TanksGame()
        {
            InitializeComponent();
        }

        //VARIABLE DECLARATION

        //Public variables to use in different forms.
        public static string strPlayerName;
        public static bool blnEasyMode;

        //Integer variables to help with projectile motion of the object, includes initial and final displacement and initial and final velocity.
        static int intFinalDisplacementH;
        static int intFinalDisplacementV;
        static int intPlayerInitialVelocityH = 10;
        static int intCompInitialVelocityH = 10;
        static int intInitialVelocityV = 20;
        static int intFinalVelocityH;
        static int intFinalVelocityV;
        static int intHorizontalMove;
        static int intVerticalMove;
        static int intPower = 0;

        //Other integer variables to manage score, round, shots, etc.
        static int intPlayerScore = 0;
        static int intCompScore = 0;
        static int intTanksDistance;
        static int intShot = 0;
        static int intTotalPlayers = 0;
        static int intRound = 1;
        static int intTemp;
        static int intExistingPlayer;

        //Boolean variables that are used to only run the code if condition is met
        static bool blnPlayerWin = false;
        static bool blnCompWin = false;
        static bool blnPlayerTurn = true;
        static bool blnUp = true;
        static bool blnComputerShot = true;
        static bool blnMiss = true;
        static bool blnOne = true;
        static bool blnExistingPlayer = false;
        static bool blnSafe = false;

        //Array variables to store values for record of player shots and for leaderboard
        static int[] intPlayerShots = { -99 };
        static int[] intTempShots = { -99 };
        static int[] intPlayerScores;
        static int[] intTempPlayerScores;
        static int[] intCompScores;
        static int[] intTempCompScores;

        static string[] strNames;
        static string[] strTempNames;

        //String variables for record, and to help with managing files
        static string strRecord = "";
        static string strInput = null;
        static string strTemp;

        //Random number generator
        Random random = new Random();

        //Function to calculate initial horizontal displacement given initial horizontal velocity and angle
        public int horizontalValue(int intHypotenuse, int intDegree)
        {
            return (int)(intHypotenuse * Math.Cos((double)intDegree * Math.PI / 180));
        }

        //Function to calculate initial vertical displacement given initial vertical velocity and angle
        public int verticalValue(int intHypotenuse, int intDegree)
        {
            return (int)(intHypotenuse * Math.Sin((double)intDegree * Math.PI / 180));
        }

        //Formula: v2(squared) = v1(squared) + 2(accelaration due to gravity[9.81])(displacement)
        //Function to calculate final velocity given initial velocity and initial displacement
        public int finalVelocity(int intInitialVelocity, int intDisplacement)
        {
            return (int)(Math.Sqrt((Math.Pow(intInitialVelocity, 2) + (2 * 9.81 * intDisplacement))));
        }

        //Function to calculate final displacement given final velocity and initial velocity
        public int finalDisplacement(int intFinalVelocity, int intInitialVelocity)
        {
            return (int)((Math.Pow(intFinalVelocity, 2) - Math.Pow(intInitialVelocity, 2)) / (2 * 9.81));
        }
        private void TanksGame_Load(object sender, EventArgs e)
        {
            //Runs following code when this form is loaded

            if (blnEasyMode == false)
            {
                intPlayerInitialVelocityH = random.Next(8, 13); //chooses random wind level
            }

            //Sets tanks at random positions
            this.pcbPlayerTank.Left = random.Next(12, 250);
            this.pcbCompTank.Left = random.Next(480, 718);
            this.pcbProjectile1.Top = 451;
            this.pcbProjectile1.Left = this.pcbPlayerTank.Left + 27;
            this.pcbProjectile2.Top = 451;
            this.pcbProjectile2.Left = this.pcbCompTank.Left + 30;
            intPower = 20; //default power level - 20
            this.tmrObstacle.Enabled = true; //enables obstacle timer right away to allow obstacle to move up and down
        }

        private void tmrGame_Tick(object sender, EventArgs e)
        {
            //Runs following code when game timer is started

            if (blnPlayerTurn == false) //computer's turn
            {
                blnMiss = true;

                this.lblTurn.Text = "Turn: COMPUTER";

                if (blnComputerShot == true)
                {
                    intTanksDistance = this.pcbCompTank.Left - this.pcbPlayerTank.Left;

                    if (blnEasyMode == true)
                    {
                        //computer launches shot that lands in a range of the player's tank (range is larger due to easy mode)
                        intPower = random.Next((intTanksDistance / 12) - 14, (intTanksDistance / 12) + 14); 
                    }
                    else
                    {
                        //computer launches shot that lands in a range of the player's tank (range is smaller due to hard mode)
                        intPower = random.Next((intTanksDistance / 12) - 6, (intTanksDistance / 12) + 6);
                    }

                    //Chooses how high to lauch the computer shot depending on the power
                    if (intPower >= 60)
                    {
                        intInitialVelocityV = 15;
                        if (this.pcbObstacle.Top < 0) //avoids obstacle as best as possible
                        {
                            blnComputerShot = false;
                            blnSafe = true;
                        }
                    }
                    else if (intPower >= 55)
                    {
                        intInitialVelocityV = 20;
                        if (this.pcbObstacle.Top < 0) //avoids obstacle as best as possible
                        {
                            blnComputerShot = false;
                            blnSafe = true;
                        }
                    }
                    else if (intPower >= 40)
                    {
                        intInitialVelocityV = 23;
                        if (this.pcbObstacle.Top < 0) //avoids obstacle as best as possible
                        {
                            blnComputerShot = false;
                            blnSafe = true;
                        }
                    }
                    else if (intPower >= 25)
                    {
                        intInitialVelocityV = 30;
                        if (this.pcbObstacle.Top < (this.Height / 2) && blnUp == true) //avoids obstacle as best as possible
                        {
                            blnComputerShot = false;
                            blnSafe = true;
                        }
                    }
                    else
                    {
                        intInitialVelocityV = 45;
                        if (this.pcbObstacle.Top < (this.Height / 2) && blnUp == true) //avoids obstacle as best as possible
                        {
                            blnComputerShot = false;
                            blnSafe = true;
                        }
                    }

                    if (blnEasyMode == true)
                    {
                        //ignores computer AI for easy mode
                        blnComputerShot = false;
                        blnSafe = true;
                    }
                }
            }

            //Uses the functions to determine final horizontal and vertical displacements (using velocities, power, and displacements)

            if (blnPlayerTurn == true) //this code uses the player initial horizontal velocity (may alter due to wind)
            {
                intHorizontalMove = horizontalValue(intPlayerInitialVelocityH, intPower);
                intVerticalMove = verticalValue(intInitialVelocityV, intPower);

                intFinalVelocityH = finalVelocity(intPlayerInitialVelocityH, intHorizontalMove);
                intFinalVelocityV = finalVelocity(intInitialVelocityV, intVerticalMove);

                intFinalDisplacementH = finalDisplacement(intFinalVelocityH, intPlayerInitialVelocityH);
                intFinalDisplacementV = finalDisplacement(intFinalVelocityV, intInitialVelocityV);
            }
            else //this code uses the computer initial velocity
            {
                intHorizontalMove = horizontalValue(intCompInitialVelocityH, intPower);
                intVerticalMove = verticalValue(intInitialVelocityV, intPower);

                intFinalVelocityH = finalVelocity(intCompInitialVelocityH, intHorizontalMove);
                intFinalVelocityV = finalVelocity(intInitialVelocityV, intVerticalMove);

                intFinalDisplacementH = finalDisplacement(intFinalVelocityH, intCompInitialVelocityH);
                intFinalDisplacementV = finalDisplacement(intFinalVelocityV, intInitialVelocityV);
            }

            if (blnPlayerTurn == true)
            {
                this.lblTurn.Text = "Turn: PLAYER";
                this.pcbProjectile1.Left += intFinalDisplacementH; //applys horizontal displacement to projectile
                this.pcbProjectile1.Top -= intFinalDisplacementV; //applys vertical displacement to projectile
            }
            else if (blnSafe == true) //(only launches computer shot when it can shoot to avoid the obstacle as best as possible) (only applies to hard mode)
            {
                this.pcbProjectile2.Left -= intFinalDisplacementH; //applys horizontal displacement to projectile
                this.pcbProjectile2.Top -= intFinalDisplacementV; //applys vertical displacement to projectile
            }

            if (blnPlayerTurn == true)
            {
                intPower--; //angle decreases every tick which allows it fall back down (projectile motion)
            }
            else if (blnSafe == true)
            {
                intPower--;
            }

            //Projectile intersections which determine win or lose
            if (this.pcbProjectile1.Bounds.IntersectsWith(this.pcbCompTank.Bounds) == true)
            {
                //IF PLAYER PROJECTILE INTERSECTS WITH COMPUTER TANK:

                //Records player shot, increases player score, resets locations, new round
                PlayerShots();
                blnPlayerWin = true;
                blnPlayerTurn = false;
                Reset();
                RandomLocation();
                intPlayerScore++;
                intRound++;
                intPower = 20;
                intInitialVelocityV = 20;

                if (blnEasyMode == false) //if hard mode, chooses new wind level
                {
                    intTemp = random.Next(8, 13);
                    while (intTemp == intPlayerInitialVelocityH)
                    {
                        intTemp = random.Next(8, 13);
                    }
                    intPlayerInitialVelocityH = intTemp;
                }
                if (intRound == 11) //ends game at round 10, determines winner based on scores
                {
                    if (intPlayerScore > intCompScore)
                    {
                        MessageBox.Show("YOU WON!\nScore: " + intPlayerScore + " - " + intCompScore);
                        GameOver();
                    }
                    else if (intCompScore > intPlayerScore)
                    {
                        MessageBox.Show("COMPUTER WON!\nScore: " + intPlayerScore + " - " + intCompScore);
                        GameOver();
                    }
                    else
                    {
                        MessageBox.Show("DRAW!\nScore: " + intPlayerScore + " - " + intCompScore);
                        GameOver();
                    }
                }
                blnComputerShot = true;
                blnSafe = false;
            }
            else if (this.pcbProjectile1.Bounds.IntersectsWith(this.pcbObstacle.Bounds) == true)
            {
                //IF PLAYER PROJECTILE INTERSECTS WITH OBSTACLE:

                //Records player shot, resets power, sets to computer turn
                PlayerShots();
                blnPlayerTurn = false;
                Reset();
                RandomLocation();
                intPower = 20;
                intInitialVelocityV = 20;
                blnComputerShot = true;
                blnSafe = false;
            }
            else if (this.pcbProjectile1.Top > this.Height || this.pcbProjectile1.Left > this.Width)
            {
                //IF PLAYER PROJECTILE INTERSECTS WITH THE GROUND OR RIGHT WALL:

                //Records player shot, resets power, sets to computer turn

                if (blnMiss == true)
                {
                    PlayerShots();
                }

                blnPlayerTurn = false;
                Reset();
                RandomLocation();
                intPower = 20;
                intInitialVelocityV = 20;
                blnComputerShot = true;
                blnSafe = false;
            }

            if (this.pcbProjectile2.Bounds.IntersectsWith(this.pcbPlayerTank.Bounds) == true)
            {
                //IF COMPUTER PROJECTILE INTERSECTS WITH PLAYER TANK:

                //Increases computer score, resets locations, new round
                blnCompWin = true;
                blnPlayerTurn = true;
                Reset();
                RandomLocation();
                intCompScore++;
                intRound++;
                intPower = 20;
                intInitialVelocityV = 20;

                if (blnEasyMode == false) //chooses random wind level if hard mode
                {
                    intTemp = random.Next(8, 13);
                    while (intTemp == intPlayerInitialVelocityH)
                    {
                        intTemp = random.Next(8, 13);
                    }
                    intPlayerInitialVelocityH = intTemp;
                }

                if (intRound == 11) //ends game after 10 rounds, and determines winner based on scores
                {
                    if (intPlayerScore > intCompScore)
                    {
                        MessageBox.Show("YOU WON!\nScore: " + intPlayerScore + " - " + intCompScore);
                        GameOver();
                    }
                    else if (intCompScore > intPlayerScore)
                    {
                        MessageBox.Show("COMPUTER WON!\nScore: " + intPlayerScore + " - " + intCompScore);
                        GameOver();
                    }
                    else
                    {
                        MessageBox.Show("DRAW!\nScore: " + intPlayerScore + " - " + intCompScore);
                        GameOver();
                    }
                }
            }
            else if (this.pcbProjectile2.Bounds.IntersectsWith(this.pcbObstacle.Bounds) == true)
            {
                //IF COMPUTER PROJECTILE INTERSECTS WITH THE OBSTACLE:

                //Resets power, sets to computer turn
                blnPlayerTurn = true;
                Reset();
                RandomLocation();
                intPower = 20;
                intInitialVelocityV = 20;
            }
            else if (this.pcbProjectile2.Top > this.Height || this.pcbProjectile2.Left < 0)
            {
                //IF COMPUTER PROJECTILE INTERSECTS WITH THE GROUND OR LEFT WALL:

                //Resets power, sets to computer turn
                blnPlayerTurn = true;
                Reset();
                RandomLocation();
                intPower = 20;
                intInitialVelocityV = 20;
            }
        }

        private void tmrObstacle_Tick(object sender, EventArgs e)
        {
            //Obstacle Timer, the following code is constantly running when this form is open, since the obstacle is always moving
            
            if (intRound <= 10)
            {
                //Displays round and score
                this.lblRound.Text = "Round: #" + intRound + " (Score: " + intPlayerScore + " - " + intCompScore + ")";
            }

            //Displays user and individual scores
            this.lblUser.Text = "User: " + strPlayerName;
            this.lblPlayerScore.Text = "Score: " + intPlayerScore.ToString();
            this.lblCompScore.Text = "Score: " + intCompScore.ToString();

            //Shows Wind Arrows depending on initial horizontal velocity
            if (intPlayerInitialVelocityH == 8)
            {
                this.lblWind.Text = "Wind: <<<<----";
            }
            else if (intPlayerInitialVelocityH == 9)
            {
                this.lblWind.Text = "Wind: <<--";
            }
            else if (intPlayerInitialVelocityH == 10)
            {
                this.lblWind.Text = "Wind: None";
            }
            else if (intPlayerInitialVelocityH == 11)
            {
                this.lblWind.Text = "Wind: -->>";
            }
            else if (intPlayerInitialVelocityH == 12)
            {
                this.lblWind.Text = "Wind: ---->>>>";
            }

            //Allows obstacle in the middle to be in constant up and down motion, changes to opposite direction when hits top edge and bottom edge

            if (this.pcbObstacle.Top > 0 && blnUp == true)
            {
                if (blnEasyMode == true)
                {
                    this.pcbObstacle.Top -= 5; //moves up slower if easy mode
                }
                else
                {
                    this.pcbObstacle.Top -= 10; //moves up faster if hard mode
                }
            }
            else
            {
                blnUp = false;

                if (blnEasyMode == true)
                {
                    this.pcbObstacle.Top += 5; //moves down slower if easy mode
                }
                else
                {
                    this.pcbObstacle.Top += 10; //moves down faster if hard mode
                }
                if (this.pcbObstacle.Top + this.pcbObstacle.Height > this.Height)
                {
                    blnUp = true;
                }
            }
        }

        private void TanksGame_KeyDown(object sender, KeyEventArgs e)
        {
            //Allows the user to press keys to control the game

            if (this.tmrGame.Enabled == false)
            {
                if (e.KeyData == Keys.Down) //DOWN ARROW KEY - decreases power
                {
                    if (intPower != 20)
                    {
                        intPower--;
                    }
                    this.lblPower.Text = "Power: " + intPower.ToString();
                    
                }
                if (e.KeyData == Keys.Up) //UP ARROW KEY - increases power
                {
                    if (intPower != 70)
                    {
                        intPower++;
                    }
                    this.lblPower.Text = "Power: " + intPower.ToString();
                    
                }
               
                if (e.KeyData == Keys.R) //R KEY - shows record of player shots
                {
                    strRecord = "";

                    if (intPlayerShots[0] == -99)
                    {
                        //ensures user has made at least one shot before showing record
                        MessageBox.Show("You have to make at least one shot before you can view the record of your shots.");
                    }
                    else
                    {
                        for (int i = 0; i < intPlayerShots.Length; i++)
                        {
                            if (intPlayerShots[i] == 0)
                            {
                                strRecord += "Player Shot #" + (i + 1) + ": HIT!\n"; //record says hit if player hit computer tank
                            }
                            else if (intPlayerShots[i] == -10)
                            {
                                strRecord += "Player Shot #" + (i + 1) + ": OBSTACLE!\n"; //record says obstacle if player hit obstacle
                            }
                            else
                            {
                                strRecord += "Player Shot #" + (i + 1) + ": " + intPlayerShots[i] + " pixels off\n"; //record say number of pixels off if missed
                            }
                        }
                        MessageBox.Show(strRecord); //displays record
                    }
                }
                if (e.KeyData == Keys.Space) //SPACE BAR - launch shot
                {
                    this.tmrGame.Enabled = true; //starts game timer when space bar is pressed
                }
            }
            if (e.KeyData == Keys.E) //E KEY - end game
            {
                //Displays winner (or draw)
                if (intPlayerScore > intCompScore)
                {
                    MessageBox.Show("YOU WON!\nScore: " + intPlayerScore + " - " + intCompScore);
                    GameOver(); //ends game
                }
                else if (intCompScore > intPlayerScore)
                {
                    MessageBox.Show("COMPUTER WON!\nScore: " + intPlayerScore + " - " + intCompScore);
                    GameOver();
                }
                else
                {
                    MessageBox.Show("DRAW!\nScore: " + intPlayerScore + " - " + intCompScore);
                    GameOver();
                }
            }
        }

        private void PlayerShots()
        {
            //Manages array that holds all the player shots to be used when displaying record

            //Determines how many pixels player is off by, if player hit tank then intShot is 0
            if (this.pcbProjectile1.Left + this.pcbProjectile1.Width < this.pcbCompTank.Left)
            {
                intShot = this.pcbCompTank.Left - (this.pcbProjectile1.Left + this.pcbProjectile1.Width);
            }
            else if (this.pcbProjectile1.Left > this.pcbCompTank.Left + this.pcbCompTank.Width)
            {
                intShot = this.pcbProjectile1.Left - (this.pcbCompTank.Left + this.pcbCompTank.Width);
            }
            else
            {
                intShot = 0;
            }

            if (intPlayerShots.Length == 1 && blnOne == true)
            {
                intPlayerShots[0] = intShot;
                blnOne = false;
            }
            else
            {
                //ADDS on to the record for every shot the player makes
                for (int i = 0; i < intTempShots.Length; i++)
                {
                    intTempShots[i] = intPlayerShots[i];
                }

                intPlayerShots = new int[intPlayerShots.Length + 1];

                for (int i = 0; i < intTempShots.Length; i++)
                {
                    intPlayerShots[i] = intTempShots[i];
                }

                intTempShots = new int[intTempShots.Length + 1];

                if (this.pcbProjectile1.Bounds.IntersectsWith(this.pcbObstacle.Bounds) == true)
                {
                    intShot = -10; //temporarily sets intShot as -10 to change the text to OBSTACLE
                }

                intPlayerShots[intPlayerShots.Length - 1] = intShot;
            }

            blnMiss = false;
        }

        private void RandomLocation()
        {
            //Places player and computer tanks at random location when game is started and every time a tank is hit
            if (blnPlayerWin == true || blnCompWin == true)
            {
                this.pcbPlayerTank.Left = random.Next(12, 250);
                this.pcbCompTank.Left = random.Next(480, 718);
                blnPlayerWin = false;
                blnCompWin = false;
            }
            this.pcbProjectile1.Top = 451;
            this.pcbProjectile1.Left = this.pcbPlayerTank.Left + 27;

            this.pcbProjectile2.Top = 451;
            this.pcbProjectile2.Left = this.pcbCompTank.Left + 30;
        }

        private void Reset()
        {
            //Resets labels and power
            intPower = 20;
            if (blnPlayerTurn == true)
            {
                this.lblTurn.Text = "Turn: PLAYER";
                this.tmrGame.Enabled = false;
            }
            else
            {
                this.lblTurn.Text = "Turn: COMPUTER";
            }

            this.lblPower.Text = "Power: " + intPower.ToString();
            
        }

        private void GameOver()
        {
            //Runs following code when game is ended

            intTotalPlayers = 0;

            MessageBox.Show("GAME OVER\nFile of Leaderboard has been saved.");

            if (blnEasyMode == true)
            {
                LeaderboardEasyMode(); //Saves file for easy mode leaderboard
            }
            else
            {
                LeaderboardHardMode(); //Saves file for hard mode leaderboard
            }

            //Disables timers, resets arrays, scores, horizontal velocity
            this.tmrGame.Enabled = false;
            this.tmrObstacle.Enabled = false;

            intPlayerShots = new int[1];
            intTempShots = new int[1];

            intPlayerShots[0] = -99;
            intTempShots[0] = -99;

            blnOne = true;
            blnExistingPlayer = false;

            strInput = null;

            intPlayerScore = 0;
            intCompScore = 0;
            intRound = 1;
            intPlayerInitialVelocityH = 10;

            this.lblWind.Text = "Wind: None";

            //Hides this form and displays start up menu
            StartMenu StartUp = new StartMenu();
            this.Hide();
            StartUp.Show();
        }

        private void LeaderboardEasyMode()
        {
            //Edits easy mode leaderboard if the user played in easy mode

            StreamReader re = File.OpenText("LeaderboardEasyMode.txt"); //opens easy mode leaderboard file

            while ((strInput = re.ReadLine()) != null)
            {
                intTotalPlayers++; //counts number of players in file
            }
            re.Close();

            //Sets sizes of all arrays
            strNames = new string[intTotalPlayers];
            strTempNames = new string[intTotalPlayers];
            intPlayerScores = new int[intTotalPlayers];
            intTempPlayerScores = new int[intTotalPlayers];
            intCompScores = new int[intTotalPlayers];
            intTempCompScores = new int[intTotalPlayers];

            re = File.OpenText("LeaderboardEasyMode.txt"); //opens file

            //SPLICES values in file to get hold of player names, player scores, and computer scores
            for (int i = 0; i < intTotalPlayers; i++)
            {
                strInput = re.ReadLine();
               
                strNames[i] = strInput.Substring(strInput.IndexOf(")") + 2, strInput.IndexOf(":") - (strInput.IndexOf(")") + 2));

                strInput = strInput.Substring(strInput.IndexOf(":") + 2);

                if (intPlayerScore != 10)
                {
                    intPlayerScores[i] = Int32.Parse(strInput.Substring(0, 1));
                }
                else
                {
                    intPlayerScores[i] = Int32.Parse(strInput.Substring(0, 2));
                }

                strInput = strInput.Substring(strInput.IndexOf("-") + 2);

                if (intCompScore != 10)
                {
                    intCompScores[i] = Int32.Parse(strInput.Substring(0, 1));
                }
                else
                {
                    intCompScores[i] = Int32.Parse(strInput.Substring(0, 2));
                }
            }
            re.Close();

            //Checks for existing player (checks name to see if it matches with any name in the file)
            for (int i = 0; i < intTotalPlayers; i++)
            {
                if (strPlayerName.ToUpper() == strNames[i].ToUpper())
                {
                    blnExistingPlayer = true;
                    intExistingPlayer = i;
                }
            }

            //REPLACES score of existing player with new score if it's higher than their previous score
            if (blnExistingPlayer == true)
            {
                if (intPlayerScore > intPlayerScores[intExistingPlayer])
                {
                    intPlayerScores[intExistingPlayer] = intPlayerScore;
                    intCompScores[intExistingPlayer] = intCompScore;
                }
                else if (intPlayerScore == intPlayerScores[intExistingPlayer])
                {
                    if (intCompScore < intCompScores[intExistingPlayer])
                    {
                        intPlayerScores[intExistingPlayer] = intPlayerScore;
                        intCompScores[intExistingPlayer] = intCompScore;
                    }
                }
            }
            else
            {
                //ADDS new player to the end of the leaderboard

                for (int i = 0; i < intTotalPlayers; i++)
                {
                    strTempNames[i] = strNames[i];
                    intTempPlayerScores[i] = intPlayerScores[i];
                    intTempCompScores[i] = intCompScores[i];
                }

                intTotalPlayers++; //increases total number of players

                strNames = new string[intTotalPlayers];
                intPlayerScores = new int[intTotalPlayers];
                intCompScores = new int[intTotalPlayers];

                for (int i = 0; i < intTotalPlayers - 1; i++)
                {
                    strNames[i] = strTempNames[i];
                    intPlayerScores[i] = intTempPlayerScores[i];
                    intCompScores[i] = intTempCompScores[i];
                }

                strNames[intTotalPlayers - 1] = strPlayerName;
                intPlayerScores[intTotalPlayers - 1] = intPlayerScore;
                intCompScores[intTotalPlayers - 1] = intCompScore;
            }

            //SORTS LEADERBOARD BASED ON PLAYER SCORE
            //if multiple people have the same player score, checks to see who has the lowest computer score and they will be placed higher
            for (int i = 0; i < intTotalPlayers; i++)
            {
                for (int j = 0; j < intTotalPlayers - 1; j++)
                {
                    if (intPlayerScores[j] < intPlayerScores[j + 1])
                    {
                        strTemp = strNames[j];
                        strNames[j] = strNames[j + 1];
                        strNames[j + 1] = strTemp;

                        intTemp = intPlayerScores[j];
                        intPlayerScores[j] = intPlayerScores[j + 1];
                        intPlayerScores[j + 1] = intTemp;

                        intTemp = intCompScores[j];
                        intCompScores[j] = intCompScores[j + 1];
                        intCompScores[j + 1] = intTemp;
                    }
                    else if (intPlayerScores[j] == intPlayerScores[j + 1])
                    {
                        if (intCompScores[j] > intCompScores[j + 1])
                        {
                            strTemp = strNames[j];
                            strNames[j] = strNames[j + 1];
                            strNames[j + 1] = strTemp;

                            intTemp = intPlayerScores[j];
                            intPlayerScores[j] = intPlayerScores[j + 1];
                            intPlayerScores[j + 1] = intTemp;

                            intTemp = intCompScores[j];
                            intCompScores[j] = intCompScores[j + 1];
                            intCompScores[j + 1] = intTemp;
                        }
                    }
                }
            }

            File.Delete("LeaderboardEasyMode.txt"); //Deletes the file
            FileInfo t = new FileInfo("LeaderboardEasyMode.txt"); //Creates new file
            StreamWriter FileText = t.CreateText();

            for (int i = 0; i < intTotalPlayers; i++)
            {
                //WRITES the new leaderboard onto the new file
                FileText.WriteLine("#" + (i + 1) + ") " + strNames[i] + ": " + intPlayerScores[i] + " - " + intCompScores[i]);
            }
            FileText.Close(); //closes file
        }

        private void LeaderboardHardMode()
        {
            StreamReader re = File.OpenText("LeaderboardHardMode.txt"); //opens hard mode leaderboard file

            while ((strInput = re.ReadLine()) != null)
            {
                intTotalPlayers++; //counts number of players
            }
            re.Close();

            //sets sizes of all arrays
            strNames = new string[intTotalPlayers];
            strTempNames = new string[intTotalPlayers];
            intPlayerScores = new int[intTotalPlayers];
            intTempPlayerScores = new int[intTotalPlayers];
            intCompScores = new int[intTotalPlayers];
            intTempCompScores = new int[intTotalPlayers];

            re = File.OpenText("LeaderboardHardMode.txt"); //opens file

            //SPLICES values in file to get hold of player names, player scores, and computer scores
            for (int i = 0; i < intTotalPlayers; i++)
            {
                strInput = re.ReadLine();
                strNames[i] = strInput.Substring(4, strInput.IndexOf(":") - 4);

                strInput = strInput.Substring(strInput.IndexOf(":") + 2);

                if (intPlayerScores[i] != 10)
                {
                    intPlayerScores[i] = Int32.Parse(strInput.Substring(0, 1));
                }
                else
                {
                    intPlayerScores[i] = Int32.Parse(strInput.Substring(0, 2));
                }

                strInput = strInput.Substring(strInput.IndexOf("-") + 2);

                if (intCompScores[i] != 10)
                {
                    intCompScores[i] = Int32.Parse(strInput.Substring(0, 1));
                }
                else
                {
                    intCompScores[i] = Int32.Parse(strInput.Substring(0, 2));
                }
            }
            re.Close();

            //Checks for existing player
            for (int i = 0; i < intTotalPlayers; i++)
            {
                if (strPlayerName.ToUpper() == strNames[i].ToUpper())
                {
                    blnExistingPlayer = true;
                    intExistingPlayer = i;
                }
            }

            //Replaces score of existing player if greater than previous score
            if (blnExistingPlayer == true)
            {
                if (intPlayerScore > intPlayerScores[intExistingPlayer])
                {
                    intPlayerScores[intExistingPlayer] = intPlayerScore;
                    intCompScores[intExistingPlayer] = intCompScore;
                }
                else if (intPlayerScore == intPlayerScores[intExistingPlayer])
                {
                    if (intCompScore < intCompScores[intExistingPlayer])
                    {
                        intPlayerScores[intExistingPlayer] = intPlayerScore;
                        intCompScores[intExistingPlayer] = intCompScore;
                    }
                }
            }
            else
            {
                //Adds new player to end of leaderboard
                for (int i = 0; i < intTotalPlayers; i++)
                {
                    strTempNames[i] = strNames[i];
                    intTempPlayerScores[i] = intPlayerScores[i];
                    intTempCompScores[i] = intCompScores[i];
                }

                intTotalPlayers++;

                strNames = new string[intTotalPlayers];
                intPlayerScores = new int[intTotalPlayers];
                intCompScores = new int[intTotalPlayers];

                for (int i = 0; i < intTotalPlayers - 1; i++)
                {
                    strNames[i] = strTempNames[i];
                    intPlayerScores[i] = intTempPlayerScores[i];
                    intCompScores[i] = intTempCompScores[i];
                }

                strNames[intTotalPlayers - 1] = strPlayerName;
                intPlayerScores[intTotalPlayers - 1] = intPlayerScore;
                intCompScores[intTotalPlayers - 1] = intCompScore;
            }

            //SORTS leaderboard based on highest player score (if same checks lowest computer score)
            for (int i = 0; i < intTotalPlayers; i++)
            {
                for (int j = 0; j < intTotalPlayers - 1; j++)
                {
                    if (intPlayerScores[j] < intPlayerScores[j + 1])
                    {
                        strTemp = strNames[j];
                        strNames[j] = strNames[j + 1];
                        strNames[j + 1] = strTemp;

                        intTemp = intPlayerScores[j];
                        intPlayerScores[j] = intPlayerScores[j + 1];
                        intPlayerScores[j + 1] = intTemp;

                        intTemp = intCompScores[j];
                        intCompScores[j] = intCompScores[j + 1];
                        intCompScores[j + 1] = intTemp;
                    }
                    else if (intPlayerScores[j] == intPlayerScores[j + 1])
                    {
                        if (intCompScores[j] > intCompScores[j + 1])
                        {
                            strTemp = strNames[j];
                            strNames[j] = strNames[j + 1];
                            strNames[j + 1] = strTemp;

                            intTemp = intPlayerScores[j];
                            intPlayerScores[j] = intPlayerScores[j + 1];
                            intPlayerScores[j + 1] = intTemp;

                            intTemp = intCompScores[j];
                            intCompScores[j] = intCompScores[j + 1];
                            intCompScores[j + 1] = intTemp;
                        }
                    }
                }
            }

            File.Delete("LeaderboardHardMode.txt"); //deletes the file
            FileInfo t = new FileInfo("LeaderboardHardMode.txt"); //creates new file
            StreamWriter FileText = t.CreateText();

            for (int i = 0; i < intTotalPlayers; i++)
            {
                //WRITES the new leaderboard onto the new file
                FileText.WriteLine("#" + (i + 1) + ") " + strNames[i] + ": " + intPlayerScores[i] + " - " + intCompScores[i]);
            }
            FileText.Close(); //closes file
        }
    }
}
