using System.Collections.Immutable;

namespace topic_7_lists
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Topic 7
            List<int> numbers = new List<int>();
            Random generator = new Random();

            string choice = "";

            while (choice != "q")
            {

                Console.Clear();

                Console.WriteLine("Here are 25 random numbers.");

                for (int i = 0; i <= 25; i++)
                {
                    numbers.Add(generator.Next(10, 20));
                }
                foreach (int num in numbers)
                {
                    Console.Write($"{num} ");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Welcome to my menu.  Please select an option:");
                Console.WriteLine();
                Console.WriteLine("1 - Sort the list");
                Console.WriteLine("2 - Make a new list of random numbers");
                Console.WriteLine("3 - Remove a value");
                Console.WriteLine("4 - Add a value");
                Console.WriteLine("5 - Count the number of occurrences of a specified number");
                Console.WriteLine("6 - Print the largest value");
                Console.WriteLine("7 - Print the smallest value");
                Console.WriteLine("8 - Quit");
                Console.WriteLine("9 - Print the sum and average of the numbers in the list");
                Console.WriteLine("10 - Determine the most frequently occurring value(s)");
                Console.WriteLine("11 - Pick a value and determine the number of occurrences in the list.");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1") //sort the list 
                {
                    Console.WriteLine("You chose Sort the list");
                    Console.WriteLine();

                    numbers.Sort();  

                    Console.WriteLine("Sorted numbers:");
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int number = numbers[i];
                        Console.Write($"{number} ");
                    }
                    Console.WriteLine() ;
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "2")//Make a new list of random numbers
                {
                    Console.WriteLine("You chose Make a new list of random numbers");
                    Console.WriteLine();
                    numbers.Clear();
                    Console.WriteLine("Here is a new list of numbers");

                    for (int i = 0; i <= 25; i++)
                    {
                        numbers.Add(generator.Next(10, 20));
                    }
                    foreach (int num in numbers)
                    {
                        Console.Write($"{num} ");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "3")//Remove a value
                {
                    int value;
                    Console.WriteLine("You chose Remove a value");
                    Console.WriteLine();
                    Console.WriteLine("Pick a value from the list");
                    value = Convert.ToInt32(Console.ReadLine());

                    numbers.Remove(value);
                    Console.WriteLine();
                    numbers.ForEach(Console.Write);

                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "4") //Add a value
                {
                    Console.WriteLine("You chose Add a value");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "5")// Count the number of occurrences of a specified number
                {

                    Console.WriteLine("You chose Count the number of occurrences of a specified number");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "6")// Print the largest value
                {

                    Console.WriteLine("You chose Print the largest value");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "7")// Print the smallest value
                {

                    Console.WriteLine("You chose Print the smallest value");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "8")
                {
                    Console.WriteLine("Thanks for playing.");
                    break;
                }
                else if (choice == "9") // Print the sum and average of the numbers in the list
                {

                    Console.WriteLine("You chose Print the sum and average of the numbers in the list");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "10") // Determine the most frequently occurring value(s)
                {

                    Console.WriteLine("You chose Determine the most frequently occurring value(s)");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else if (choice == "11")// Pick a value and determine the number of occurrences in the list.
                {

                    Console.WriteLine("You chose Pick a value and determine the number of occurrences in the list.");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
                else
                {
                    Console.WriteLine("Invalid choice, press ENTER to continue.");
                    Console.ReadLine();
                    numbers.Clear();
                }
            }


        }
    }
}