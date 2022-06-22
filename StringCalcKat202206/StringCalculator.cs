namespace StringCalcKat202206;

public class StringCalculator
{
    public object Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers)) return 0;

        var delimiters = new char[] {',', '\n'};
        var result = numbers.Split(delimiters)
            .Select(int.Parse)
            .Sum();
        
        return result;
    }
}