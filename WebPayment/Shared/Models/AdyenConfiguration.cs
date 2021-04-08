using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPayment.Shared.Models
{
    public class AdyenConfiguration
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Environment { get; set; }
        public string MerchantAccount { get; set; }
        public List<string> AllowedPaymentMethods { get; set; }
        public string CountryCode { get; set; }
        public string Channel { get; set; }
        public string ShopperLocale { get; set; }
    }
}
