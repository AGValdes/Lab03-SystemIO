using System;
using System.IO;


namespace Lab03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductOfThree(getNums()));
            Console.WriteLine("This was your average, " + AverageOfNumbers(getNumberArray()));
            printPattern();
            int[] practiceArray = new int[] { 12, 34, 1 , 76, 3 };
            Console.WriteLine(MaxValue(practiceArray));
            WriteToFile();
            ReadFile();

        }
        //=============== Challenge 1
        public static string getNums()
        {
            Console.WriteLine("Please enter three numbers seperated by a space.");
            return Console.ReadLine();
        }
        public static decimal ProductOfThree(String str)
        {
            string[] nums = str.Split(" ");
            if (nums.Length < 3) return 0;
            return Convert.ToDecimal(nums[0]) * Convert.ToDecimal(nums[1]) * Convert.ToDecimal(nums[2]);
        }
        //=============== Challenge 2
        public static decimal[] getNumberArray()
        {
            Console.WriteLine("Please enter a number between 2 and 10");
            string userInput = Console.ReadLine();
            int userNum = Convert.ToInt32(userInput);
            decimal[] averageArray = new decimal[userNum];
            // every time it iterates through, it assigns each index to the value input by the user
            for (int i = 0; i < averageArray.Length; i++)
            {
                Console.WriteLine("Please enter a random number.");
                decimal number = Convert.ToDecimal(Console.ReadLine());
                if (number >= 0)
                {
                    averageArray[i] = number;
                }
            }
            return averageArray;
        }
        public static decimal AverageOfNumbers(decimal[] numberArray)
        {
          //converting the array lenght to a decimal so i can use the Decimal.Divide method
            decimal averageDivisor = Convert.ToDecimal(numberArray.Length);
           
            decimal sum = 0;
      
            foreach (decimal num in numberArray)
            {
                sum += num;
            }
          
            return Decimal.Divide(sum, averageDivisor);
        }

        //=============== Challenge 3

        public static void printPattern()
        {
            Console.WriteLine("    *    \n" +
                              "   ***   \n" +
                              "  *****  \n" +
                              "******** \n" +
                              "  *****  \n" +
                              "   ***   \n" +
                              "    *    \n");
            //I'm going to keep working on this later, I know the above does not really meet the requirements
           /* string[] starArray = new string[] { " ", " ", " ", " ", "*", " ", " ", " ", " " };
            int midpoint = starArray.Length / 2;
            
            for (int i = 0; i <= midpoint; i++)
            {
                starArray[midpoint - i] = "*";
                starArray[midpoint + i] = "*";
                for (int j = 0; j <= midpoint; i++)
                {
                    string array = starArray[j].ToString();
                    Console.WriteLine(array);
                    break;
                }
            }
            for (int i = midpoint+1; i < starArray.Length; i++)
            {
                if(i == midpoint)
                {
                    starArray[i] = "*";
                }
                else
                {
                    starArray[starArray.Length - i] = " ";
                    starArray[0 + i] = " ";
                }
                for (int j = midpoint+1; j < starArray.Length; i++)
                {
                    string array = starArray[j].ToString();
                    Console.WriteLine(array);
                    break;
                }
               
            }*/

        }
        //=============== Challenge 4
        public static int MostDuplicates(int[] arr)
        {
            int maxCount = 0, returnValue = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                int numToCompare = arr[j];
                int counter = 1;
                for (int i = j + 1; i < arr.Length; i++)
                {
                    if (numToCompare == arr[i])
                    {
                        counter++;
                    }
                }
                if (counter > maxCount)
                {
                    maxCount = counter;
                    returnValue = numToCompare;
                }
            }
            if (maxCount == 1) return arr[0];
            return returnValue;
        }
        //=============== Challenge 5
        public static int MaxValue(int[] arr)
        {
            int maxValue = 0;
            for(int i = 0; i < arr.Length; i++)
            {
              
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        maxValue = arr[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return maxValue;
        }
        //=============== Challenge 6
        static void WriteToFile()
        {
            string path = "../../../words.txt";
            Console.WriteLine("Please enter some text:");
            string input = Console.ReadLine();
            File.WriteAllText(path, input);
        }
        //=============== Challenge 7
        static void ReadFile()
        {
            string path = "../../../words.txt";
            string message = File.ReadAllText(path);
            Console.WriteLine(message);


        }

    }
}
