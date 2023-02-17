using System;

delegate void Delegate(int num);
class Program
{
    // Create a method with parameter is same type of delegate
    static void PrintNumber(int number)
    {
        Console.WriteLine($"The number is {number}");
    }
    static void Main(string[] args)
    {
        // Delegate dung de truyen cac method co cung kieu data giong voi parameter da khai bao cho Delegate
        Delegate del = new Delegate(PrintNumber);
        del(42);
    }
}