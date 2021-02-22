using System;
using System.Collections.Generic;

#nullable disable

namespace ThreeDeePrintingHub.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            OrderStatusHistories = new HashSet<OrderStatusHistory>();
        }
        //lkj;lkj;lkj
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int OrderStatusId { get; set; }
        public string CreatedOn { get; set; }
        public string ModifiedOn { get; set; }

        public virtual Member Member { get; set; }
        public virtual OrderStatus OrderStatus { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<OrderStatusHistory> OrderStatusHistories { get; set; }
    }
}
