
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        var numbers = input.Split(",");

        var result = numbers
            .Select(x => int.Parse(x))
            .Sum();

        return result;
    }
}
