namespace StringCalcKat202206;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator = new StringCalculator();
    
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Should_return_0_When_empty_string()
    {
        var result = _calculator.Add("");
        
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test,
    TestCase("1", 1),
    TestCase("2", 2)]
    public void Should_return_number_When_string_with_one_number(string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test,
     TestCase("1,2", 3),
     TestCase("2,3", 5)]
    public void Should_return_sum_When_string_with_two_comma_separated_numbers
        (string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test,
     TestCase("1,2,3", 6),
     TestCase("2,3,4", 9)]
    public void Should_return_sum_When_string_with_three_comma_separated_numbers
        (string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test,
     TestCase("1\n2,3", 6),
     TestCase("1\n2\n3", 6),
     TestCase("1,2\n3", 6)]
    public void Should_return_sum_When_string_with_three_comma_or_new_line_separated_numbers
        (string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test,
     TestCase("//;\n1;2;3", 6)]
    public void Should_return_sum_When_string_with_custom_delimiter
        (string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
    
    [Test,
     TestCase("-1,2", "Negatives not allowed: -1"),
     TestCase("-1,-2", "Negatives not allowed: -1,-2")]
    public void Should_Throws_When_Negative_Inputs
        (string numbers, string expectedMessage)
    {
        void Action() => _calculator.Add(numbers);

        var ex = Assert.Throws<Exception>(Action);
        
        Assert.That(ex.Message, Is.EqualTo(expectedMessage));
    }
    
    [Test,
     TestCase("1,2,3000", 3),
     TestCase("1001,2", 2),
     TestCase("1000,2", 1002)]
    public void Should_return_sum_When_string_ignoring_values_over_1000
        (string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}