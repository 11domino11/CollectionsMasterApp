using System;
using System.Collections.Generic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50
            int[] numbersArray = new int[50];

            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(numbersArray);

            //TODO: Print the first number of the array
            Console.WriteLine(numbersArray[0]);
            //TODO: Print the last number of the array            
            Console.WriteLine(numbersArray[49]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersArray);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");
            ReverseArray(numbersArray);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(numbersArray);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            Array.Sort(numbersArray);
            NumberPrinter(numbersArray);

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var numbersList = new List<int>();

            //TODO: Print the capacity of the list to the console
            Console.WriteLine(numbersList.Count);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            Populater(numbersList);

            //TODO: Print the new capacity
            Console.WriteLine(numbersList.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int targetNumber;
            string targetNumberString = Console.ReadLine();
            bool success = int.TryParse(targetNumberString, out targetNumber);
            if (success)
            {
                NumberChecker(numbersList, targetNumber);
            }
            else
            {
                Console.WriteLine($"Attempted conversion of '{targetNumberString ?? "<null>"}' failed.");
            }
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numbersList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");
            OddKiller(numbersList);
            NumberPrinter(numbersList);
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            numbersList.Sort();
            NumberPrinter(numbersList);
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            

            //TODO: Clear the list
            

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            foreach (int number in numbers)
            {
                if(number % 3 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }

        private static void OddKiller(List<int> numberList)
        {
            foreach (var number in numberList.ToArray())
            {
                if(number % 2 != 0)
                {
                    numberList.Remove(number);
                }
            }
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            bool isExist = numberList.Contains(searchNumber);
            
            if (isExist)
             {
                 Console.WriteLine("Your number is in the list");
             }
             else Console.WriteLine("Your number is NOT in the list");
        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                int randomNumber = rng.Next(50);
                numberList.Add(randomNumber);
            }

        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();

            for (int i = 0; i < 50; i++)
            {
                numbers[i] = rng.Next(50);
            }
         
            Console.WriteLine("Array Populated");

        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
            Console.WriteLine(String.Join(',', array));
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
