public class TransactionService
{
    private Logger _logger = Logger.Instance;
    public void TransferMoney()
    {
        Console.WriteLine(_logger.GetHashCode());
        _logger.Log("Money has been transferred!");
    }
}