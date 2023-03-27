// A Basic Calculator I Made in around a Hour using Using C#

using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {  
            Console.WriteLine("Welcome to Hassan's calculator!");
            Console.WriteLine("How many numbers would you like to use in your calculation? Enter an integer between 2 and 4:");
            int size = Convert.ToInt32(Console.ReadLine());
            //Sees Weather Inputted Value is in range else should end the script if return; works
            // Use Of "|| found from google to replace use of another if statement for size > 4 "

            if (size < 2 || size > 4)
            {
                Console.WriteLine("Please restart the script and select an integer between the specified range.");
                return;
            }

            Console.WriteLine("Enter the first number of your calculation:");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number of your calculation:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            // Sets Default valuer of answer to 0 Regardless of numbers inputted
            int aswr = 0;

            if (size == 2)
            {
                Console.WriteLine("Select whether you want to + - * / these numbers:");
                char solve = Convert.ToChar(Console.ReadLine());

                switch (solve)
                {
                    case '+':
                        aswr = n1 + n2;
                        break;
                    case '-':
                        aswr = n1 - n2;
                        break;
                    case '*':
                        aswr = n1 * n2;
                        break;
                    case '/':
                        aswr = n1 / n2;
                        break;
                    default:
                        Console.WriteLine("Please restart the script and select an operator between the specified range.");
                        return;
                }
            }
            else if (size == 3)
            {
                Console.WriteLine("Enter the third number of your calculation:");
                int n3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select whether you want to + - * / these numbers:");
                char solve = Convert.ToChar(Console.ReadLine());

                switch (solve)
                {
                    case '+':
                        aswr = n1 + n2 + n3;
                        break;
                    case '-':
                        aswr = n1 - n2 - n3;
                        break;
                    case '*':
                        aswr = n1 * n2 * n3;
                        break;
                    case '/':
                        aswr = n1 / n2 / n3;
                        break;
                    default:
                        Console.WriteLine("Please restart the script and select an operator between the specified range.");
                        return;
                }
            }
            else if (size == 4)
            {
                Console.WriteLine("Enter the third number of your calculation:");
                int n3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the fourth number of your calculation:");
                int n4 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Select whether you want to + - * / these numbers:");
                char solve = Convert.ToChar(Console.ReadLine());

                switch (solve)
                {
                    case '+':
                        aswr = n1 + n2 + n3 + n4;
                        break;
                    case '-':
                        aswr = n1 - n2 - n3 - n4;
                        break;
                    case '*':
                        aswr = n1 * n2 * n3 * n4;
                        break;
                    case '/':
                        aswr = n1 / n2 / n3 / n4;
                        break;
                    default:
                        Console.WriteLine("Please restart the script and select an operator between the specified range.");
                        return;
                }
            }
            // Loops Until Inputted Numbers Of Calculation is met then finally outputs the answer
            // Opportunity To shorten the script to have same calculation regardless of how nany numbers inputted
            Console.WriteLine("Answer is: " + aswr);
        }
    }
}
