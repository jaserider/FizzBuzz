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

    public class FizzBuzz
    {
        private List<IRuleInterface> rules = new List<IRuleInterface>();

        public void AddRule(IRuleInterface rule)
        {
            rules.Add(rule);
        }

        public string GetStringFromNumber(int number)
        {
            foreach (IRuleInterface rule in rules)
            {
                if (rule.MatchesRule(number))
                {
                    return rule.GetFizzBuzzString();
                }
            }
            return number.ToString();
        }
    }
}
