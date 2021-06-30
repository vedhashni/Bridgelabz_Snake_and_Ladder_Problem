using System;

namespace Snake_ladder
{
   /// <summary>
   /// UC1 - initializing the single player at start position "0"
   /// </summary>
    class Program
    {
        public const int start_position = 0;
        public const int board_size = 100;
        public static int player1Position = start_position;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Problem!");
        }
    }
}
