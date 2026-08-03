public sealed class Logger
{
    private static readonly Logger instance = new Logger();

    private Logger() { }

    public static Logger Instance => instance;

    public void Log(string log)
    {
        Console.WriteLine(log);
    }
}