using System.Collections.Generic;
using System.Threading.Tasks;
using WebPayment.Shared.Models;

namespace WebPayment.Client.HttpClients
{
    public interface IPaymentHttpClient
    {
        Task<List<Payment>> Get();
        Task<Payment> Get(int id);
        Task<string> GetPaymentMethods(double amount);
        Task<string> MakePayment(object paymentMethod, int OrderID);
        Task<Payment> GetStatus(Payment payment);
    }
}