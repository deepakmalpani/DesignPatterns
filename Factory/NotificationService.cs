class NotificationService
{
    public void SendNotification(NotificationType notificationType, string message)
    {
        INotification notification = NotificationFactory.Create(notificationType);
        notification.Send(message);

    }
}