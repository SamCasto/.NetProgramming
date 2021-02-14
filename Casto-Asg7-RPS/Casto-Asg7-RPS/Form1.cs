using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_Asg7_RPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //enum statement and global variables
        enum RPS { Rock, Paper, Scissors };
        int totalGames = 0;
        int playerWins = 0;
        int compWins = 0;
        int ties = 0;

        //main game logic
        private void playRound(RPS playerChoice)
        {
            //string variable to declare the winner
            String winner = "";
            //getting the computers choice
            RPS computerChoice;            
            computerChoice = getCompChoice();

            //increasing the total amount of games 
            totalGames++;

            //logic for determing a winner
            if (playerChoice == RPS.Rock && computerChoice == RPS.Rock)
            {
                winner = "Tie!";
                ties++;
            }
            else if (playerChoice == RPS.Paper && computerChoice == RPS.Paper)
            {
                winner = "Tie!";
                ties++;
            }
            else if (playerChoice == RPS.Scissors && computerChoice == RPS.Scissors)
            {
                winner = "Tie!";
                ties++;
            }
            else if (playerChoice == RPS.Rock && computerChoice == RPS.Paper)
            {
                winner = "Computer Wins!";
                compWins++;
            }
            else if (playerChoice == RPS.Paper && computerChoice == RPS.Scissors)
            {
                winner = "Computer Wins!";
                compWins++;
            }
            else if (playerChoice == RPS.Scissors && computerChoice == RPS.Rock)
            {
                winner = "Computer Wins!";
                compWins++;
            }
            else //if (playerChoice == RPS.Rock && computerChoice == RPS.Scissors)
            {
                winner = "Player Wins!";
                playerWins++;
            }

            //updating all the labels
            labelTotalGames.Text = totalGames.ToString();
            labelCompChoice.Text = computerChoice.ToString();
            labelPlayersChoice.Text = playerChoice.ToString();
            labelWinner.Text = winner;
            labelTotalTies.Text = ties.ToString();
            labelPlayerWins.Text = playerWins.ToString();
            labelCompWins.Text = compWins.ToString();

        }
        //computer choice generation
        private RPS getCompChoice()
        {
            //declaring necessary variables
            RPS computerChoice;
            int randomNumber = 0;
            //random number logic
            Random random = new Random();
            randomNumber = random.Next(1, 4);
            //converting the random number into a choice
            if (randomNumber == 1)
                computerChoice = RPS.Rock;
            else if (randomNumber == 2)
                computerChoice = RPS.Paper;
            else
                computerChoice = RPS.Scissors;

            return computerChoice;
        }
        //resetting the game on application start
        private void resetGame()
        {
            //add code for clearing labels after labels are made
            labelCompChoice.Text = "";
            labelPlayersChoice.Text = "";
            labelWinner.Text = "";
            labelCompWins.Text = "0";
            labelPlayerWins.Text = "0";
            labelTotalGames.Text = "0";
            labelTotalTies.Text = "0";
            totalGames = 0;
            playerWins = 0;
            compWins = 0;
            ties = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetGame();
        }
        //buttons calling the main game logic
        private void buttonRock_Click(object sender, EventArgs e)
        {
            playRound(RPS.Rock);
        }

        private void buttonPaper_Click(object sender, EventArgs e)
        {
            playRound(RPS.Paper);
        }

        private void buttonScissors_Click(object sender, EventArgs e)
        {
            playRound(RPS.Scissors);
        }

        private void buttonResetTotals_Click(object sender, EventArgs e)
        {
            resetGame();
        }
    }
}
