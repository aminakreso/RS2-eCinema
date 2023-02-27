namespace eCinema.Model.Stripe;

public class StripeCustomer
{
    public string Name { get; set; }
    public string Email { get; set; }
    public string CustomerId { get; set; }
    public StripeCustomer(string Name, string Email, string CustomerId)
    {
        this.Name = Name;
        this.Email = Email;
        this.CustomerId = CustomerId;
    }

  
}