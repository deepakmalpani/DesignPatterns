public class NotificationService
{
    public void SendNotification(string type, string message)
    {
        if(string.Equals(type, nameof(NotificationType.Email), StringComparison.OrdinalIgnoreCase))
        {
            INotification emailNotification = new EmailNotification();
            emailNotification.Send(message);
        }
        else if(string.Equals(type, nameof(NotificationType.SMS), StringComparison.OrdinalIgnoreCase))
        {
            INotification smsNotification = new SmsNotification();
            smsNotification.Send(message);
        }
        else if(string.Equals(type, nameof(NotificationType.Push), StringComparison.OrdinalIgnoreCase))
        {
            INotification pushNotification = new PushNotification();
            pushNotification.Send(message);
        }
        else
        {
            Console.WriteLine("Unknown type, allowed types: email, sms, push");
        }
    }
}