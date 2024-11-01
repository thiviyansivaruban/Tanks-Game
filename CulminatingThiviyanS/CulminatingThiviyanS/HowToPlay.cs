﻿//Name: Thiviyan Sivaruban
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
    public partial class HowToPlay : Form
    {
        public HowToPlay()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Hides how to play and shows start up menu
            StartMenu StartUp = new StartMenu();
            this.Hide();
            StartUp.Show();
        }
    }
}
