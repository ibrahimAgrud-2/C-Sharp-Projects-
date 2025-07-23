using System;
using System.Drawing;
using System.Collections;
using System.Windows.Forms;
using Tic_Tac_ToeGame.Properties;
using System.Collections.Generic;
using System.Threading;


namespace Tic_Tac_ToeGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Button> ButtonList=new List<Button>();

        byte counter = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            currentPlayer = players.player1;
            foreach (Button item in groupBox1.Controls)
            {
                ButtonList.Add(item);
            }
           
        }
        enum players { player1 = 1, player2 = 2 };
        enum ePlayingOption { playWithFriend = 1, playWithRobot = 2 };

        ePlayingOption playingOption;

        bool isPlayerWon(Button button1, Button button2, Button button3)
        {
            if ((button1.Tag.ToString()!="?")&&button1.Tag == button2.Tag && button2.Tag == button3.Tag)
            {
                button1.BackColor = Color.Yellow;
                button2.BackColor = Color.Yellow;
                button3.BackColor = Color.Yellow;
                
                return true;
            }
          
            return false;
        }
        bool checkWinner()
        {
            if (counter<=4)
            {
                return false;
            }
            
            
            if (isPlayerWon(btn1,btn2,btn3))
            {
             return true;
            }
            if (isPlayerWon(btn1, btn4, btn7))
            {
                return true;
            }
            if (isPlayerWon(btn7, btn8, btn9))
            {
                return true;
            }
            if (isPlayerWon(btn4, btn5, btn6))
            {
                return true;
            }
            if (isPlayerWon(btn3, btn6, btn9))
            {
                return true;
            }
            if (isPlayerWon(btn1, btn5, btn9)) 
            {
                return true;
            }
            if (isPlayerWon(btn3, btn5, btn7))
            {
                return true;
            }
            if (isPlayerWon(btn2, btn5, btn8))
            {
                return true;
            }
            return false;

        }

        players currentPlayer;
        void gameStatus()
        {
            if (checkWinner())
            {


                lblPlayer.Text = "Game over";
                lblWinner.Text = "Player " + Convert.ToByte(currentPlayer);

                disableButtons();
               

            }
            else
            {
                if (counter == 9)
                {
                    lblWinner.Text = "Draw";
                    disableButtons();
                }
            }
        }
        void buttonClicked(Button btn)
        {
            
            
            if (btn.Tag.ToString() == "?")
            {

                if (currentPlayer == players.player1)
                {
                    btn.Image = Resources.X;
                    btn.Tag = "X";
                    lblPlayer.Text = "Player 2";
     
                   

                }
                else
                {
                    btn.Image = Resources.O;
                    btn.Tag = "O";
                    lblPlayer.Text = "Player 1";
                  


                }
                counter++;
                gameStatus();
                changeCurrentPlayer();



            }
            else
            {
                MessageBox.Show("Wrong choice");
            }
        }
     

        void changeCurrentPlayer()
        {
            currentPlayer = (currentPlayer == players.player1) ? players.player2 : players.player1;
        }
     
        void resetButton(Button btn)
        {
            btn.Tag = "?";
            btn.Image= Resources.question_mark_96;
            btn.BackColor = Color.FromArgb(128, 255, 255);
        }

        void resetGame()
        {
            lblPlayer.Text = "Player 1";
            lblWinner.Text = "In progress";
            counter = 0;


            foreach (Button item in groupBox1.Controls)
            {
                resetButton(item);
            }
            enableButtons();

            currentPlayer = players.player1;
            if (ButtonList.Count!=9)
            {

                ButtonList.Clear();
                foreach (Button item in groupBox1.Controls)
                {
                    ButtonList.Add(item);
                }
            }

        }
        private void btnClick(object sender, EventArgs e)
        {
        
            buttonClicked((Button)sender);



            //===========play with robot section================

            ButtonList.Remove((Button)sender);
          
            if (currentPlayer == players.player2 && playingOption == ePlayingOption.playWithRobot)
            {
              
                Button btn = getRandomButton();
                if (btn!=null)
                {
                    btn.PerformClick();

                }
              
            }

        }

        void disableButtons()
        {
            foreach (Button item in groupBox1.Controls)
            {
                item.Enabled = false;
            }
        }
        void enableButtons()
        {
            foreach (Button item in groupBox1.Controls)
            {
                item.Enabled = true;
            }
        }

        private void btnResetGame_Click_1(object sender, EventArgs e)
        {

            resetGame();
        }


        Button getRandomButton()
        {
           
            Random rnd= new Random();
            if (ButtonList.Count==0)
            {
                return null;
            }
            int itemIndex = rnd.Next(1, ButtonList.Count);

            return ButtonList[itemIndex];
        }
   
 
        private void playWithFriendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playingOption = ePlayingOption.playWithFriend;
            resetGame();

        }

        private void playWithRobotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playingOption = ePlayingOption.playWithRobot;
            resetGame();
        }

        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {

            Color clr = Color.White;

            Pen pen = new Pen(clr);
            pen.Width = 6;

            pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(pen, 75, 175, 475, 175);
            e.Graphics.DrawLine(pen, 75, 300, 475, 300);

            e.Graphics.DrawLine(pen, 203, 60, 203, 425);
            e.Graphics.DrawLine(pen, 350, 60, 350, 425);
        }
    }

}
