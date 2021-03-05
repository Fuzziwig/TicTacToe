using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Board board = new Board();
        private WinChecker winChecker = new WinChecker();
        private Player player1 = new Player();
        private Player player2 = new Player();
        private String RichTextHeader = "Turn information:" + Environment.NewLine+" ";
        public Form1()
        {
            InitializeComponent();
            init_Game();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            init_Game();
        }
        private void init_Game()
        {
            board = new Board();
            board.NextTurn = State.X;
            richTextBox1.Text = RichTextHeader + "Player 1 Starts";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            button10.Text = "";
            button11.Text = "";
            button12.Text = "";
            button13.Text = "";
            enableButtons(true);
        }

        private void enableButtons(Boolean toggle)
        {
            button5.Enabled = toggle;
            button6.Enabled = toggle;
            button7.Enabled = toggle;
            button8.Enabled = toggle;
            button9.Enabled = toggle;
            button10.Enabled = toggle;
            button11.Enabled = toggle;
            button12.Enabled = toggle;
            button13.Enabled = toggle;
        }

        private void genericButton_Click(object sender)
        {
            String buttonsender = ((Button)sender).Text;
            if (buttonsender == "")
            {
                if (board.NextTurn == State.X || richTextBox1.Text.Equals(RichTextHeader + "Player 1 Starts"))
                {
                    ((Button)sender).Text = "X";
                    richTextBox1.Text = RichTextHeader + "Player 2, its your turn !";
                    board.SwitchNextTurn();
                }
                else
                {
                    ((Button)sender).Text = "O";
                    richTextBox1.Text = RichTextHeader + "Player 1, its your turn !";
                    board.SwitchNextTurn();
                }
            }
            State currentState = winChecker.Check(board);
           if (currentState == State.X)
            {
                richTextBox1.Text = RichTextHeader + "Player 1 Won ! Congratulations";
                enableButtons(false);
            }
            else if (currentState == State.O)
            {
                richTextBox1.Text = RichTextHeader + "Player 2 Won ! Congratulations";
                enableButtons(false);
            }
            else if (winChecker.IsDraw(board))
            {
                richTextBox1.Text = RichTextHeader + "Its a draw, press Restart for another game !";
                enableButtons(false);
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(0, 0), board.NextTurn);
            genericButton_Click(sender);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(0, 1), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(0, 2), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(1, 0), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(1, 1), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(1, 2), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(2, 0), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(2, 1), board.NextTurn);
            genericButton_Click(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            board.SetState(new Position(2, 2), board.NextTurn);
            genericButton_Click(sender);
        }
    }
}
