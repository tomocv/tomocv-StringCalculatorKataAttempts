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
}