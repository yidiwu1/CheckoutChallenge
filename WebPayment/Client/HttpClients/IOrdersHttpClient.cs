using System.Collections.Generic;
using System.Threading.Tasks;
using WebPayment.Shared.Models;
using WebPayment.Shared.ViewModel;

namespace WebPayment.Client.HttpClients
{
    public interface IOrdersHttpClient
    {
        Task<IOrder> Create(IOrder order);
        Task Delete(int id);
        Task<List<OrderStatus>> Get();
        Task<IOrder> Get(int id);
        Task Update(IOrder order);
    }
}