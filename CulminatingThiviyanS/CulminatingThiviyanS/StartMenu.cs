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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulminatingThiviyanS
{
    public partial class StartMenu : Form
    {
        public StartMenu()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Hides start menu and shows start game form
            StartGame Choose = new StartGame();
            this.Hide();
            Choose.Show();
        }

        private void btnHowToPlay_Click(object sender, EventArgs e)
        {
            //Hides start menu and shows how to play instructions form
            HowToPlay Instructions = new HowToPlay();
            this.Hide();
            Instructions.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Exits application
            Application.Exit();
        }

        private void btnLeaderboard_Click(object sender, EventArgs e)
        {
            //Hides start menu and shows leaderboard form
            TanksLeaderboard TopPlayers = new TanksLeaderboard();
            this.Hide();
            TopPlayers.Show();
        }
    }
}
