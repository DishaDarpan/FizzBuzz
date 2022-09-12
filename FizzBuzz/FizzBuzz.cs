namespace FizzBuzz
{
    public class FizzBuzz
    {
        private static bool IsDivisibleBy(int numerator, int denominator)
        {
            return numerator % denominator == 0;
        }
        public string FizzBuzzFor(int n)
        {
            string outcome = "";

            if (IsDivisibleBy(n, 15))
            {
                outcome = "FizzBuzz";
            }
            else if (IsDivisibleBy(n, 3))
            {
                outcome = "Fizz";
            }
            else if (IsDivisibleBy(n, 5))
            {
                outcome = "Buzz";
            }
            if (outcome == "") 
            {
                return n.ToString();
            }
            return outcome;
         }
    }
}