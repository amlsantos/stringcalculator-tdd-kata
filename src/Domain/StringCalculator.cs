
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        var numbers = GetNumbers(input);
        var result = numbers
            .Select(x => int.Parse(x))
            .Sum();

        return result;
    }    

    private string[]? GetNumbers(string input)
    {
        switch (IsCustomSeparator(input))
        {
            case true:
                return GetCustomSeparatedNumbersAsString(input);
            default:
                return GetNumbersAsString(input);
        }
    }

    private bool IsCustomSeparator(string input)
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
