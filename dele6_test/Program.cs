using System;

public delegate void NotificationHandler(string message);
public class EmailService
{
    public void SendEmail(string email, string message)
    {
        Console.WriteLine($"Send message '{message}' to email '{email}'.");
    }
}
public class SMSNotificationService
{
    public void SendSMS(string phone, string message)
    {
        Console.WriteLine($"Send sms '{message}' to phone '{phone}'.");
    }
}
public class NotificationManager
{
    public event NotificationHandler NotificationSent;

    public void Notify(string message, string target)
    {
        if (target == "email")
        {
            EmailService emlSer = new EmailService();
            emlSer.SendEmail(target, message);
        }
        else
        {
            SMSNotificationService smsSer = new SMSNotificationService();
            smsSer.SendSMS(target, message);
        }
        if (NotificationSent != null)
        {
            NotificationSent(message);
        }
    }
}
class Program
{
    static void NotiSent(string message)
    {
        Console.WriteLine("Message sent.");
    }
    static void Main(string[] args)
    {
        NotificationManager notifi = new NotificationManager();
        notifi.NotificationSent += NotiSent;

        notifi.Notify("Hello World", "email");
        notifi.Notify("Hi World", "phone");
    }
}
