using System;
using System.Collections.Generic;
using cse210_01;

namespace cse210_01
{
    public class Director
    {
        public bool playing = true;
        public Board board = new Board();
        public Player user = new Player();


        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        public void StartGame()
        {
            // print out board before users play
            board.MakeBoard(false, "", "");
            string player = "";
            // game loop
            while (playing)
            {
                player = (player == "x" ? "o" : "x");
                string move = user.GetUserInput(player);
                CheckWinner(board.MakeBoard(true, move, player), player);
            }
        }

        /// <summary>
        /// Check if a player has three in a row or if there's a draw.
        /// </summary>
        /// <param name="board"></param>
        /// <param name="player"></param>
        public void CheckWinner(List<string> board, string player)
        {
            // check for three in a row based on list index
            if (
            // horizontal three in a row
            (board[0] == player && board[1] == player && board[2] == player) ||
            (board[3] == player && board[4] == player && board[5] == player) ||
            (board[6] == player && board[7] == player && board[8] == player) ||

            // vertical three in a row
            (board[0] == player && board[3] == player && board[6] == player) ||
            (board[1] == player && board[4] == player && board[7] == player) ||
            (board[2] == player && board[5] == player && board[8] == player) ||

            // diagonal three in a row
            (board[0] == player && board[4] == player && board[8] == player) ||
            (board[2] == player && board[4] == player && board[6] == player) 

            )
            {
                Console.WriteLine($"Congrats! Player {player} won! ");
                playing = false;
            }

            // check for a draw
            else if (
                !board.Contains("1") && !board.Contains("2") && !board.Contains("3")
                && !board.Contains("4") && !board.Contains("5") && !board.Contains("6")
                && !board.Contains("7") && !board.Contains("8") && !board.Contains("9")
                )
            {
                Console.WriteLine("It's a draw!");
                playing = false;
            }
        }


    }

}
