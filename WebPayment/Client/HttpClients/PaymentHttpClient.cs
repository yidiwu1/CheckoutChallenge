using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using WebPayment.Shared.Models;

namespace WebPayment.Client.HttpClients
{
    public class PaymentHttpClient : IPaymentHttpClient
    {
        private readonly HttpClient httpClient;
        private readonly ILogger<PaymentHttpClient> logger;

        public PaymentHttpClient(HttpClient httpClient, ILogger<PaymentHttpClient> logger)
        {
            this.httpClient = httpClient;
            this.logger = logger;
        }

        public async Task<List<Payment>> Get()
        {
            return await httpClient.GetFromJsonAsync<List<Payment>>("");
        }

        public async Task<Payment> Get(int id)
        {
            return await httpClient.GetFromJsonAsync<Payment>(id.ToString());
        }

        public async Task<Payment> GetStatus(Payment payment)
        {
            var response = await httpClient.PostAsJsonAsync($"status", payment);
            return await response.Content.ReadFromJsonAsync<Payment>();
        }

        public async Task<string> GetPaymentMethods(double amount)
        {
            logger.LogInformation($"Payment methods for {amount}");
            return await httpClient.GetStringAsync($"paymentmethods/{amount}");
        }
        [JSInvokable]
        public async Task<string> MakePayment(object paymentMethod, int OrderID)
        {
            logger.LogInformation($"make payment");
            var response = await httpClient.PostAsJsonAsync($"makepayment/{OrderID}", paymentMethod);
            string result = await response.Content.ReadAsStringAsync();
            logger.LogInformation(result);
            return result;
        }
    }
}
