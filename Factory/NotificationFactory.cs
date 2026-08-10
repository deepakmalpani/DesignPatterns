class NotificationFactory
{
    private static readonly Dictionary<NotificationType, Func<INotification>>
    _creators = new()
    {
        { NotificationType.Email, () => new EmailNotification() },
        { NotificationType.SMS, () => new SmsNotification() },
        { NotificationType.Push, () => new PushNotification() }
    };
    public static INotification Create(NotificationType type)
    {
        if (!_creators.TryGetValue(type, out var creator))
        {
            throw new ArgumentException("Unknown notification type provided");
        }
        return creator();
    }
}