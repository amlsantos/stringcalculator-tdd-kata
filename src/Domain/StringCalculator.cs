
namespace Domain;

public class StringCalculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers))
            return 0;

        if (Is1Integer(numbers))
            return int.Parse(numbers);

        if (IsCustomDelimeter(numbers))
        {
            return SumWithCustomDelimeter(numbers);
        }
        else
        {
            return Sum(numbers);
        }
    }

    private bool Is1Integer(string numbers) => numbers.Length == 1;

    private bool IsCustomDelimeter(string numbers) => numbers.StartsWith("//");

    private int SumWithCustomDelimeter(string numbers)
    {
        var separators = numbers.Substring(2, 1).ToCharArray();
        var input = numbers.Substring(4);

        return Sum(input, separators);
    }

    private int Sum(string numbers)
    {
        char[] separators = [',', '\n'];
        string input = numbers;

        return Sum(input, separators);
    }

    private int Sum(string input, char[] separators)
    {
        var numbers = input.Split(separators).Select(x => int.Parse(x));
        var negatives = numbers.Where(x => x < 0).ToList();

        if (negatives.Any())
        {
            var message = "Negatives not allowed: ";
            var negativesMessage = string.Join(',', negatives.Select(x => x.ToString()));
            
            throw new InvalidOperationException(message + negativesMessage);
        }

        return numbers.Sum();
    }
}
