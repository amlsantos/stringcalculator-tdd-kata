
namespace Domain;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        if (numbers.Length == 1)
            return int.Parse(numbers);

        var sum = numbers.Split(",")
            .Select(x => int.Parse(x))
            .Sum();

        return sum;
    }
}
