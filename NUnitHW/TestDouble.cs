namespace NUnitHW;

[TestFixture, Category("Double Tests")]
internal class TestDouble : PrePostConditionExample
{
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesDouble))]
    [Order(1)]
    [Category("Positive")]
    [Severity(SeverityLevel.Critical)]
    public void DivPositive(double x, double y, double result)
    {
        Assert.That(calculator.Div(x, y), Is.EqualTo(result));
    }
    [Test(Description = "Проверка деления на 0")]
    [Order(2)]
    [Category("Negative")]
    [Severity(SeverityLevel.Critical)]
    public void DivByZero([Random(1, 10, 5)] double randomNumber)
    {
        Assert.That(calculator.Div(randomNumber, 0), Is.EqualTo(Double.PositiveInfinity));
    }

    [Test, Ignore("Ignoring this test due Issue"), Combinatorial]
    public void CombinatorialTest([Values(1, 2, 3)] double number1, [Values(1, 2, 3)] double number2)
    {
        Console.WriteLine($"{calculator.Div(number1, number2)}");
    }

    [TestCase(2, 1, ExpectedResult = 2), Retry(3)]
    public double Test2(double x, double y)
    {
        return calculator.Div(x, y);
    }
}
