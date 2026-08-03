public sealed class Logger
{
    private static volatile Logger instance = new Logger();

    private Logger() { }

    public static Logger Instance
    {
        get
        {
            return instance;
        }
    }

    public void Log(string log)
    {
        Console.WriteLine(log);
    }
}