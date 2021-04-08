using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPayment.Server.Clients;
using WebPayment.Server.Controllers;
using WebPayment.Server.Data;
using WebPayment.Shared.Models;
using Xunit;

namespace WebPayment.Test
{
    public class TestPayment
    {
        PaymentController _paymentController;
        WebPaymentServerContext _webPaymentServerContext;

        public TestPayment()
        {
            var options = new DbContextOptionsBuilder<WebPaymentServerContext>()
    .UseInMemoryDatabase(databaseName: "order")
    .Options;
            Mock<IAdyenHttpClient> adyenHttpClient = new Mock<IAdyenHttpClient>();
            adyenHttpClient.Setup(x => x.MakePayment(It.IsAny<PaymentRequest>(), It.IsAny<Payment>())).ReturnsAsync(@"
{ 
    ""paymentData"": ""data123"",
    ""resultCode"": ""Mocked""
}");
            NullLogger<PaymentController> logger = new NullLogger<PaymentController>();
            _webPaymentServerContext = new WebPaymentServerContext(options);
            _paymentController = new PaymentController(adyenHttpClient.Object, _webPaymentServerContext, logger);
        }
            
        [Fact]
        public async Task TestMakePayment()
        {
            Order order = new Order()
            {
                Description = "test",
                Amount = 43,
                EmailAddress = "test@test.nl"
            };
            _webPaymentServerContext.Order.Add(order);
            _webPaymentServerContext.SaveChanges();
            PaymentRequest paymentRequest = new PaymentRequest()
            {
                Amount = order.Amount,
                PaymentMethod = new PaymentMethod()
                {
                    Type = "test"
                }
            };
            await _paymentController.MakePayment(order.OrderID, paymentRequest);
            Payment payment = _webPaymentServerContext
                .Payment
                .Where(payment => payment.OrderID == order.OrderID).FirstOrDefault();
            Assert.NotNull(payment); //payment should be created
            Assert.Equal("data123", payment.PaymentData);
            Assert.Equal("Mocked", payment.Status);

        }
    }
}
