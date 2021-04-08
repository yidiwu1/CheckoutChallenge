using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebPayment.Shared.Models;
using WebPayment.Shared.ViewModel;

namespace WebPayment.Client.HttpClients
{
    public class OrdersHttpClient : IOrdersHttpClient
    {
        private readonly HttpClient httpClient;

        public OrdersHttpClient(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<List<OrderStatus>> Get()
        {
            return await httpClient.GetFromJsonAsync<List<OrderStatus>>("");
        }

        public async Task<IOrder> Get(int id)
        {
            return await httpClient.GetFromJsonAsync<Order>(id.ToString());
        }

        public async Task Update(IOrder order)
        {
            await httpClient.PutAsJsonAsync(order.OrderID.ToString(), order);
        }

        public async Task<IOrder> Create(IOrder order)
        {
            HttpResponseMessage response = await httpClient.PostAsJsonAsync("", order);
            return await response.Content.ReadFromJsonAsync<Order>();
        }

        public async Task Delete(int id)
        {
            await httpClient.DeleteAsync(id.ToString());
        }
    }
}
