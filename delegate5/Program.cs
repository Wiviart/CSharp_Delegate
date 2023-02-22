using System;
public delegate void CalculationHandler(int a, int b);
class Calculator
{
    public event CalculationHandler CalculationComplete;
    public void Add(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public void Subtract(int a, int b)
    {
        Console.WriteLine(a - b);
    }
    public void Multiply(int a, int b)
    {
        Console.WriteLine(a * b);
    }
    public void Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine(0);
            return;
        }
        Console.WriteLine(a / b);
    }
    public void DoCalculations(int a, int b)
    {
        if (CalculationComplete != null)
        {
            CalculationComplete(a, b);
        }
        // CalculationComplete?.Invoke(a,b);
        // return CalculationComplete(a,b);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        calc.CalculationComplete += new CalculationHandler(calc.Add);
        calc.CalculationComplete += new CalculationHandler(calc.Subtract);
        calc.CalculationComplete += new CalculationHandler(calc.Multiply);
        calc.CalculationComplete += new CalculationHandler(calc.Divide);
        
        calc.DoCalculations(10, 5);
    }
}