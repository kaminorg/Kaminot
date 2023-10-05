using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymantController : ControllerBase
{
    [HttpPost]
    public OkResult Proccess(string type, int value)
    {
        new PAymentService().ProcessPayment(type, value, "usd");
        return new OkResult();
    }
}