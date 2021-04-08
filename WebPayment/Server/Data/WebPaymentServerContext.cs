using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebPayment.Shared.Models;

namespace WebPayment.Server.Data
{
    public class WebPaymentServerContext : DbContext
    {
        public WebPaymentServerContext()
        {

        }
        public WebPaymentServerContext (DbContextOptions<WebPaymentServerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<WebPayment.Shared.Models.Order> Order { get; set; }
        public virtual DbSet<WebPayment.Shared.Models.Payment> Payment { get; set; }
    }
}
