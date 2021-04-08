using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPayment.Shared.Models
{
    public class PaymentDetails
    {
        //This should not be in clean model...It's an anti pattern..
        public void AddDetail(string key, string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                Details.Add(key, value);
            }
        }

        public Dictionary<string, string> Details = new Dictionary<string, string>();
        public string PaymentData { get; set; }
    }
}
