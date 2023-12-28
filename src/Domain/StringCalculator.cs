
namespace Domain;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        if (numbers.Length == 1)
            return int.Parse(numbers);

        if (IsCustomDelimeter(numbers))
        {
            var customDelimeter = numbers.Substring(2, 1);
            var customInput = numbers.Substring(4);

            return customInput.Split(customDelimeter)
                .Select(x => int.Parse(x))
                .Sum();
        }

        var separators = new char[] { ',', '\n' };
        var sum = numbers.Split(separators)
            .Select(x => int.Parse(x))
            .Sum();

        return sum;
    }

    private bool IsCustomDelimeter(string numbers)
    {
        return numbers.StartsWith("//");
    }
}
