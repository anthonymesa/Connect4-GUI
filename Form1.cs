// Name: (Your Name)
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        private Board board;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            board = new Board();
        }

        private void pic_board_Paint(object sender, PaintEventArgs e)
        {
            //gets called whenever the screen is painted
            board.DrawBoard(e.ClipRectangle.Height, e.ClipRectangle.Width, e.Graphics);
        }

        private void clearGameboard(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Form.DefaultBackColor);
        }

        private void mov_col_1_Click(object sender, EventArgs e)
        {
             board.HandleMove(0, status_label, game_view);
        }

        private void mov_col_2_Click(object sender, EventArgs e)
        {
            board.HandleMove(1, status_label, game_view);
        }

        private void mov_col_3_Click(object sender, EventArgs e)
        {
            board.HandleMove(2, status_label, game_view);
        }

        private void mov_col_4_Click(object sender, EventArgs e)
        {
            board.HandleMove(3, status_label, game_view);
        }

        private void mov_col_5_Click(object sender, EventArgs e)
        {
            board.HandleMove(4, status_label, game_view);
        }

        private void mov_col_6_Click(object sender, EventArgs e)
        {
            board.HandleMove(5, status_label, game_view);
        }

        private void mov_col_7_Click(object sender, EventArgs e)
        {
            board.HandleMove(6, status_label, game_view);
        }

        public void new_game_Click(object sender, EventArgs e)
        {
            String red_player = this.player_1_name.Text;
            String yellow_player = this.player_2_name.Text;

            if((red_player.Length == 0) || (yellow_player.Length == 0))
            {
                this.status_label.Text = " ~ Names are required to play.";
                return;
            }

            board.SetActive(true);
            board.SetPlayers(red_player, yellow_player);
            board.ResetBoard();

            //adds the event handler for when the screen is painted
            game_view.Paint += new PaintEventHandler(pic_board_Paint);

            this.status_label.Text = " ~ Starting new game! Your turn " + board.GetCurrentPlayer() + ".";
            game_view.Refresh();
        }

        private void quit_game_Click(object sender, EventArgs e)
        {

            if (board.GetActive())
            {
                board.SetActive(false);
                game_view.Paint += new PaintEventHandler(clearGameboard);
                game_view.Refresh();
                board.ResetBoard();
                status_label.Text = " ~ Click 'New Game' to begin.";
            }
            else
            {
                this.status_label.Text = " ~ Gotta start a game before you can finish it!";
            }
        }
    }
}
