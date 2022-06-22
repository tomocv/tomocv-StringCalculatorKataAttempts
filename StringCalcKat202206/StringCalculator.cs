namespace StringCalcKat202206;

public class StringCalculator
{
    public object Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers)) return 0;

        var result = numbers.Split(',')
            .Select(int.Parse)
            .Sum();
        
        return result;
    }
}