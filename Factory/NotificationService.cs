public class NotificationService
{
    public void SendNotification(string type, string message)
    {
        if(type == "email")
        {
            EmailNotification emailNotification = new EmailNotification();
            emailNotification.Send(message);
        }
        else if(type == "sms")
        {
            SmsNotification smsNotification = new SmsNotification();
            smsNotification.Send(message);
        }
        else if(type == "push")
        {
            PushNotification pushNotification = new PushNotification();
            pushNotification.Send(message);
        }
        else
        {
            Console.WriteLine("Unknown type, allowed types: email, sms, push");
        }
    }
}