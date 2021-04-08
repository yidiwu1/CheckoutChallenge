namespace WebPayment.Shared.Models
{
    public class BillingAddress
    {
        public string Street { get; set; }
        public string HouseNumberOrName { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
    }
}

