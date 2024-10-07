namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string GetStringFromNumber(int number)
        {
            string result = string.Empty;

            if (number % 3 == 0 && number % 5 == 0)
            {
                result = "Fizzbuzz";
            }
            else if (number % 3 == 0)
            {
                result = "Fizz";
            }
            else if (number % 5 == 0)
            {
                result = "Buzz";
            }
            else
            {
                result = number.ToString();
            }

            return result;
        }
    }
}
