public class AccountService
{
    private Logger _logger = Logger.Instance;
    public void CreateAccount()
    {
        Console.WriteLine(_logger.GetHashCode());
        _logger.Log("Account Created!");
    }
}