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
        List<Button> buttonList = new List<Button>();

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
            buttonList.Add(buttonGrid1);
            buttonList.Add(buttonGrid2);
            buttonList.Add(buttonGrid3);
            buttonList.Add(buttonGrid4);
            buttonList.Add(buttonGrid5);
            buttonList.Add(buttonGrid6);
            buttonList.Add(buttonGrid7);
            buttonList.Add(buttonGrid8);
            buttonList.Add(buttonGrid9);
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
        //AI logic tree to try and win or to stop the user from winning
        private void makePlayAI()
        {
            //to keep track of if the AI has made a play yet
            bool didAIMakePlay = false;

            //lets see if the AI can win first
            didAIMakePlay = canAIWin();
            //if not, the AI needs to make sure it won't lose so it 
            // will look for a block to make
            if (didAIMakePlay == false)
            {
                //looking for the block
                didAIMakePlay = canAIBlock();
            }
            //if the AI can not win and does not need to block, it 
            //should make the best play available
            if (didAIMakePlay == false)
            {
                makeAIBestPlay();
            }

        }
        //actual methods to check for the AI being able to win,
        //block, or make the best play possible
        private bool canAIWin()
        {
            //checking for horizontal wins
            if (buttonGrid1.Text == buttonGrid2.Text && buttonGrid2.Text != "" &&
                buttonGrid2.Text != "O" && buttonGrid3.Text != "O")
            {
                makeAPlay(buttonGrid3);
                return true;
            }
            else if (buttonGrid1.Text == buttonGrid3.Text && buttonGrid3.Text != "" &&
                buttonGrid3.Text != "O" && buttonGrid2.Text != "O")
            {
                makeAPlay(buttonGrid2);
                return true;
            }
            else if (buttonGrid2.Text == buttonGrid3.Text && buttonGrid3.Text != "" &&
                buttonGrid3.Text != "O" && buttonGrid1.Text != "O")
            {
                makeAPlay(buttonGrid1);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid6.Text && buttonGrid6.Text != "" &&
                buttonGrid6.Text != "O" && buttonGrid4.Text != "O")
            {
                makeAPlay(buttonGrid4);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid4.Text && buttonGrid4.Text != "" &&
                buttonGrid4.Text != "O" && buttonGrid6.Text != "O")
            {
                makeAPlay(buttonGrid6);
                return true;
            }
            else if (buttonGrid6.Text == buttonGrid4.Text && buttonGrid4.Text != "" &&
                buttonGrid4.Text != "O" && buttonGrid5.Text != "O")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            else if (buttonGrid7.Text == buttonGrid8.Text && buttonGrid8.Text != "" &&
                buttonGrid8.Text != "O" && buttonGrid9.Text != "O")
            {
                makeAPlay(buttonGrid9);
                return true;
            }
            else if (buttonGrid7.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "O" && buttonGrid8.Text != "O")
            {
                makeAPlay(buttonGrid8);
                return true;
            }
            else if (buttonGrid8.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "O" && buttonGrid7.Text != "O")
            {
                makeAPlay(buttonGrid7);
                return true;
            }
            //checking for diagonal wins
            else if (buttonGrid1.Text == buttonGrid5.Text && buttonGrid5.Text != "" &&
                buttonGrid5.Text != "O" && buttonGrid9.Text != "O")
            {
                makeAPlay(buttonGrid9);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid5.Text && buttonGrid5.Text != "" &&
                buttonGrid5.Text != "O" && buttonGrid7.Text != "O")
            {
                makeAPlay(buttonGrid7);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                buttonGrid7.Text != "O" && buttonGrid5.Text != "O")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                buttonGrid7.Text != "O" && buttonGrid3.Text != "O")
            {
                makeAPlay(buttonGrid3);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "O" && buttonGrid1.Text != "O")
            {
                makeAPlay(buttonGrid1);
                return true;
            }
            else if (buttonGrid1.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "O" && buttonGrid5.Text != "O")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            //checking for vertical wins
            else if (buttonGrid1.Text == buttonGrid4.Text && buttonGrid4.Text != "" &&
                buttonGrid4.Text != "O" && buttonGrid7.Text != "O")
            {
                makeAPlay(buttonGrid7);
                return true;
            }
            else if (buttonGrid1.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                            buttonGrid7.Text != "O" && buttonGrid4.Text != "O")
            {
                makeAPlay(buttonGrid4);
                return true;
            }
            else if (buttonGrid4.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                            buttonGrid7.Text != "O" && buttonGrid1.Text != "O")
            {
                makeAPlay(buttonGrid1);
                return true;
            }
            else if (buttonGrid2.Text == buttonGrid5.Text && buttonGrid5.Text != "" &&
                buttonGrid5.Text != "O" && buttonGrid8.Text != "O")
            {
                makeAPlay(buttonGrid8);
                return true;
            }
            else if (buttonGrid2.Text == buttonGrid8.Text && buttonGrid8.Text != "" &&
                            buttonGrid8.Text != "O" && buttonGrid5.Text != "O")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid8.Text && buttonGrid8.Text != "" &&
                            buttonGrid8.Text != "O" && buttonGrid2.Text != "O")
            {
                makeAPlay(buttonGrid2);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid6.Text && buttonGrid6.Text != "" &&
                buttonGrid6.Text != "O" && buttonGrid9.Text != "O")
            {
                makeAPlay(buttonGrid9);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                            buttonGrid9.Text != "O" && buttonGrid6.Text != "O")
            {
                makeAPlay(buttonGrid6);
                return true;
            }
            else if (buttonGrid6.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                            buttonGrid9.Text != "O" && buttonGrid3.Text != "O")
            {
                makeAPlay(buttonGrid3);
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool canAIBlock()
        {
            //should be the same code as winning just checking to see if the 
            //opponent is going to win
            if (buttonGrid1.Text == buttonGrid2.Text && buttonGrid2.Text != "" &&
                buttonGrid2.Text != "X" && buttonGrid3.Text != "X")
            {
                makeAPlay(buttonGrid3);
                return true;
            }
            else if (buttonGrid1.Text == buttonGrid3.Text && buttonGrid3.Text != "" &&
                buttonGrid3.Text != "X" && buttonGrid2.Text != "X")
            {
                makeAPlay(buttonGrid2);
                return true;
            }
            else if (buttonGrid2.Text == buttonGrid3.Text && buttonGrid3.Text != "" &&
                buttonGrid3.Text != "X" && buttonGrid1.Text != "X")
            {
                makeAPlay(buttonGrid1);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid6.Text && buttonGrid6.Text != "" &&
                buttonGrid6.Text != "X" && buttonGrid4.Text != "X")
            {
                makeAPlay(buttonGrid4);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid4.Text && buttonGrid4.Text != "" &&
                buttonGrid4.Text != "X" && buttonGrid6.Text != "X")
            {
                makeAPlay(buttonGrid6);
                return true;
            }
            else if (buttonGrid6.Text == buttonGrid4.Text && buttonGrid4.Text != "" &&
                buttonGrid4.Text != "X" && buttonGrid5.Text != "X")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            else if (buttonGrid7.Text == buttonGrid8.Text && buttonGrid8.Text != "" &&
                buttonGrid8.Text != "X" && buttonGrid9.Text != "X")
            {
                makeAPlay(buttonGrid9);
                return true;
            }
            else if (buttonGrid7.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "X" && buttonGrid8.Text != "X")
            {
                makeAPlay(buttonGrid8);
                return true;
            }
            else if (buttonGrid8.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "X" && buttonGrid7.Text != "X")
            {
                makeAPlay(buttonGrid7);
                return true;
            }
            //checking for diagonal wins
            else if (buttonGrid1.Text == buttonGrid5.Text && buttonGrid5.Text != "" &&
                buttonGrid5.Text != "X" && buttonGrid9.Text != "X")
            {
                makeAPlay(buttonGrid9);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid5.Text && buttonGrid5.Text != "" &&
                buttonGrid5.Text != "X" && buttonGrid7.Text != "X")
            {
                makeAPlay(buttonGrid7);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                buttonGrid7.Text != "X" && buttonGrid5.Text != "X")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                buttonGrid7.Text != "X" && buttonGrid3.Text != "X")
            {
                makeAPlay(buttonGrid3);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "X" && buttonGrid1.Text != "X")
            {
                makeAPlay(buttonGrid1);
                return true;
            }
            else if (buttonGrid1.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                buttonGrid9.Text != "X" && buttonGrid5.Text != "X")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            //checking for vertical wins
            else if (buttonGrid1.Text == buttonGrid4.Text && buttonGrid4.Text != "" &&
                buttonGrid4.Text != "X" && buttonGrid7.Text != "X")
            {
                makeAPlay(buttonGrid7);
                return true;
            }
            else if (buttonGrid1.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                            buttonGrid7.Text != "X" && buttonGrid4.Text != "X")
            {
                makeAPlay(buttonGrid4);
                return true;
            }
            else if (buttonGrid4.Text == buttonGrid7.Text && buttonGrid7.Text != "" &&
                            buttonGrid7.Text != "X" && buttonGrid1.Text != "X")
            {
                makeAPlay(buttonGrid1);
                return true;
            }
            else if (buttonGrid2.Text == buttonGrid5.Text && buttonGrid5.Text != "" &&
                buttonGrid5.Text != "X" && buttonGrid8.Text != "X")
            {
                makeAPlay(buttonGrid8);
                return true;
            }
            else if (buttonGrid2.Text == buttonGrid8.Text && buttonGrid8.Text != "" &&
                            buttonGrid8.Text != "X" && buttonGrid5.Text != "X")
            {
                makeAPlay(buttonGrid5);
                return true;
            }
            else if (buttonGrid5.Text == buttonGrid8.Text && buttonGrid8.Text != "" &&
                            buttonGrid8.Text != "X" && buttonGrid2.Text != "X")
            {
                makeAPlay(buttonGrid2);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid6.Text && buttonGrid6.Text != "" &&
                buttonGrid6.Text != "X" && buttonGrid9.Text != "X")
            {
                makeAPlay(buttonGrid9);
                return true;
            }
            else if (buttonGrid3.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                            buttonGrid9.Text != "X" && buttonGrid6.Text != "X")
            {
                makeAPlay(buttonGrid6);
                return true;
            }
            else if (buttonGrid6.Text == buttonGrid9.Text && buttonGrid9.Text != "" &&
                            buttonGrid9.Text != "X" && buttonGrid3.Text != "X")
            {
                makeAPlay(buttonGrid3);
                return true;
            }
            else
            {
                return false;
            }

        }
        private void makeAIBestPlay()
        {
            //I want the computer to be able to play both X and O
            if (ttt.currentPlayer != "O")
            {
                //the first move is always going to be the top left hand corner
                //for X
                if (buttonGrid1.Enabled == true)
                    makeAPlay(buttonGrid1);
                //after that, the next best moves are in the corners if the 
                //center has not been taken 
                else if (buttonGrid5.Enabled == true)
                    makeAPlay(buttonGrid5);
                //the corners are the next best, but only if they are "alone"
                //in the corners without any opposing mark beside them
                else if (buttonGrid2.Enabled == false && buttonGrid7.Enabled == true)
                    makeAPlay(buttonGrid7);
                else if (buttonGrid4.Enabled == false && buttonGrid3.Enabled == true)
                    makeAPlay(buttonGrid3);
                else if (buttonGrid9.Enabled == true)
                    makeAPlay(buttonGrid9);
                //if there are no more winning plays, this function will happen
                else
                {
                    runOutTheClock();
                }

            }
            else//essentially logic for the ai being the second player
            {
                //the next best play is always in the center for the second person
                if (buttonGrid5.Enabled == true)
                    makeAPlay(buttonGrid5);
                //the next best play is any square that is not a corner for O
                else if (buttonGrid2.Enabled == true)
                    makeAPlay(buttonGrid2);
                else if (buttonGrid6.Enabled == true)
                    makeAPlay(buttonGrid6);
                else if (buttonGrid8.Enabled == true)
                    makeAPlay(buttonGrid8);
                else if (buttonGrid4.Enabled == true)
                    makeAPlay(buttonGrid4);
                else
                {
                    runOutTheClock();
                }
            }

            


        }
        //when neither side can win but moves still need to be made to finish the game

        private void runOutTheClock()
        {
            //random fucntion and a new list to select a random item from
            //the list to select ensuring there are no hiccups
            Random random = new Random();
            List<Button> emptyGridSpaces = new List<Button>();
            foreach (Button button in buttonList)
            {
                if (button.Enabled == true)
                    emptyGridSpaces.Add(button);
            }
            int randomGrid = random.Next(emptyGridSpaces.Count);
            Button randButton = emptyGridSpaces[randomGrid];
            makeAPlay(randButton);
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
                if (ttt.currentPlayer != "O")
                    makePlayAI();
                
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
            makePlayAI();
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            newGame();
            makePlayAI();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAIPlay_Click(object sender, EventArgs e)
        {
            makePlayAI();
        }
    }
}
