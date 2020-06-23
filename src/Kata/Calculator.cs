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

            var res = numbers.Split(",");
            if (res.Length > 1)
            {
                return int.Parse(res[0]) + int.Parse(res[1]);

            }
            else
            {
                return int.Parse(numbers);
            }
        }
    }
}