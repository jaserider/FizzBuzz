namespace FizzBuzz
{
    public interface IRuleInterface
    {
        bool MatchesRule(int number);
        string GetFizzBuzzString();
    }

    public class FizzRule : IRuleInterface
    {
        public bool MatchesRule(int number)
        {
            return number % 3 == 0;
        }

        public string GetFizzBuzzString()
        {
            return "Fizz";
        }
    }

    public class BuzzRule : IRuleInterface
    {
        public bool MatchesRule(int number)
        {
            return number % 5 == 0;
        }

        public string GetFizzBuzzString()
        {
            return "Buzz";
        }
    }

    public class FizzBuzzRule : IRuleInterface
    {
        public bool MatchesRule(int number)
        {
            return number % 3 == 0 && number % 5 == 0;
        }

        public string GetFizzBuzzString()
        {
            return "Fizzbuzz";
        }
    }

}
