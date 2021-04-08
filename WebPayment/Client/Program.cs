using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WebPayment.Client.HttpClients;

namespace WebPayment.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.RootComponents.Add<App>("#app");
            Uri baseUri = new Uri(builder.HostEnvironment.BaseAddress);
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = baseUri});
            builder.Services.AddHttpClient<IOrdersHttpClient, OrdersHttpClient>(client => client.BaseAddress = new Uri(baseUri, "api/orders/"));
            builder.Services.AddHttpClient<IPaymentHttpClient, PaymentHttpClient>(client => client.BaseAddress = new Uri(baseUri, "api/payment/")); 
            await builder.Build().RunAsync();
        }
    }
}
