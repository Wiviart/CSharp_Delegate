using System;
public delegate void NotificationHandler(string a);
public class EmailService
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"Send message {message} to email {email}.");
    }
}
public class SMSNotificationService
{
    public void SendSMS(string phone, string message)
    {
        Console.WriteLine($"Send message {message} to phone number {phone}.");
    }
}
public class NotificationManager
{
    public event NotificationHandler NotiSend;

    public void Notify(string target, string message)
    {
        bool x = target.Contains('@');
        if (x == true)
        {
            EmailService objEmSer = new EmailService();
            objEmSer.SendEmail(target, message);
            return;
        }
        else
        {
            SMSNotificationService objSmsSer = new SMSNotificationService();
            objSmsSer.SendSMS(target, message);
        }
    }
    public void MessageSent(string target, string message){
        if (NotiSend != null){
            Notify(target, message);
        }
    }
}

internal class Program
{
    static void HandleNotification(string message)
    {
        Console.WriteLine("Notification sent with message: " + message);
    }
    static void Main(string[] args)
    {
        NotificationManager objNotiMagr = new NotificationManager();
        objNotiMagr.NotiSend += HandleNotification;

        Console.Write("Target: ");
        string target = Console.ReadLine();
        Console.Write("Message: ");
        string message = Console.ReadLine();

        objNotiMagr.MessageSent(target, message);
    }
}
