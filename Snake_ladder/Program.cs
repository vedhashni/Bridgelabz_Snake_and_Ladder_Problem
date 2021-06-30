using System;

namespace Snake_ladder
{
    /// <summary>
    /// UC1 - initializing the single player at start position "0"
    /// UC2 - Using Random dice values are computed
    /// UC3 - Player's action is performed
    /// UC4 - Repeat the player till reaches wining position 100
    /// UC6 - Return no. of times dice rolled and it's position at each roll
    /// UC7 - Player 2 is included and returning who won the game
    /// </summary>
    class Program
    {
        public const int start_position = 0;
        public const int board_size = 100;
        public static int player1Position = start_position;
        public static int player2Position = start_position;
        public static int play = 0;
        public static int win = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Snake Ladder Problem!");
            Program.Firstplayer();
            // to find the who won the game
            if (win == 1)
            {
                Console.WriteLine("PLAYER 1 WINS");
            }
            else if (win == 2)
            {
                Console.WriteLine("PLAYER 2 WINS");
            }
            else
            {
                Console.WriteLine("No one won the game");
            }
        }

        // Function to compute firstplayer's dice value
        public static void Firstplayer()
        {
            //int player1roll = 0;
            while (player1Position != board_size && play == 0)
            {
                //player1roll += 1;
                Program.Dicerolled();
                Program.Secondplayer();
            }
            //Console.WriteLine("No of Times the Dice rolled By P1: " + player1roll);
        }

        //to compute secondplayer's dice value
        public static void Secondplayer()
        {
            while (player2Position != board_size && play == 1)
            {

                Program.Dicerolled();
                Firstplayer();

            }
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
                    //Console.WriteLine("No play :" + player1Position);
                    if (play == 0)
                    {
                        if (player1Position != 100)
                        {
                            Console.WriteLine("P1 No play :" + player1Position);
                            play = 1;
                        }
                        else
                        {

                            win = 1;
                            return;

                        }
                    }
                    else
                    {
                        if (player2Position != 100)
                        {
                            Console.WriteLine("P2 No play :" + player2Position);
                            play = 0;
                        }
                        else
                        {

                            win = 2;
                            return;

                        }
                    }
                    break;
                    
                    // turn moves to ladder
                case 2:
                    if (play == 0)
                    {

                        if (player2Position == 100)
                        {
                            return;
                        }

                        if (player1Position + diceValue <= board_size)
                        {
                            Console.WriteLine("P1 Ladder and current position is : " + (player1Position += diceValue));
                            if (player1Position != 100)
                            {
                                Console.WriteLine("P1 Roll again:");
                                play = 0;
                                Firstplayer();
                            }
                            else
                            {
                                win = 1;
                                return;
                            }

                        }
                        else
                        {
                            player1Position = defaultPosition;
                        }
                    }
                    else
                    {
                        if (player1Position == 100)
                        {
                            return;
                        }
                        if (player2Position + diceValue <= board_size)
                        {
                            Console.WriteLine("P2 Ladder and current position is : " + (player2Position += diceValue));
                            if (player2Position != 100)
                            {
                                Console.WriteLine("P2 Roll again:");
                                play = 1;
                                Secondplayer();

                            }
                            else
                            {
                                win = 2;
                                return;
                            }

                        }
                        else
                        {
                            player2Position = defaultPosition;
                        }



                    }

                    break;

                    //turns move to snake bite
                    case 3:

                    //player1Position = 0;
                    //Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                    if (play == 0)
                    {
                        if ((player1Position - diceValue) < 0)
                        {
                            player1Position = 0;
                            Console.WriteLine("Snake Bite pushed down to: " + player1Position);
                            play = 1;
                        }
                        else
                        {
                            Console.WriteLine("Snake Bite pushed down to : " + (player1Position -= diceValue));
                            play = 1;
                        }
                    }
                    else
                    {
                        if ((player2Position - diceValue) < 0)
                        {
                            player2Position = 0;
                            Console.WriteLine("P2 Snake Bite pushed down to: " + player2Position);
                            play = 0;

                        }
                        else
                        {

                            Console.WriteLine("P2 Snake Bite pushed down to : " + (player2Position -= diceValue));
                            play = 0;
                        }

                    }
                    break;

                }
            }
        }
    }

