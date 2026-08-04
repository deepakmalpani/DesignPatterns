public class PushNotification : INotification
{
    public void Send(string message)
    {
        Console.WriteLine($"Push notification sent, summary: {message}");
    }
}