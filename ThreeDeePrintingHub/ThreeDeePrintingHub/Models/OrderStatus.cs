using System;
using System.Collections.Generic;

#nullable disable

namespace ThreeDeePrintingHub.Models
{
    public partial class OrderStatus
    {
        public OrderStatus()
        {
            OrderStatusHistories = new HashSet<OrderStatusHistory>();
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
