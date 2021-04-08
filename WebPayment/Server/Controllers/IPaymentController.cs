using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebPayment.Shared.Models;

namespace WebPayment.Server.Controllers
{
    public interface IPaymentController
    {
        Task<IActionResult> GetPaymentMethods(double amount);
        Task<IActionResult> MakePayment(int id, PaymentRequest paymentRequest);
        Task<ActionResult<Payment>> GetPaymentStatus(Payment payment);
    }
}