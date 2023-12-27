
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        string[]? numbers;
        if (IsCustomSeparator(input))
        {
            numbers = GetCustomSeparatedNumbersAsString(input);
        }
        else
        {
            numbers = GetNumbersAsString(input);
        }

        var result = numbers
            .Select(x => int.Parse(x))
            .Sum();

        return result;
    }

    private static bool IsCustomSeparator(string input)
    {
        return input.StartsWith("//");
    }

    private string[] GetCustomSeparatedNumbersAsString(string input)
    {
        var separator = input.Substring(2, 1);
        var customInput = input.Substring(4);

        return customInput.Split(separator);
    }

    private string[]? GetNumbersAsString(string input)
    {
        var separators = new char[] { ',', '\n' };

        return input
            .Split(separators);
    }
}
