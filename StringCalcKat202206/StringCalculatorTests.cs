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
}