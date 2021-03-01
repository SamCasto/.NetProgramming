using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casto_Asg12_TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        struct TicTacToe
        {
            public int totalXWins;
            public int totalOWins;
            public int totalTies;
            public int totalGamesPlayed;
            public int currentPlayCount;
            public string currentPlayer;
            public bool isGameOver;
        }
        TicTacToe ttt;
        //resetting all necessary values to track in game play
        //and calling methods to start a new game
        private void newGame()
        {
            ttt.isGameOver = false;
            ttt.currentPlayCount = 1;
            labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
            labelDisplayOWins.Text = ttt.totalOWins.ToString();
            labelDisplayTies.Text = ttt.totalTies.ToString();
            labelDisplayXWins.Text = ttt.totalXWins.ToString();
            
            togglePlayer();
            resetButtons();
        }
        //resetting all buttons back to their enabled/gray states
        private void resetButtons()
        {
            buttonGrid1.Text = "";
            buttonGrid1.Enabled = true;
            buttonGrid1.BackColor = Color.LightGray;

            buttonGrid2.Text = "";
            buttonGrid2.Enabled = true;
            buttonGrid2.BackColor = Color.LightGray;

            buttonGrid3.Text = "";
            buttonGrid3.Enabled = true;
            buttonGrid3.BackColor = Color.LightGray;

            buttonGrid4.Text = "";
            buttonGrid4.Enabled = true;
            buttonGrid4.BackColor = Color.LightGray;

            buttonGrid5.Text = "";
            buttonGrid5.Enabled = true;
            buttonGrid5.BackColor = Color.LightGray;

            buttonGrid6.Text = "";
            buttonGrid6.Enabled = true;
            buttonGrid6.BackColor = Color.LightGray;

            buttonGrid7.Text = "";
            buttonGrid7.Enabled = true;
            buttonGrid7.BackColor = Color.LightGray;

            buttonGrid8.Text = "";
            buttonGrid8.Enabled = true;
            buttonGrid8.BackColor = Color.LightGray;

            buttonGrid9.Text = "";
            buttonGrid9.Enabled = true;
            buttonGrid9.BackColor = Color.LightGray;

        }
        //toggle player code using modulo 
        private void togglePlayer()
        {
            int modulo = 2;
            if (ttt.currentPlayCount % modulo == 0)
            {
                ttt.currentPlayer = "O";
                labelDisplayPlayersTurn.Text = "Player's O turn";
            }
            if (ttt.currentPlayCount % modulo == 1)
            {
                ttt.currentPlayer = "X";
                labelDisplayPlayersTurn.Text = "Player's X turn";
            }

        }
        //logic for looking for a winner and updating the proper
        //counts/labels
        private void lookForWin()
        {
            //string to hold the winner
            String winner;
            //manually checking each row/column/diagonal for a win
            //by seeing if the text matches on the buttons and excluding
            //blank spaces in the matching
            if (buttonGrid1.Text == buttonGrid2.Text && buttonGrid2.Text == buttonGrid3.Text
                && buttonGrid1.Text != "")
            {
                //setting winner equal to the text in the button which
                //would be the player's name and displaying it
                //and changing the color of the winning buttons
                ttt.isGameOver = true;
                winner = buttonGrid1.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid1.BackColor = Color.DarkOliveGreen;
                buttonGrid2.BackColor = Color.DarkOliveGreen;
                buttonGrid3.BackColor = Color.DarkOliveGreen;
                //comparing winner to see which player won and 
                //updating struct variables/labels
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                    
            }
            else if (buttonGrid4.Text == buttonGrid5.Text && buttonGrid5.Text == buttonGrid6.Text
                && buttonGrid4.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid4.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid4.BackColor = Color.DarkOliveGreen;
                buttonGrid5.BackColor = Color.DarkOliveGreen;
                buttonGrid6.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }

            }
            else if (buttonGrid7.Text == buttonGrid8.Text && buttonGrid8.Text == buttonGrid9.Text
                && buttonGrid7.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid7.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid7.BackColor = Color.DarkOliveGreen;
                buttonGrid8.BackColor = Color.DarkOliveGreen;
                buttonGrid9.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
            }
            else if (buttonGrid1.Text == buttonGrid4.Text && buttonGrid4.Text == buttonGrid7.Text
                && buttonGrid1.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid1.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid1.BackColor = Color.DarkOliveGreen;
                buttonGrid4.BackColor = Color.DarkOliveGreen;
                buttonGrid7.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
            }
            else if (buttonGrid2.Text == buttonGrid5.Text && buttonGrid5.Text == buttonGrid8.Text
                && buttonGrid2.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid2.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid5.BackColor = Color.DarkOliveGreen;
                buttonGrid2.BackColor = Color.DarkOliveGreen;
                buttonGrid8.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
            }
            else if (buttonGrid3.Text == buttonGrid6.Text && buttonGrid6.Text == buttonGrid9.Text
                && buttonGrid3.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid3.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid6.BackColor = Color.DarkOliveGreen;
                buttonGrid9.BackColor = Color.DarkOliveGreen;
                buttonGrid3.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
            }
            else if (buttonGrid1.Text == buttonGrid5.Text && buttonGrid5.Text == buttonGrid9.Text
                && buttonGrid1.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid1.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid1.BackColor = Color.DarkOliveGreen;
                buttonGrid5.BackColor = Color.DarkOliveGreen;
                buttonGrid9.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
            }
            else if (buttonGrid3.Text == buttonGrid5.Text && buttonGrid5.Text == buttonGrid7.Text
                && buttonGrid3.Text != "")
            {
                ttt.isGameOver = true;
                winner = buttonGrid3.Text;
                labelDisplayPlayersTurn.Text = "The winner is " + winner;
                buttonGrid3.BackColor = Color.DarkOliveGreen;
                buttonGrid5.BackColor = Color.DarkOliveGreen;
                buttonGrid7.BackColor = Color.DarkOliveGreen;
                if (winner == "X")
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalXWins++;
                    labelDisplayXWins.Text = ttt.totalXWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
                else
                {
                    ttt.totalGamesPlayed++;
                    ttt.totalOWins++;
                    labelDisplayOWins.Text = ttt.totalOWins.ToString();
                    labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();
                }
            }
            //checking for a tie if no winner is found at the end of the game
            else if (ttt.currentPlayCount == 10)
            {
                labelDisplayPlayersTurn.Text = "Tie!";
                ttt.isGameOver = true;
                ttt.totalGamesPlayed++;
                ttt.totalTies++;
                labelDisplayTies.Text = ttt.totalTies.ToString();
                labelDisplayTotalGames.Text = ttt.totalGamesPlayed.ToString();

            }
        }
        private void makeAPlay(Button buttonJustClicked)
        {
            if(ttt.isGameOver == false){
                buttonJustClicked.Enabled = false;
                ttt.currentPlayCount++;
                buttonJustClicked.Text = ttt.currentPlayer;
                togglePlayer();
                //only looking for a win after someone could feasibly win
                if (ttt.currentPlayCount >= 6)
                {
                    lookForWin();
                }
                
                
            }
            
            
        }
        
        private void button8_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid8);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid7);
        }

        private void buttonGrid1_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid1);
        }

        private void buttonGrid2_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid2);
        }

        private void buttonGrid3_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid3);
        }

        private void buttonGrid4_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid4);
        }

        private void buttonGrid5_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid5);
        }

        private void buttonGrid6_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid6);
        }

        private void buttonGrid9_Click(object sender, EventArgs e)
        {
            makeAPlay(buttonGrid9);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            newGame();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            newGame();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
