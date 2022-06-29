using System;

namespace cse210_01
{
    public class Player
    {
        
        /// <summary>
        /// Constructs a new instance of Player.
        /// </summary>
        public Player()
        {
        }

        /// <summary>
        /// Takes the user input and returns the move as a string
        /// </summary>
        /// <param name="player">The player, either "x" or "o"</param>
        /// <returns>move</returns>
        public string GetUserInput(string player)
        {
            Console.WriteLine();
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            string move = Console.ReadLine();
            Console.WriteLine();
            return move;
        }




    }
}
