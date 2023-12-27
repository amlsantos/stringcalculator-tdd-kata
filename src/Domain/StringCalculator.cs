
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        var formatedInput = GetNumbers(input);
        var numbers = formatedInput.Select(x => int.Parse(x)).ToList();
        
        var negatives = numbers.FindAll(x => x < 0);
        ShowError(negatives);

        var sum = numbers
            .Where(x => x < 1000)
            .Sum();

        return sum;
    }

    private static void ShowError(IList<int> negatives)
    {
        if (!negatives.Any())
            return;

        var numbersAsString = string.Join(',', negatives.Select(x => x.ToString()));
        var exceptionMessage = $"Negatives not allowed: {numbersAsString}";

        throw new InvalidOperationException(exceptionMessage);
    }

    private string[] GetNumbers(string input)
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

    private string[] GetNumbersAsString(string input)
    {
        var separators = new char[] { ',', '\n' };

        return input
            .Split(separators);
    }
}
