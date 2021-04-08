using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebPayment.Shared.Models;

namespace WebPayment.Shared.ViewModel
{
    public class OrderStatus : IOrder
    {
        IOrder _order;
        public OrderStatus(IOrder order)
        {
            _order = order;
        }

        public OrderStatus() 
        {
            _order = new Order();
        } 
        public bool IsPaid { get; set; }
        public double Amount { get => _order.Amount; set => _order.Amount = value; }
        public string Description { get => _order.Description; set => _order.Description = value; }
        public string EmailAddress { get => _order.EmailAddress; set => _order.EmailAddress = value; }
        public DateTime OrderDate { get => _order.OrderDate; set => _order.OrderDate = value; }
        public int OrderID { get => _order.OrderID; set => _order.OrderID = value; }
        public List<Payment> Payments { get => _order.Payments; set => _order.Payments = value; }
    }
}
