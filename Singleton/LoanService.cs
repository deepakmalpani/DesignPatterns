public class LoanService
{
    private Logger _logger = Logger.Instance;
    public void ApproveLoan()
    {
        Console.WriteLine(_logger.GetHashCode());
        _logger.Log("Loan has been approved!");
    }
}