using System;

delegate void Dele(int num);
delegate void Dele1(string num);
delegate int Num(int a, int b);

class Program
{
    static void printInt(int num)
    {
        Console.WriteLine($"Number: {num}");
    }
    static void intPrint(int num)
    {
        Console.WriteLine("Number2: {0}", num + num);
    }
    static void printStr(string str)
    {
        Console.WriteLine($"String: {str}");
    }
    static void strPrint(string str)
    {
        str = (string)(str + 1);
        Console.WriteLine($"String: {str}");
    }
    static int Count(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }
    static void Main(string[] args)
    {
        Dele dele = new Dele(printInt);
        dele(20);
        dele += intPrint;
        dele(30);

        Dele1 dele1 = new Dele1(printStr);
        dele1("abc");
        dele1 += strPrint;
        dele1("xyz");

        Num count = new Num(Count);
        Console.WriteLine(count(10, 2));
        count += Subtract;
        Console.WriteLine(count(10, 12));
    }
}