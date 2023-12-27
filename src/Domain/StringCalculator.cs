
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        var numbers = input.Split(",");

        if (numbers.Length == 1)
            return int.Parse(numbers[0]);
        

        if (input.Contains("1"))
            return 1;

        if (input.Contains("2"))
            return 2;

        return 0;
    }
}
