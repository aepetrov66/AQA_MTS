using Newtonsoft.Json.Linq;

namespace NUnitHW;

[TestFixture, Category("Int Tests")]
internal class TestInt : PrePostConditionExample
{
    [TestCaseSource(typeof(TestData), nameof(TestData.DivideCasesInt))]
    [Order(1)]
    [Category("Positive")]
    [Severity(SeverityLevel.Critical)]
    public void DivPositive(int x, int y, int result)
    {
        Assert.That(calculator.Div(x, y), Is.EqualTo(result));
    }
    [Test(Description = "Проверка деления на 0"), MaxTime(2000)]
    [Order(2)]
    [Category("Negative")]
    [Severity(SeverityLevel.Critical)]
    public void DivByZero([Random(1, 10, 5)] int randomNumber)
    {
        Assert.Throws<DivideByZeroException>(() =>
        {
            int result = calculator.Div(randomNumber, 0);
        });
    }

    [Test, Combinatorial]
    public void CombinatorialTest([Values(1, 2, 3)] int number1, [Values(1, 2, 3)] int number2)
    {
        Console.WriteLine($"{calculator.Div(number1, number2)}");
    }

    [TestCase(2, 1, ExpectedResult = 2), Repeat(3)]
    public int Test2(int x, int y)
    {
        return calculator.Div(x, y);
    }
}
