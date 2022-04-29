using System;

namespace prove1
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "1";
            string two = "2";
            string three = "3";
            string four = "4";
            string five = "5";
            string six = "6";
            string seven = "7";
            string eight = "8";
            string nine = "9";
            string spacer = "-+-+-";

            Console.WriteLine($"{one}|{two}|{three}");
            Console.WriteLine(spacer);
            Console.WriteLine($"{four}|{five}|{six}");
            Console.WriteLine(spacer);
            Console.WriteLine($"{seven}|{eight}|{nine}");

            string player = "x";
            Console.Write($"{player}'s turn to choose a square (1-9): ");
            Console.ReadLine();
            
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
