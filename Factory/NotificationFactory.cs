class NotificationFactory
{
    public static INotification Create(NotificationType type)
    {
        if(type == NotificationType.Email)
        {
            return new EmailNotification();
        }
        else if(type == NotificationType.SMS)
        {
            return new SmsNotification();
        }
        else if(type == NotificationType.Push)
        {
            return new PushNotification();
        }
        else
        {
            throw new ArgumentException("Unknown notification type provided");
        }
    }
}