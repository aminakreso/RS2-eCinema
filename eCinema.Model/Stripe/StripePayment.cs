namespace eCinema.Model.Stripe;

public class StripePayment
{
    private string CustomerId { get; set; }
    string ReceiptEmail { get; set; }
    string Description { get; set; }
    string Currency { get; set; }
    long Amount { get; set; }
    string PaymentId { get; set; }
    public StripePayment(string customerId, string receiptEmail, string description, string currency, long amount, string paymentId)
    {
        CustomerId = customerId;
        ReceiptEmail = receiptEmail;
        Description = description;
        Currency = currency;
        Amount = amount;
        PaymentId = paymentId;
    }

    
}