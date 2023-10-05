namespace WebApplication1;

public class PAymentService
{
    public IEnumerable<Payment> ProcessPayment(string paymentType, int amount, string currency)
    {
        if (paymentType == "CreditCard")
        {
            Console.WriteLine("Обработка платежа по кредитной карте: $" + amount);
        }
        else if (paymentType == "PayPal")
        {
            Console.WriteLine("Обработка платежа через PayPal: $" + amount);
        }
        else if (paymentType == "Bitcoin")
        {
            Console.WriteLine("Обработка платежа через Bitcoin: $" + amount);
        }
        else
        {
            Console.WriteLine("Неподдерживаемый метод оплаты");
        }
        
        yield return new Payment
        {

            PaymentId = Guid.NewGuid().ToString(),
            Amount = amount,
            Currency = currency,
            PaymentMethod = paymentType,
            Status = "Success"
        };
    }
}