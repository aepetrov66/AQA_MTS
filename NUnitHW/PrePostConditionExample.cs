namespace NUnitHW;


public class PrePostConditionExample
{
    public Calculator? calculator;

    [OneTimeSetUp]
    public void OnetimeSetup()
    {
        Console.WriteLine("Запуск тестсета");
    }

    [SetUp]
    public void Setup()
    {
        calculator = new Calculator();
    }

    [TearDown]
    public void TearDown()
    {
        calculator = null;
    }

    [OneTimeTearDown]
    public void FinishTests()
    {
        Console.WriteLine($"Завершение тестсета");
    }
}
