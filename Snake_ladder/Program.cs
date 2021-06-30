using System;

namespace Snake_ladder
{
   /// <summary>
   /// UC1 - initializing the single player at start position "0"
   /// UC2 - Using Random dice values are computed
   /// </summary>
    class Program
    {
        public const int start_position = 0;
        public const int board_size = 100;
        public static int player1Position = start_position;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Problem!");
            Program.Firstplayer();
        }

        // Function to compute firstplayer's dice value
        public static void Firstplayer()
        {
            Console.WriteLine(Program.Dicerolled());
        }

        // Function to compute dice values randomly
        public static int Dicerolled()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
