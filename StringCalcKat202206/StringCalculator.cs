namespace StringCalcKat202206;

public class StringCalculator
{
    public object Add(string numbers)
    {
        if (String.IsNullOrEmpty(numbers)) return 0;

        var delimiters = new List<char>() {',', '\n'};

        string numberString = numbers;

        if (numberString.StartsWith("//"))
        {
            var splitInput = numberString.Split('\n');
            var newDelimiter = splitInput.First().Trim('/');
            numberString = String.Join('\n', splitInput.Skip(1));
            delimiters.Add(Convert.ToChar(newDelimiter));
        }

        var numberList = numberString.Split(delimiters.ToArray())
            .Select(int.Parse);

        var enumerable = numberList as int[] ?? numberList.ToArray();
        var negatives = enumerable
            .Where(n => n < 0);

        IEnumerable<int> ints = negatives as int[] ?? negatives.ToArray();
        if (ints.Any())
        {
            string negativeString = String.Join(',', ints
                .Select(n => n.ToString()));
            throw new Exception($"Negatives not allowed: {negativeString}");
        }
        
        var result = enumerable
            .Sum();
        
        return result;
    }
}