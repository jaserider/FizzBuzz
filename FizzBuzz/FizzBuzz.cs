namespace FizzBuzz
{
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
