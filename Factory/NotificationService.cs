public class NotificationService
{
    public void SendNotification(string type, string message)
    {
        try
        {
            INotification notification = NotificationFactory.Create(type);
            notification.Send(message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }
}