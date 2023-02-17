using System;

public delegate void Dele(string message);

public class Messenger
{
    public event Dele MgsSent;
    public void SentMgs(string message)
    {
        Console.WriteLine("Sending message: " + message);
        // Check if event MgsSent has been register somewhere
        if (MgsSent != null) MgsSent(message);
    }
}
public class Program
{
    static void OnMgsSent(string message)
    {
        Console.WriteLine("Message sent: " + message);
    }
    static void Main(string[] args)
    {
        // Create object mess for Messenger class
        Messenger mess = new Messenger();
        // Register event MgsSent running with OnMgsSent method
        mess.MgsSent += OnMgsSent;
        // Rung method SentMgs of object mess
        mess.SentMgs("Hello");
    }
}