using System;

namespace Snake_ladder
{
   /// <summary>
   /// UC1 - initializing the single player at start position "0"
   /// UC2 - Using Random dice values are computed
   /// UC3 - Player's action is performed
   /// UC4 - Repeat the player till reaches wining position 100
   /// UC6 - Return no. of times dice rolled and it's position at each roll
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
            int player1roll = 0;
            while (player1Position != board_size)
            {
                player1roll += 1;
                Program.Dicerolled();
            }
            Console.WriteLine("No of Times the Dice rolled By P1: " + player1roll);
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
            int defaultPosition = player1Position;
            Random random = new Random();
            int option = random.Next(1, 4);
            switch (option)
            {
                case 1:
                    Console.WriteLine("No play :" + player1Position);
                    break;

                case 2:
                    //Console.WriteLine("Ladder and current position is : " + (player1Position += diceValue));
                    if (player1Position + diceValue <= board_size)
                    {
                        Console.WriteLine("Ladder and current position is : " + (player1Position += diceValue));
                    }
                    else
                    {
                        player1Position = defaultPosition;
                    }
                    break;

                case 3:

                    //player1Position = 0;
                    //Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                    if ((player1Position - diceValue) < 0)
                    {
                        player1Position = 0;
                        Console.WriteLine("Snake Bite pushed down to: " + player1Position);
                    }
                    else
                    {
                        Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                    }
                    break;

            }
        }
    }
}
