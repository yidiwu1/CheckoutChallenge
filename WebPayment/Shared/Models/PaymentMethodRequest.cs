using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPayment.Shared.Models
{
    public class PaymentMethodRequest
    {
        public string MerchantAccount { get; set; }
        public string[] AllowedPaymentMethods { get; set; }
        public string CountryCode { get; set; }
        public PaymentAmount Amount { get; set; }
        public string Channel { get; set; }
        public string ShopperLocale { get; set; }
    }
}
