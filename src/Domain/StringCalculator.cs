
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

        return 0;
    }
}
