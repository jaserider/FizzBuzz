namespace FizzBuzz
{
    public class FizzBuzz
    {
        private List<IRuleInterface> rules = new List<IRuleInterface>();

        public void AddRule(IRuleInterface rule)
        {
            rules.Add(rule);
        }

        public List<Tuple<string, string>> GenerateList(int number)
        {
            var output = new List<Tuple<string, string>>();

            for (int i = 1; i <= number; i++)
            {
                output.Add(Tuple.Create(i.ToString(), GetStringFromNumber(i)));
            }

            return output;
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
