
namespace Domain;

public class StringCalculator
{
    public int Add(string input)
    {
        if (string.IsNullOrEmpty(input))
            return 0;

        string[]? numbers;
        if (input.StartsWith("//"))
        {
            // custom separator
            var customSeparator = input.Substring(2, 1);
            input = input.Substring(4);

            numbers = input.Split(customSeparator);
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

    private string[]? GetNumbersAsString(string input)
    {
        string[]? numbers;

        var separators = new char[] { ',', '\n' };
        numbers = input.Split(separators);

        return numbers;
    }
}
