namespace WebPayment.Shared.Models
{
    public class PaymentMethod
    {
        public string Type { get; set; }
        public string HolderName { get; set; }
        public string EncryptedCardNumber { get; set; }
        public string EncryptedExpiryMonth { get; set; }
        public string EncryptedExpiryYear { get; set; }
        public string EncryptedSecurityCode { get; set; }
        public string Brand { get; set; }
        public string Issuer { get; set; }
    }

}
