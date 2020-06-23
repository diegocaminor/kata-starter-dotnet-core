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

            numbers = numbers.Replace("\n", ",");
            var res = numbers.Split(",").Select(int.Parse);
            return res.Sum();
        }
    }
}