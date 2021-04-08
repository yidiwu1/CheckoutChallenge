using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using WebPayment.Shared.Models;

namespace WebPayment.Server.Clients
{
    public class AdyenHttpClient : IAdyenHttpClient
    {
        private readonly HttpClient _httpClient;
        private readonly AdyenConfiguration _configuration;
        private readonly ILogger<AdyenHttpClient> _logger;
        private readonly DefaultContractResolver _contractResolver;
        JsonSerializerSettings _jsonSerializeSettings;
        public AdyenHttpClient(HttpClient httpClient, IConfiguration configuration, ILogger<AdyenHttpClient> logger)
        {
            _httpClient = httpClient;
            string apiKey = configuration["ApiKey"];
            _httpClient.DefaultRequestHeaders.Add("X-API-key", apiKey);
            _logger = logger;
            _contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };
            _jsonSerializeSettings = new JsonSerializerSettings()
             {
                 ContractResolver = _contractResolver,
                 Formatting = Formatting.Indented,
                 ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                 NullValueHandling = NullValueHandling.Ignore
             };

            IConfigurationSection adyenConfig = configuration.GetSection("AdyenConfiguration");
            _configuration = adyenConfig.Get<AdyenConfiguration>();
        }

        public async Task<string> GetPaymentMethods(double amount)
        {
            PaymentMethodRequest req = new PaymentMethodRequest()
            {
                MerchantAccount = _configuration.MerchantAccount,
                AllowedPaymentMethods = _configuration.AllowedPaymentMethods.ToArray(),
                CountryCode = _configuration.CountryCode,
                Amount = amount,
                Channel = _configuration.Channel,
                ShopperLocale = _configuration.ShopperLocale
            };
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync("paymentMethods", req);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> MakePayment(PaymentRequest requestData, Payment payment)
        {
            requestData.Amount = payment.Order.Amount;
            requestData.Reference = $"Yidi_checkoutChallenge{payment.PaymentID}";
            requestData.ReturnUrl = $"http://localhost:5000/checkout?paymentId={payment.PaymentID}";
            requestData.MerchantAccount = _configuration.MerchantAccount;
            string json = JsonConvert.SerializeObject(requestData, _jsonSerializeSettings);
            HttpResponseMessage response = await _httpClient.PostAsync($"payments", new StringContent(json));
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> GetPaymentStatus(Payment payment)
        {
            PaymentDetails paymentDetails = new PaymentDetails()
            {
                PaymentData = payment.PaymentData
             
            };

            paymentDetails.AddDetail("redirectResult", payment.RedirectData);
            paymentDetails.AddDetail("MD", payment.MD);
            paymentDetails.AddDetail("PaRes", payment.PaRes);
            string json = JsonConvert.SerializeObject(paymentDetails, _jsonSerializeSettings);
            HttpResponseMessage response = await _httpClient.PostAsync($"payments/details", new StringContent(json));
            return await response.Content.ReadAsStringAsync();
        }
    }
}
