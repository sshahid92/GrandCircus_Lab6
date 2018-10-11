using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var rollCount = 0;

            while (true)
            {
                //Prompt the user as to how many sides the dice has
                //prompt the user to roll the dice
                if(rollCount >= 1)
                {
                    Console.WriteLine("Would you like to roll again?");
                }
                else
                {
                    Console.WriteLine("Welcome to the Grand Circus Casino! Would you like to roll the dice? (y/n)");
                }
                
                var answer = Console.ReadLine().ToLower();
                
                if (answer == "y" || answer == "yes")
                {
                    
                    ++rollCount;

                    Console.WriteLine("How many sides should each die have?");
                    int sidesOfDice;
                    bool isInt = int.TryParse(Console.ReadLine(), out sidesOfDice);
                    if (isInt == false)
                    {
                        Console.WriteLine("Please enter an integer");
                        continue;
                    }
                    else if (sidesOfDice <= 0)
                    {
                        Console.WriteLine("Please enter a value greater than 0");
                        continue;
                    }
                    else
                    {
                        sidesOfDice++;
                        int diceRoll1 = getDiceRoll(sidesOfDice); 
                        int diceRoll2 = getDiceRoll(sidesOfDice);

                        
                        Console.WriteLine("Roll {0}:", rollCount);
                        Console.WriteLine(diceRoll1);
                        Console.WriteLine(diceRoll2);
                        
                    }
                    

                }
                else if (answer == "n" || answer == "no")
                {
                    Console.Write("Goodbye!");
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid response.");
                    continue;
                }

                


                //the user is rolling two dice. display both results and ask user if they want to go again

            }

            int getDiceRoll(int sides)
            {
                
                int dice = random.Next(1, sides);
                return dice;
            }

          





        }
    }
}
