/*
    Project Name: cse210-01 Tic-Tac-Toe Assignment
    Author: Kirsten Jackson
*/

using System;
using System.Collections.Generic;

namespace prove1
{
    class Program
    {
        static void Main(string[] args)
        {

            // while winner= false, play game


            string player = "x";
            // player = player == 'x' ？ 'o' : 'x';
            // toggle between x and o like brother thayne demonstrated in class            

            
            MakeBoard(GetUserInput(), player);

            // string userInput = GetUserInput();
            // string grid = MakeGrid();
            // Console.WriteLine(grid);

            string GetUserInput()
            {
                Console.Write($"{player}'s turn to choose a square (1-9): ");
                string move = Console.ReadLine();
                return move;
            }

            // give it a type that it'll return. If it doesnt return anything, then void is the type

            void MakeBoard(string move, string player)
            {
                List<string> board = new List<string>();

                board.Add("1");
                board.Add("2");
                board.Add("3");
                board.Add("4");
                board.Add("5");
                board.Add("6");
                board.Add("7");
                board.Add("8");
                board.Add("9");

                for(int i=0; i<board.Count; i++ )
                {
                    if(board[i].Contains(move))
                        board[i] = player;
                }

                // don't forget to do the inital print 
                // add replace thingy here to change the output

                // for (int i = 0; i < board.Count; i++)
                // {
                //     Console.WriteLine(board[i]);
                // }

                Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");

            }



            // public string MakeGrid(userMove, letter);
            // {


            // }

            // logic to check for winner based on list index
            // horizontal 012, 345, 678
            // vertical 036, 147, 258
            // diagonal 048, 246

            // string CheckWinner(string board)
            // {
            //     if (
            //     (board[0] == player && board[1] == player && board[2] == player) ||
            //     (board[3] == player && board[4] == player && board[5] == player) ||
            //     (board[6] == player && board[7] == player && board[8] == player) ||

            //     (board[0] == player && board[3] == player && board[6] == player) ||
            //     (board[1] == player && board[4] == player && board[7] == player) ||
            //     (board[2] == player && board[5] == player && board[8] == player) ||

            //     (board[0] == player && board[4] == player && board[8] == player) ||
            //     (board[2] == player && board[4] == player && board[6] == player)
            // )
            // {
            //     Console.WriteLine($"Congrats! Player {player} won!");
            // }

            // };

            



        }


    }
}
// functions
// createGrid
// playerTurn
// it's useful to have a class for each entity
// player, director, etc

// what is the best way to store the numbers and the x and o?
// last time I stored them in a list
// maybe I'll store them all as separate variables
// string one = "1";
// then I can use if statement to say when there's three in a row
// maybe use a while loop for players turn
// while (playing == True);
// {
//     Console.Write($"x's turn to choose a square (1-9): ")
//     Console.ReadLine...
// }
