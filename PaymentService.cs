public class PaymentService
{
    public bool ProcessPayment(Payment payment)
    {
        return payment.Amount > 0;
    }
}
