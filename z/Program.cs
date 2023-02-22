delegate void NotificationHandler(string message);
class EmailService
{
    public void SendEmail(string recipientEmailAddress, string message)
    {
        Console.WriteLine($"Send message '{message}' to phone email '{recipientEmailAddress}'.");
    }
}
class SMSNotificationService
{
    public void SendSMS(string phoneNumber, string message)
    {
        Console.WriteLine($"Send message '{message}' to phone number '{phoneNumber}'.");
    }
}
class NotificationManager
{
    public event NotificationHandler NotificationSent;

    public void Notify(string message, string target)
    {
        if (target == "email")
        {
            EmailService emailService = new EmailService();
            emailService.SendEmail("recipient@example.com", message);
        }
        else if (target == "sms")
        {
            SMSNotificationService smsService = new SMSNotificationService();
            smsService.SendSMS("555-555-5555", message);
        }

        if (NotificationSent != null)
        {
            NotificationSent(message);
        }
    }
}
class Program
{
    static void HandleNotification(string message)
    {
        Console.WriteLine("Notification sent with message: " + message);
    }
    
    static void Main(string[] args)
    {
        NotificationManager objNotiMagr = new NotificationManager();
        objNotiMagr.NotificationSent += HandleNotification;

        objNotiMagr.Notify("Hello, world!", "email");
        Console.WriteLine();
        objNotiMagr.Notify("Hello, world!", "sms");
    }

    
}