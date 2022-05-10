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
            

            // while play == true, play game
            
            string player = "x";
            // player = player == 'x' ？ 'o' : 'x';
            // toggle between x and o like brother thayne demonstrated in class            
    
            MakeBoard("1", "1");
            CheckWinner(MakeBoard(GetUserInput(), player));

            // Boolean winner = CheckWinner(MakeBoard(GetUserInput(), player));

            // while (winner == false)
            // {
            //     winner = CheckWinner(MakeBoard(GetUserInput(), player));

            // }


            // Boolean playing = true;

            // if (CheckWinner(MakeBoard(GetUserInput(), player)) == false)
            // {
            //     CheckWinner(MakeBoard(GetUserInput(), player));
            //     player = player == "x" ? "o" : "x";
            // }
            // else 
            // {
            //     Console.WriteLine("The End.");
            // }


            string GetUserInput()
            {
                Console.Write($"{player}'s turn to choose a square (1-9): ");
                string move = Console.ReadLine();
                return move;
            }

            // give it a type that it'll return. If it doesnt return anything, then void is the type

            System.Collections.Generic.List<string> MakeBoard(string move, string player)
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
                // because I'm adding these every time, the grid doesn't update correctly...

                for (int i = 0; i < board.Count; i++)
                {
                    if (board[i].Contains(move))
                        board[i] = player;
                }

                Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
                Console.WriteLine("-+-+-");
                Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");

                return board;

            }



            // public string MakeGrid(userMove, letter);
            // {


            // }

            // logic to check for winner based on list index
            // horizontal 012, 345, 678
            // vertical 036, 147, 258
            // diagonal 048, 246

            Boolean CheckWinner(System.Collections.Generic.List<string> board)
            {
                if (
                (board[0] == player && board[1] == player && board[2] == player) ||
                (board[3] == player && board[4] == player && board[5] == player) ||
                (board[6] == player && board[7] == player && board[8] == player) ||

                (board[0] == player && board[3] == player && board[6] == player) ||
                (board[1] == player && board[4] == player && board[7] == player) ||
                (board[2] == player && board[5] == player && board[8] == player) ||

                (board[0] == player && board[4] == player && board[8] == player) ||
                (board[2] == player && board[4] == player && board[6] == player)
            )
                {

                    Console.WriteLine($"Congrats! Player {player} won!");
                    return true;
                }
                else
                    return false;

            };





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
