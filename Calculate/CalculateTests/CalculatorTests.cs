using Calculate;

namespace CalculateTests;

[TestClass]

public class CalculatorTests
{
    Program prog = new();
    Calculator calc = new();
    double result = default;
    StringWriter stringWriter = new StringWriter();

    [TestInitialize]
    public void TestInit()
    {
        Console.SetOut(stringWriter);
    }

    [TestMethod]

    public void Calculator_Addition_Correct()
    {
        var stringReader = new StringReader("40 + 2");
        Console.SetIn(stringReader);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(42, result);
        Assert.AreEqual<string>("42", stringWriter.ToString().Trim());
    }

    [TestMethod]

    public void Calculator_Subtraction_Correct()
    {
        var stringReader = new StringReader("123 - 124");
        Console.SetIn(stringReader);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(-1, result);
        Assert.AreEqual<string>("-1", stringWriter.ToString().Trim());
    }

    [TestMethod]
    public void Calculator_Multiplication_Correct()
    {
        var stringReader = new StringReader("12 * 12");
        Console.SetIn(stringReader);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(144, result);
        Assert.AreEqual<string>("144", stringWriter.ToString().Trim());
    }

    [TestMethod]
    public void Calculator_Division_Correct()
    {
        var stringReader = new StringReader("25 / 100");
        Console.SetIn(stringReader);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(.25, result);
        Assert.AreEqual<string>("0.25", stringWriter.ToString().Trim());
    }
}
