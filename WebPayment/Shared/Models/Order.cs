using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebPayment.Shared.Models
{
    public interface IOrder
    {
        double Amount { get; set; }
        string Description { get; set; }
        string EmailAddress { get; set; }
        DateTime OrderDate { get; set; }
        int OrderID { get; set; }
        List<Payment> Payments { get; set; }
    }

    public class Order : IOrder
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Description is too long.")]
        public string Description { get; set; }
        [Range(10, 10000, ErrorMessage = "The amount should between 10 and 10000.")]
        public double Amount { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAddress { get; set; }
        [JsonIgnore]
        public List<Payment> Payments { get; set; }
    }
}
