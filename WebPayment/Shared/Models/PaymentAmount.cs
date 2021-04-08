using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPayment.Shared.Models
{
    public class PaymentAmount
    {
        public string Currency { get; set; }
        public double Value { get; set; }
        public static implicit operator PaymentAmount(double value)
        {
            return new PaymentAmount()
            {
                Value = value * 100,
                Currency = "EUR"
            };
        }
    }
}
