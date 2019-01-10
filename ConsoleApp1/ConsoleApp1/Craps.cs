using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Craps
    {
        int Die1 = 0;
        int Die2 = 0;

        private Random rand = new Random();
        //private Random rand2 = new Random();
        int point, new_rules_sum;
        int round = 1;
        string choice;
        // private Random rand2 = new Random();

            public Craps()
        {
            rand = new Random();
        }
        public int dieOne()
        {
            Die1 = rand.Next(1, 8);

            return Die1;

        }
        public int dieTwo()
        {
            Die2 = rand.Next(1, 8);
            return Die2;
        }

      


        private enum status
        {
            KEEP_PLAYING,
            WIN,
            LOST,
            DONE,
        }

       
        int wins, losses, dice1, dice2 = 0;

        public void Play()
        {
            status gameStatus = status.KEEP_PLAYING;
            // int point, new_rules_sum;
            int sum_of_dice;


           do
            {
                Console.WriteLine("Welcome to the Craps Game");
                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");

                Console.WriteLine("+++++++++++++++++++++++++++++++++++++++");
                Console.WriteLine(" ");

                Console.WriteLine("ITS YOUR TURN" + " " + " +++++++++++++++++++++");
                Console.WriteLine(" ");

                Console.WriteLine("Rolling dice....");
                Console.WriteLine(" ");
                Console.WriteLine("======");
                Console.WriteLine("Round: {0}", round);
                Console.WriteLine("======");
                Console.WriteLine(" ");
                Console.WriteLine("======");
                Console.WriteLine("Wins: {0} and Losses: {1}", wins, losses);
                Console.WriteLine("======");

                dice1 = dieOne();
                Console.WriteLine("Dice 1:" + " " + dice1);
                dice2 = dieTwo();
                Console.WriteLine("Dice 2:" + " " + dice2);
                //   Console.WriteLine("You rolled a" + " " + "{0} & {1}", dice1, dice2);

                sum_of_dice = dice1 + dice2;
                Console.WriteLine(" ");

                Console.WriteLine("Sum of dice...." + dice1 + " + " + dice2 + "=" + "{0}", sum_of_dice);
                Console.WriteLine(" ");



                if (sum_of_dice == 7 || sum_of_dice == 11)
                {
                    Console.WriteLine("You win");
                    Console.WriteLine("------------ ");
                    wins++;
                    round++;

                    Thread.Sleep(5000);

                    Console.WriteLine("Press yes to roll again or press no to quit");
                    string choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                       gameStatus = status.KEEP_PLAYING;
                    }
                    else if (choice == "no")
                    {
                        gameStatus = status.DONE;
                        Environment.Exit(0);
                    }



                }

                else if (sum_of_dice == 2 || sum_of_dice == 3 || sum_of_dice == 12)
                {

                    Console.WriteLine("You lose");
                    Console.WriteLine(" ");
                    losses++;
                    round++;


                    Console.WriteLine("Press yes to roll again or press no to quit");
                    string choice = Console.ReadLine();
                    if (choice == "yes")
                    {
                        gameStatus = status.KEEP_PLAYING;
                    }
                    else if (choice == "no")
                    {
                        gameStatus = status.DONE;
                        Environment.Exit(0);
                    }

                }
                else if (sum_of_dice == 4 || sum_of_dice == 5 || sum_of_dice == 6 || sum_of_dice == 7 || sum_of_dice == 8 || sum_of_dice == 9 || sum_of_dice == 10)
                {
                    point = sum_of_dice;
                    Console.WriteLine("Rules changed, point is now {0}. If you roll  a {0} you win, if you roll a 7 you lose", point);
                    Console.WriteLine(" ");

                    Console.WriteLine("Roll again...");
                    Console.WriteLine(" ");

                    int rollagain1 = dieOne();
                    int rollagain2 = dieTwo();

                    new_rules_sum = rollagain1 + rollagain2;

                    Console.WriteLine("You rolled {0} and a {1}", rollagain1,rollagain2);
                    Console.WriteLine(" ");

                    if (new_rules_sum == 7)
                    {
                    Console.WriteLine("You rolled a {0}, you lose ", new_rules_sum);
                        Console.WriteLine(" ");
                        losses++;
                        point = 0;
                        round++;

                        Console.WriteLine("Press yes or no button to roll again..");
                        string choice = Console.ReadLine();
                        if (choice == "yes")
                        {
                            gameStatus = status.KEEP_PLAYING;
                        }
                        else if (choice == "no")
                        {
                            gameStatus = status.DONE;
                            Environment.Exit(0);
                        }
                    }

                  

                    else if(new_rules_sum == point)
                    {
                        Console.WriteLine("You win, you rolled a {0}", point);
                        Console.WriteLine(" ");
                        wins++;
                        point = 0;
                        round++;


                        Console.WriteLine("Press yes to roll again or press no to quit");
                        string choice = Console.ReadLine();
                        if (choice == "yes")
                        {
                            gameStatus = status.KEEP_PLAYING;
                        }
                        else if (choice == "no")
                        {
                            gameStatus = status.DONE;
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        do
                        {
                            Console.WriteLine("Roll again...");
                             rollagain1 = dieOne();
                             rollagain2 = dieTwo();

                            int sum = rollagain1 + rollagain2;

                            Console.WriteLine(" ");
                            Console.WriteLine("++++++++++++++++++++++");
                            Console.WriteLine(" ");

                            Console.WriteLine("You rolled a {0} and a {1} , " , rollagain1, rollagain2);
                            Console.WriteLine("Sum = {0}", sum);
                            Console.WriteLine(" ");

                            if (sum == point)
                            {
                                Console.WriteLine("You win");
                                wins++;
                                round++;
                                gameStatus = status.KEEP_PLAYING;

                                Console.WriteLine("Press yes to roll again or press no to quit");
                                string choice = Console.ReadLine();
                                if (choice == "yes")
                                {
                                    gameStatus = status.KEEP_PLAYING;
                                }
                                else if (choice == "no")
                                {
                                    gameStatus = status.DONE;
                                    Environment.Exit(0);
                                }

                            }
                            else if(sum == 7)
                            {
                                Console.WriteLine("You lose");
                                losses++;
                                round++;

                                gameStatus = status.KEEP_PLAYING;

                                Console.WriteLine("Press yes to roll again or press no to quit");
                                string choice = Console.ReadLine();
                                if (choice == "yes")
                                {
                                    gameStatus = status.KEEP_PLAYING;
                                }
                                else if (choice == "no")
                                {
                                    gameStatus = status.DONE;
                                    Environment.Exit(0);
                                }
                            }

                        } while (new_rules_sum != 7 || new_rules_sum != point);

                    

                    }

                }
            } while (gameStatus == status.KEEP_PLAYING && choice != "no") ;
        }
    }
}
    