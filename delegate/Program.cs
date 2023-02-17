using System;

class Program
{
    // Create delegate get int type variable in, output void type
    public delegate void IntAction(int x);

    public class Counter
    {
        // Delegate must have an event to execute
        public event IntAction Counted;
        // Create method Count
        public void Count(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(i + " - ");
                // Run event
                Counted?.Invoke(i);
            }
        }
    }
    static void Main(string[] args)
    {
        Counter counter = new Counter();
        counter.Counted += delegate (int x)
        {
            Console.WriteLine(x);
        };
        counter.Count(5);
    }
}