class LegacyPaymentGateway
{
    public void MakePayment(double amountInRupees)
    {
        Console.WriteLine(
            $"Payment of ₹{amountInRupees} processed through Legacy Gateway");
    }
}