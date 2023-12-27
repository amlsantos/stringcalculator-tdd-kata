
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        var formatedInput = GetNumbers(input);
        var numbers = formatedInput.Select(x => int.Parse(x));
        
        if (numbers.Any(x => x < 0))
        {
            var negativeNumber = numbers.First(x => x < 0);
            
            throw new InvalidOperationException($"Negatives not allowed: {negativeNumber}");
        }

        var sum = numbers.Sum();

        return sum;
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
