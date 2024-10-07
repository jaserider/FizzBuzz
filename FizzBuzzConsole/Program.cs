using FizzBuzz;

namespace FizzBuzzConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz!");

            var fizzBuzz = new FizzBuzz.FizzBuzz();
            fizzBuzz.AddRule(new FizzBuzzRule());
            fizzBuzz.AddRule(new FizzRule());
            fizzBuzz.AddRule(new BuzzRule());

            for (int count = 1; count <= 100; count++)
            {
                Console.WriteLine(count + " = " + fizzBuzz.GetStringFromNumber(count));
            }
            Console.ReadKey();
        }
    }
}
