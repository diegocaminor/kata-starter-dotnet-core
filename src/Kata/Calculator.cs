using System.Linq;

namespace Kata
{
    public class Calculator
    {
        public int Add(string numbers="")
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;                
            }

            var res = numbers.Split(",").Select(int.Parse);
            return res.Sum();
        }
    }
}