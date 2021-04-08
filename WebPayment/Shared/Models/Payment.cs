using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPayment.Shared.Models
{
    public class Payment
    {
        [Key]
        public int PaymentID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public string PaymentData { get; set; }
        public string RedirectData { get; set; }
        public string MD { get; set; }
        public string PaRes { get; set; }
        public string Status { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
    }
}
