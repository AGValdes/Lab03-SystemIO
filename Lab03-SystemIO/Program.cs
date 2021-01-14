using System;
using System.IO;


namespace Lab03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(ProductOfThree(getNums()));
            //Console.WriteLine("This was your average, " + AverageOfNumbers(getNumbers()));
            //int[] practiceArray = new int[] { 12, 34, 1 , 76, 3 };
            //Console.WriteLine(MaxValue(practiceArray));
            WriteToFile();
        }
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

        public static string getNumbers()
        {
            Console.WriteLine("Please enter a number between 2 and 10");
            return Console.ReadLine();
        }
        public static decimal AverageOfNumbers(string userNum)
        {
            // converting parameter to an integer
            int arrayLength = Convert.ToInt32(userNum);
            decimal[] averageArray = new decimal[arrayLength];
            decimal sum = 0;
            // every time it iterates through, it assigns each index to the value input by the user
            for (int i = 0; i < averageArray.Length; i++)
            {
                Console.WriteLine("Please enter a random number.");
                averageArray[i] = Convert.ToDecimal(Console.ReadLine());
            }
            foreach (decimal num in averageArray)
            {
                sum += num;
            }
            decimal arrayLengthAsDecimal = Convert.ToDecimal(arrayLength);
            return Decimal.Divide(sum, arrayLengthAsDecimal);
        }
        public static int MostDuplicates(int[] arr)
        {
            //sort 
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
                    else
                    {
                        if (counter > maxCount)
                        {
                            maxCount = counter;
                            returnValue = numToCompare;
                            j = i;
                        }
                        break;
                    }
                }
            }
            return returnValue;
        }

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

        static void WriteToFile()
        {
            string path = "../../../words.txt";
            Console.WriteLine("Please enter some text:");
            string input = Console.ReadLine();
            File.WriteAllText(path, input);
        }


    }
}
