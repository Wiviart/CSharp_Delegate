using System;
public delegate void Maths(int valOne, int valTwo);
class MathsDemo
{
    static void Addition(int valOne, int valTwo)
    {
        int result = valOne + valTwo;
        Console.WriteLine($"Addition: {valOne} + {valTwo} =  {valOne+valTwo}");
    }
    static void Subtraction(int valOne, int valTwo)
    {
        int result = valOne - valTwo;
        Console.WriteLine($"Subtraction: {valOne} - {valTwo} =  {valOne-valTwo}");
    }
    static void Multiplication(int valOne, int valTwo)
    {
        int result = valOne * valTwo;
        Console.WriteLine($"Multiplication: {valOne} * {valTwo} =  {valOne*valTwo}");
    }
    static void Division(int valOne, int valTwo)
    {
        int result = valOne / valTwo;
        Console.WriteLine($"Division: {valOne} / {valTwo} =  {valOne/valTwo}");
    }
    static void Main(string[] args)
    {
        Maths objMaths = new Maths(Addition);
        objMaths += new Maths(Subtraction);
        objMaths += new Maths(Multiplication);
        objMaths += Division;
        if (objMaths != null)
        {
            objMaths(20, 10);
        }
        objMaths -=  Division;
        objMaths -=  Subtraction;
        objMaths -=  Multiplication;
        objMaths -=  Addition;
        if (objMaths == null)
        {
            Console.WriteLine("Hi");
        }
    }
}