using System.Text.RegularExpressions;
using Calc = CalculatorClassLibrary;
namespace Console_Application;

internal class Program
    {
        static void Main(string[] args)
        {
            Calc.Calculator calculator = new Calc.Calculator();

        if (!IsCorrectInput(args))
        {
            return;
        }

            


            // Act

            // Assert


        }

    private static bool IsCorrectInput(String[] args)
    {
        bool result = false;

        Regex regex = new Regex(@"[0-9][\/\+\-\*][0-9]");

        bool res = regex.IsMatch(args[0]);

        return result;
    }
}
