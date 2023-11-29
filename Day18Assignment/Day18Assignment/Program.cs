using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day18Assignment
{
    internal class Program
    {
        public delegate void OurDel(int ch, out int energyLevel, out int winProbability);

        public static void Spin(int ch, out int energyLevel, out int winProbability)
        {
            int Energylevel = 1;
            int winprobality = 100;

            if (ch == 1)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel += 1} and your win probability is {winprobality += 10}");
            }
            else if (ch == 2)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel += 2} and your win probability is {winprobality += 20}");
            }
            else if (ch == 3)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel -= 3} and your win probability is {winprobality -= 30}");
            }
            else if (ch == 4)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel += 4} and your win probability is {winprobality += 40}");
            }
            else if (ch == 5)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel += 5} and your win probability is {winprobality += 50}");
            }
            else if (ch == 6)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel -= 1} and your win probability is {winprobality -= 60}");
            }
            else if (ch == 7)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel += 1} and your win probability is {winprobality += 70}");
            }
            else if (ch == 8)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel -= 2} and your win probability is {winprobality -= 20}");
            }
            else if (ch == 9)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel -= 3} and your win probability is {winprobality -= 30}");
            }
            else if (ch == 10)
            {
                Console.WriteLine($"You have entered {ch} your energy level is {Energylevel += 10} and your win probability is {winprobality += 100}");
            }
            energyLevel = Energylevel;
            winProbability = winprobality;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter UserName");
            string Name = Console.ReadLine();

            int totalRounds = 5;
            int requiredEnergy = 4;
            int requiredWinProbability = 60;

            OurDel objDel = new OurDel(Spin);

            for (int i = 1; i <= totalRounds; i++)
            {
                Console.WriteLine("Enter a number between 1 to 10");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    objDel(choice, out int energyLevel, out int winProbability);

                    Console.WriteLine($"Round {i}: You have entered {choice}. Your energy level is {energyLevel} and your win probability is {winProbability}");

              
                    if (energyLevel >= requiredEnergy && winProbability > requiredWinProbability)
                    {
                        Console.WriteLine("Winner!");
                    }
                    else if (energyLevel >= 1 && winProbability > 50)
                    {
                        Console.WriteLine("Runner Up!");
                    }
                    else
                    {
                        Console.WriteLine("Loser!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; 
                }
            }

            Console.ReadKey();
        }
    }
    }
