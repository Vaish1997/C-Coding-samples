using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {

        static char[,] playfield =
        {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }

        };

        static char[,] playfieldinitial =
       {
            {'1','2','3' },
            {'4','5','6' },
            {'7','8','9' }

        };

        static int turns = 0;

        static void Main(string[] args)
        {
            int player = 2; //let by default player1 starts
            int input = 0;
            bool IsInputCorrect = true;

           

            

            do
            {
                if (player == 2)
                {
                    player = 1;
                    EnterSymbolXorO(player, input);

                }
                else if (player == 1)
                {
                    player = 2;
                    EnterSymbolXorO(player, input);

                }
                set();

                //check winner
                char[] playerchars = { 'X', 'O' };

                foreach(char k in playerchars)
                {
                    if (((playfield[0, 0] == k) && (playfield[0, 1] == k) && (playfield[0, 2] == k)) || ((playfield[1, 0] == k) && (playfield[1, 1] == k) && (playfield[1, 2] == k)) || ((playfield[2, 0] == k) && (playfield[2, 1] == k) && (playfield[2, 2] == k))
                        || ((playfield[0, 0] == k) && (playfield[1, 1] == k) && (playfield[2, 2] == k)) || ((playfield[0, 2] == k) && (playfield[1, 1] == k) && (playfield[2, 0] == k)) || ((playfield[0, 0] == k) && (playfield[1, 0] == k) && (playfield[2, 0] == k)) || ((playfield[0, 1] == k) && (playfield[1, 1] == k) && (playfield[2, 1] == k)) || ((playfield[0, 2] == k) && (playfield[1, 2] == k) && (playfield[2, 2] == k))
                        )
                    {
                        if (k == 'X')
                        {

                            Console.WriteLine("Player 2 Won");
                        }
                        else
                            Console.WriteLine("Player 1 Won");

                        Console.WriteLine("Press Any Key to reset");
                        Console.ReadKey();

                        reset();
                        break;

                    }

                    else if (turns == 10)
                    {
                        Console.WriteLine("We have a draw");
                        Console.WriteLine("Press Any Key to reset");
                        Console.ReadKey();

                        reset();
                        break;

                    }


                }
                do
                {
                    Console.WriteLine("\nPlayer {0} Choose your Field", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }

                    catch
                    {
                        Console.WriteLine("Enter Proper Input");
                    }


                    if ((input == 1 && playfield[0, 0] == '1'))
                        IsInputCorrect = true;
                    else if ((input == 2 && playfield[0, 1] == '2'))
                        IsInputCorrect = true;
                    else if ((input == 3 && playfield[0, 2] == '3'))
                        IsInputCorrect = true;
                    else if ((input == 4 && playfield[1, 0] == '4'))
                        IsInputCorrect = true;
                    else if ((input == 5 && playfield[1, 1] == '5'))
                        IsInputCorrect = true;
                    else if ((input == 6 && playfield[1, 2] == '6'))
                        IsInputCorrect = true;
                    else if ((input == 7 && playfield[2, 0] == '7'))
                        IsInputCorrect = true;
                    else if ((input == 8 && playfield[2, 1] == '8'))
                        IsInputCorrect = true;
                    else if ((input == 9 && playfield[2, 2] == '9'))
                        IsInputCorrect = true;

                    else
                    {
                        Console.WriteLine("\nIncorrect Input! Please choose another field");
                        IsInputCorrect = false;
                    }
                    
                } while (!IsInputCorrect);
       

            } while (true);

            Console.Read();


        }


        public static void EnterSymbolXorO(int player, int input)
        {
            char playersign = ' ';
            

            if (player == 1)
                playersign = 'X';
            else if(player==2)
            {
                playersign = 'O';
            }
            switch (input)
            {
                case 1:
                    playfield[0, 0] = playersign;
                    
                    break;
                case 2:
                    playfield[0, 1] = playersign;
                   
                    break;
                case 3:
                    playfield[0, 2] = playersign;
                    break;
                case 4:
                    playfield[1, 0] = playersign;
                    break;
                case 5:
                    playfield[1, 1] = playersign;
                    break;
                case 6:
                    playfield[1, 2] = playersign;
                    break;
                case 7:
                    playfield[2, 0] = playersign;
                    break;
                case 8:
                    playfield[2, 1] = playersign;
                    break;
                case 9:
                    playfield[2, 2] = playersign;
                    break;
            }


        }
        public static void set()

        {
            int i = 0, j = 0;
            Console.WriteLine(" ____ _____ _____");
            Console.Clear();
            while (i<3)
            {


                //Setting the Play Grid
                
                Console.WriteLine("|    |     |     |");
                Console.WriteLine("|  {0} |  {1}  |  {2}  |", playfield[i, j],playfield[i,j+1],playfield[i,j+2]);
                Console.WriteLine("|____|_____|_____|");
                turns++;
                
                i++;

            }
        }

        public static void reset()
        {
            playfield = playfieldinitial;
            set();
            turns = 0;
        }

    }
}
    

    
