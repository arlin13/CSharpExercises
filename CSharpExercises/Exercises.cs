using System;
using System.Linq;

namespace CSharpExercises
{
    public static class Exercises
    {
        public static string HelloWorld()
        {
            return "Hello World!";
        }

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")
        public static string SayHello(string name)
        {
            return "Hello " + name + "!";
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.
        public static decimal Divide(decimal a, decimal b)
        {
            return Convert.ToDecimal(a / b);
        }

        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        public static bool CanOpenCheckingAccount(int age)
        {
            return (age >= 18) ? true : false;
        }

        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.
        public static string GetFirstName(string name)
        {
            return name.Split(' ')[0];
        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)
        public static string ReverseStringHard(string quote)
        {
            string reverseString = string.Empty;
            for (int i = quote.Length - 1; i >= 0; i--)
            {
                reverseString += quote[i];
            }
            return reverseString;
        }

        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)
        public static string ReverseStringEasy(string quote)
        {
            char[] letters = quote.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        public static string PrintTimesTable(int x)
        {
            string timesTable = string.Empty;
            for (int i = 0; i < 10; i++)
            {
                if (i == 9)
                    timesTable += x + " * " + (i + 1) + " = " + x * (i + 1);
                else
                    timesTable += x + " * " + (i + 1) + " = " + x * (i + 1) + "\r\n";
            }
            return timesTable;
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.
        public static double ConvertKelvinToFahrenheit(double kelvinTemperature)
        {
            return Math.Round((1.8 * (kelvinTemperature - 273.15)) + 32, 2);
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)
        public static double GetAverageHard(int[] numbers)
        {
            double average = 0.0;
            for (int i = 0; i < numbers.Length; i++)
            {
                average += numbers[i];
            }
            return average / numbers.Length;
        }

        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)
        public static double GetAverageEasy(int[] numbers)
        {
            return numbers.Average();
        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        public static string DrawTriangle(int number, int width)
        {
            string triangle = string.Empty;
            for (int i = width; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    triangle += number.ToString();
                }
                if (i > 1)
                    triangle += Environment.NewLine;
            }
            return triangle;
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")
        public static string GetMilesPerHour(double distance, int hours, int minutes, int seconds)
        {
            int totalSeconds = (hours * 3600) + (minutes * 60) + seconds;
            var speed = Math.Round((3600 * distance) / totalSeconds);
            return speed + "MPH";
        }


        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.
        public static bool IsVowel(char c)
        {
            char[] vowels = { 'A', 'a', 'E', 'e', 'I', 'i', 'O', 'o', 'U', 'u' };

            return (vowels.Any(v => v == c)) ? true : false;
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.
        public static bool IsConsonant(char c)
        {
            return IsVowel(c) ? false : true;
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, half it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.
        public static int CollatzConjecture(int number)
        {
            int steps = 0;
            while (number != 1)
            {
                number = (number % 2 == 0) ? (number / 2) : ((number * 3) + 1);
                steps++;
            }
            return steps;
        }


        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).
        public static DateTime[] GetNext7Days(DateTime dateTime)
        {
            DateTime[] week = new DateTime[7];
            for (int i = 0; i < 7; i++)
            {
                week[i] = dateTime.AddDays(i);
            }
            return week;
        }

        // 18. Create a method called IsLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)
        public static bool IsLeapYear(int year)
        {
            return (DateTime.IsLeapYear(year)) ? true : false;
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */
        public static void MortgageCalculator()
        {

        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.
        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}