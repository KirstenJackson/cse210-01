using System;
using System.Collections.Generic;

namespace cse210_01
{
    public class Board
    {
        public List<string> board = new List<string>();

        /// <summary>
        /// Constructs a new instance of Board.
        /// </summary>
        public Board()
        {
        }


        /// <summary>
        /// Prints the board for the user to view. and/or change. 
        /// </summary>
        /// <param name="update">Is the board being updated or not</param>
        /// <param name="move">players move</param>
        /// <param name="player">player "x" or "o"</param>
        /// <returns></returns>
        public List<string> MakeBoard(bool update, string move, string player)
        {
            if (update == false)
            {
                board.Add("1");
                board.Add("2");
                board.Add("3");
                board.Add("4");
                board.Add("5");
                board.Add("6");
                board.Add("7");
                board.Add("8");
                board.Add("9");
            }

            if (update)
            {
                // replace the selected number with an "x" or "o" 
                for (int i = 0; i < board.Count; i++)
                {
                    if (board[i].Contains(move))
                        board[i] = player;
                }
            }


            // print board
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");

            return board;

        }




    }
}
