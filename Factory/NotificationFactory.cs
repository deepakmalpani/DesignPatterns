class NotificationFactory
{
    public static INotification Create(string type)
    {
        if(string.Equals(type, nameof(NotificationType.Email), StringComparison.OrdinalIgnoreCase))
        {
            return new EmailNotification();
        }
        else if(string.Equals(type, nameof(NotificationType.SMS), StringComparison.OrdinalIgnoreCase))
        {
            return new SmsNotification();
        }
        else if(string.Equals(type, nameof(NotificationType.Push), StringComparison.OrdinalIgnoreCase))
        {
            return new PushNotification();
        }
        else
        {
            throw new Exception("Unknown notification type provided");
        }
    }
}