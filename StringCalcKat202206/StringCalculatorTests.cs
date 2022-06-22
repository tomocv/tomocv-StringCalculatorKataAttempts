namespace StringCalcKat202206;

public class StringCalculatorTests
{
    private readonly StringCalculator _calculator = new StringCalculator();
    
    [SetUp]
    public void Setup()
    {
        
    }

    [Test]
    public void Should_return_0_for_empty_string()
    {
        var result = _calculator.Add("");
        
        Assert.That(result, Is.EqualTo(0));
    }
    
    [Test,
    TestCase("1", 1),
    TestCase("2", 2)]
    public void Should_return_1_for_string_1(string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        
        Assert.That(result, Is.EqualTo(expectedResult));
    }
}