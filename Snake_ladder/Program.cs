using System;

namespace Snake_ladder
{
   /// <summary>
   /// UC1 - initializing the single player at start position "0"
   /// UC2 - Using Random dice values are computed
   /// UC3 - Player's action is performed
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
           Program.Dicerolled();
        }

        // Function to compute dice values randomly
        public static void Dicerolled()
        {
            Random random = new Random();
            int turn = random.Next(1, 7);
            Program.Moves(turn);
        }

        // Used to find the player's turn actions
        public static void Moves(int diceValue)
        {
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("No play :" + player1Position);
                    break;

                case 2:
                    Console.WriteLine("Ladder and current position is : " + (player1Position += diceValue));
                    break;

                case 3:

                    player1Position = 0;
                    Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                    break;

            }
        }
    }
}
