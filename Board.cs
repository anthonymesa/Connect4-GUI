using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    enum Player
    {
        EMPTY, RED, YELLOW
    }
    class Board
    {
        private const int rows = 6;
        private const int cols = 7;
        private Player[,] board = new Player[rows,cols];

        private String red_player_name;
        private String yellow_player_name;
        private Boolean game_active = false;

        private bool win = false;
        private Player current_turn = Player.RED;

        private String error_msg;

        public Board()
        {
            //constructor
            ResetBoard();
        }

        public void ResetBoard()
        {
            current_turn = Player.RED;
            win = false;

            //reset the game board to empty
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = Player.EMPTY;
                }
            }
            
        }

        public void DrawBoard(int height, int width, Graphics g)
        {
            int start_x = 0; //board top left corner offset
            int start_y = 0;

            g.FillRectangle(Brushes.Navy, start_x, start_y, width, height);

            int col_width = width / cols;
            int row_height = height / rows;

            //draw the board columns
            for(int i = col_width; i <= width; i = i + col_width)
                g.DrawLine(Pens.White, start_x + i, start_y, start_x + i, start_y + height);

            //draw the board rows
            for (int i = row_height; i <= height; i = i + row_height)
                g.DrawLine(Pens.White, start_x, start_y + i, start_x + width, start_y + i);


            int margin = 10;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i , j] == Player.RED)
                    {
                        g.FillEllipse(Brushes.Red, (start_x + (margin / 2)) + (j * col_width), (start_y + (margin / 2)) + (i * row_height), col_width - margin, row_height - margin);
                    }
                    else if (board[i, j] == Player.YELLOW)
                    {
                        g.FillEllipse(Brushes.Yellow, (start_x + (margin / 2)) + (j * col_width), (start_y + (margin / 2)) + (i * row_height), col_width - margin, row_height - margin);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.White, (start_x + (margin / 2)) + (j * col_width), (start_y + (margin / 2)) + (i * row_height), col_width - margin, row_height - margin);
                    }
                }
            }
        }

        /**
 * Dynamically prints the gameboard to screen.
 */
        public void PrintBoard()
        {
            // Topmost border

            Console.WriteLine("\n=======================\n");

            // Dynamically create the horizonatal border.

            String line_border = "";
            for (int i = 0; i < cols; i++)
            {
                if (i == (cols - 1))
                {
                    line_border += "+-+";
                }
                else
                {
                    line_border += "+-";
                }
            }

            // Print horizontal border as first line.

            Console.WriteLine(line_border);

            // For each row of elements in the gameboard
            // print those elements and then print the 
            // horizontal border.

            for (int i = 0; i < rows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(PlayerToChar(board[i , j]) + "|");
                }

                Console.WriteLine( "\n" + line_border);
            }

            // Bottommost border

            Console.WriteLine("\n=======================\n");
        }

        public void SetWin(bool x)
        {
            win = x;
        }

        public bool GetWin()
        {
            return win;
        }

        public bool CheckTie()
        {
            for(int i = 0; i < cols; i++)
            {
                if(board[0 , i] == Player.EMPTY)
                {
                    return false;
                }
            }

            return true;
        }

        public bool CheckWin()
        {
            // Check for a horizontal win

            for (int i = 0; i < rows; i++)
            {
                // Count will be used to keep track of how many of the
                // same type of player that we find in succession.

                int count = 1;
                Player last_check = Player.EMPTY;
                for (int j = 0; j < cols; j++)
                {
                    if ((last_check != Player.EMPTY) && (board[i , j] == last_check))
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                        last_check = board[i , j];
                    }

                    if (count > 3)
                    {
                        return true;
                    }
                }
            }

            // Check for a vertical win

            for (int i = 0; i < cols; i++)
            {
                int count = 1;
                Player last_check = Player.EMPTY;
                for (int j = 0; j < rows; j++)
                {
                    if ((last_check != Player.EMPTY) && (board[j , i] == last_check))
                    {
                        count++;
                    }
                    else
                    {
                        count = 1;
                        last_check = board[j , i];
                    }

                    if (count > 3)
                    {
                        return true;
                    }
                }
            }

            // Check for descending diagonal win

            for (int i = 0; i < (rows * 2); i++)
            {
                int count = 1;
                Player last_check = Player.EMPTY;
                for (int j = 0; j < cols; j++)
                {
                    if ((0 < ((i - 5) + j)) && (((i - 5) + j) < rows)) {
                        // here we are using the vector's .at() function to catch out of bounds exceptions
                        // so we can iterate over all of the diagonals in the board.

                        if ((last_check != Player.EMPTY) && (board[(i - 5) + j , j] == last_check))
                        {
                            count++;
                        }
                        else
                        {
                            count = 1;
                            last_check = board[(i - 5) + j , j];
                        }

                        if (count > 3)
                        {
                            return true;
                        }
                    }
                }
            }

            // Check for ascending diagonal win

            for(int i = 0; i < (rows* 2); i++)
            {
                int count = 1;
                Player last_check = Player.EMPTY;
                
                for(int j = 0; j < cols; j++) {
                    if((0 < (i - j)) && ((i - j) < rows)) { 
                        // here we are using the vector's .at() function to catch out of bounds exceptions
                        if((last_check != Player.EMPTY) && (board[i - j , j] == last_check))
                        {
                            count++;
                        } else {
                            count = 1;
                            last_check = board[i - j , j];
                        }

                        if (count > 3) {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        public String PlayerToString(Player player)
        {
            if(player == Player.RED)
                return red_player_name;
            if (player == Player.YELLOW)
                return yellow_player_name;
            return "";
        }

        public String PlayerToChar(Player player)
        {
            if (player == Player.RED)
                return "R";
            if (player == Player.YELLOW)
                return "Y";
            return " ";
        }
        public String GetCurrentPlayer()
        {
            return PlayerToString(current_turn);
        }

        public Player NextTurn()
        {
            if (current_turn == Player.RED)
            {
                current_turn = Player.YELLOW;
                return Player.YELLOW;
            }
            else
            {
                current_turn = Player.RED;
                return Player.RED;
            }
        }

        public String GetGameStatus()
        {
            SetWin(CheckWin());

            if (win)
            {
                return " ~ " + PlayerToString(current_turn) + " won!";
            }
            else if (CheckTie())
            {
                return " ~ It's a tie, you both loose!";
            }
            else
            {
                NextTurn();
                return " ~ " + PlayerToString(current_turn) + ", it is your turn!";
            }
        }

        public String MakeMove(int column)
        {
            // Validate that column value is useable.

            if (ValidMove(column))
            {

                // Iterate over the rows of the gameboard.

                for (int i = 0; i < board.GetLength(0); i++)
                {
                    if(board != null)
                    {
                        // If i + 1 equals the size of the gameboard rows
                        // vector (the first dimension) then we are at the
                        // bottom of the column.

                        if ((i + 1) == board.GetLength(0))
                        {
                            // Set the bottom-most column element to current_turn.
                            board[i , column] = current_turn;
                            return GetGameStatus();
                        }

                        // If we are not at the bottom of the gameboard,
                        // check if the next element in the column below
                        // the current element is a free space. If not,
                        // we have gone as far down the column as we can go.
                        else if (board[i + 1, column] != Player.EMPTY)
                        {
                            board[i, column] = current_turn;
                            return GetGameStatus();
                        }
                    } 
                }
                return GetGameStatus();
            }
            else
            {
                return " ~ Column is full, choose another.";
            }
        }

        public bool ValidMove(int column)
        {
            // Check if move is out of bounds.

            if (column >= cols)
            {
                error_msg = "\nERROR: Move out of bounds. Try again\n";
                return false;
            }

            // Check if the row is full by checking the first
            // element in the column for NONE enum.

            if (board[0 , column] != Player.EMPTY)
            {
                error_msg = "\nERROR: Column full, move could not be made. Try again\n";
                return false;
            }

            // Given validity, clear the error message

            error_msg = "";
            return true;
        }

        public String GetError()
        {
            return error_msg;
        }

        public void SetPlayers(String red_player, String yellow_player)
        {
            red_player_name = red_player;
            yellow_player_name = yellow_player;
        }

        public void SetActive(bool active)
        {
            game_active = active;
        }

        public bool GetActive()
        {
            return game_active;
        }

        public void HandleMove(int col, Label status_label, PictureBox game_view)
        {
            if (!GetActive())
            {
                status_label.Text = " ~ Click 'New Game' to begin.";
                return;
            }

            if (GetWin())
            {
                status_label.Text = " ~ " + GetCurrentPlayer() + " won! Click 'New Game' to begin again.";
            }
            else if (CheckTie())
            {
                status_label.Text = " ~ It's a tie, you both loose!";
            }
            else
            {
                status_label.Text = MakeMove(col);
                game_view.Refresh();
            }
            
        }
    }
}
