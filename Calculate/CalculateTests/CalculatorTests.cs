using Calculate;

namespace CalculateTests;

[TestClass]

public class CalculatorTests
{
    [TestMethod]

    public void Calculator_Addition_Correct()
    {
        Program prog = new();
        Calculator calc = new();

        double result = default;
        var stringReader = new StringReader("40 + 2");
        var stringWriter = new StringWriter();
        Console.SetIn(stringReader);
        Console.SetOut(stringWriter);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(42, result);
        Assert.AreEqual<string>("42", stringWriter.ToString().Trim());
    }

    [TestMethod]

    public void Calculator_Subtraction_Correct()
    {
        Program prog = new();
        Calculator calc = new();

        double result = default;
        var stringReader = new StringReader("123 - 124");
        var stringWriter = new StringWriter();
        Console.SetIn(stringReader);
        Console.SetOut(stringWriter);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(-1, result);
        Assert.AreEqual<string>("-1", stringWriter.ToString().Trim());
    }

    [TestMethod]
    public void Calculator_Multiplication_Correct()
    {
        Program prog = new();
        Calculator calc = new();

        double result = default;
        var stringReader = new StringReader("12 * 12");
        var stringWriter = new StringWriter();
        Console.SetIn(stringReader);
        Console.SetOut(stringWriter);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(144, result);
        Assert.AreEqual<string>("144", stringWriter.ToString().Trim());
    }

    [TestMethod]
    public void Calculator_Division_Correct()
    {
        Program prog = new();
        Calculator calc = new();

        double result = default;
        var stringReader = new StringReader("25 / 100");
        var stringWriter = new StringWriter();
        Console.SetIn(stringReader);
        Console.SetOut(stringWriter);

        calc.TryCalculate(prog.ReadLine()!, out result);
        prog.WriteLine(result.ToString());

        Assert.AreEqual<double>(.25, result);
        Assert.AreEqual<string>("0.25", stringWriter.ToString().Trim());
    }
}
