var legacyPaymentGateway = new LegacyPaymentGateway();

var paymentAdapter = new PaymentAdapter(legacyPaymentGateway);

var checkoutService = new CheckoutService(paymentAdapter);

checkoutService.Checkout(1000);