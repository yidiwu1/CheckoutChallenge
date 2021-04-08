namespace WebPayment.Shared.Models
{
    public class PaymentRequest
    {
        public PaymentAmount Amount { get; set; }
        public string Reference { get; set; }
        public string ReturnUrl { get; set; }
        public string RedirectFromIssuerMethod { get; set; } = "GET";
        public string MerchantAccount { get; set; }
        public RiskData RiskData { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public BillingAddress BillingAddress { get; set; }
        public bool StorePaymentMethod { get; set; }
        public BrowserInfo BrowserInfo { get; set; }
        public bool ClientStateDataIndicator { get; set; }
    }
}
