using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPayment.Server.Data;
using WebPayment.Server.Clients;
using WebPayment.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.IO;
using Newtonsoft.Json;

namespace WebPayment.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase, IPaymentController
    {
        private readonly IAdyenHttpClient _adyenHttpClient;
        private readonly WebPaymentServerContext _context;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(IAdyenHttpClient adyenHttpClient, WebPaymentServerContext context, ILogger<PaymentController> logger)
        {
            _adyenHttpClient = adyenHttpClient;
            _context = context;
            _logger = logger;
        }

        [HttpGet("paymentmethods/{amount}")]
        public async Task<IActionResult> GetPaymentMethods(double amount)
        {
            return Content(await _adyenHttpClient.GetPaymentMethods(amount));
        }

        [HttpPost("makepayment/{orderID}")]
        public async Task<IActionResult> MakePayment(int orderID, PaymentRequest paymentRequest)
        {
            var order = await _context.Order.FindAsync(orderID);
            Payment payment = new Payment()
            {
                OrderID = orderID
            };
            _context.Add(payment);
            await _context.SaveChangesAsync();
            string paymentResult = await _adyenHttpClient.MakePayment(paymentRequest, payment);

            JObject paymentData = JObject.Parse(paymentResult);
            payment.PaymentData = paymentData.Value<string>("paymentData");
            payment.Status = paymentData.Value<string>("resultCode");
            _context.Update(payment);
            await _context.SaveChangesAsync();
            return Content(paymentResult);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
        {
            return await _context
                .Payment
                .Include(p => p.Order)
                .ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPayment(int id)
        {
            var payment = await _context
                .Payment
                .Include(p => p.Order)
                .FirstOrDefaultAsync(p => p.PaymentID == id);

            if (payment == null)
            {
                return NotFound();
            }

            return payment;
        }

        [HttpPost("status")]
        public async Task<ActionResult<Payment>> GetPaymentStatus(Payment payment)
        {
            if(payment.PaymentData == null || payment.Status == "Authorised")
            {
                return payment; //no additional action can be done?
            }
            try
            {
                string paymentResult = await _adyenHttpClient.GetPaymentStatus(payment);
                JObject paymentStatus = JObject.Parse(paymentResult);
                payment.Status = paymentStatus.Value<string>("resultCode");
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Failed to get status.");
                payment.Status = "Failed";
            }
            _context.Update(payment);
            await _context.SaveChangesAsync();
            return new OkObjectResult(payment);
        }
    }
}
