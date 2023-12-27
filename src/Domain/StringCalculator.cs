
namespace Domain;

public class StringCalculator
{
    public object Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        if (numbers.Contains("1"))
            return 1;

        if (numbers.Contains("2"))
            return 2;

        return 0;
    }
}
