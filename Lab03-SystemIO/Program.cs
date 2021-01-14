using System;


namespace Lab03_SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ProductOfThree(getNums()));
            Console.WriteLine("This was your average, " + AverageOfNumbers(getNumbers()));
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
    }
}
