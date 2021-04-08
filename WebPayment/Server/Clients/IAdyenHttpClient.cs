using System.Threading.Tasks;
using WebPayment.Shared.Models;

namespace WebPayment.Server.Clients
{
    public interface IAdyenHttpClient
    {
        Task<string> GetPaymentMethods(double amount);
        Task<string> MakePayment(PaymentRequest requestData, Payment payment);
        Task<string> GetPaymentStatus(Payment payment);
    }
}