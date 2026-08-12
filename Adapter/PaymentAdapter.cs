class PaymentAdapter : IPaymentProcessor
{
    LegacyPaymentGateway _legacyPaymentGateway;
    public PaymentAdapter(LegacyPaymentGateway legacyPaymentGateway)
    {
        _legacyPaymentGateway = legacyPaymentGateway;
    }
    public void Pay(double amount)
    {
        _legacyPaymentGateway.MakePayment(amount);
    }
}