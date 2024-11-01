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
    public partial class TanksLeaderboard : Form
    {
        public TanksLeaderboard()
        {
            InitializeComponent();
        }
        
        //Public variables which are used in main game code
        public static string strInput = null;
        public static int intCounter = 1;

        private void TanksLeaderboard_Load(object sender, EventArgs e)
        {
            //Sets text of labels
            this.lblTopPlayersEasy.Text = "Top 10 Players (Easy Mode)\n\n";
            this.lblTopPlayersHard.Text = "Top 10 Players (Hard Mode)\n\n";

            StreamReader re1 = File.OpenText("LeaderboardEasyMode.txt"); //opens easy mode leaderboard
            
            intCounter = 1;

            while ((strInput = re1.ReadLine()) != null && intCounter < 11)
            {
                this.lblTopPlayersEasy.Text += strInput + "\n"; //outputs the easy mode leaderboard in the label
                intCounter++;
            }
            re1.Close(); //closes file

            StreamReader re2 = File.OpenText("LeaderboardHardMode.txt"); //opens hard mode leaderboard

            intCounter = 1;

            while ((strInput = re2.ReadLine()) != null && intCounter < 11)
            {
                this.lblTopPlayersHard.Text += strInput + "\n"; //outputs the hard mode leaderboard in the lavel
                intCounter++;
            }
            re2.Close(); //closes file
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hides leaderboard form and shows menu start up form
            StartMenu StartUp = new StartMenu();
            this.Hide();
            StartUp.Show();
        }
    }
}
