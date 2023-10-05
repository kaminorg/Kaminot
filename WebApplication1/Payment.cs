namespace WebApplication1;

public class Payment
{
    public string PaymentId { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; }
    public string PaymentMethod { get; set; }
    public string Status { get; set; }
}