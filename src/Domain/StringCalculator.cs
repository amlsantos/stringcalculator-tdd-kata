
namespace Domain;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        if (numbers.Length == 1)
            return int.Parse(numbers);

        var separators = new char[] {',', '\n'};

        var sum = numbers.Split(separators)
            .Select(x => int.Parse(x))
            .Sum();

        return sum;
    }
}
